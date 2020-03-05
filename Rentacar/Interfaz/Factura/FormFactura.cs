using Rentacar.Modelos;
using Rentacar.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rentacar.Interfaz.Factura
{
    public partial class FormFactura : Form
    {
        private Bitmap imagenFactura;
        

        public FormFactura()
        {
            InitializeComponent();                                
        }

        private void factura_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(imagenFactura, 0, 0);
        }

        private void imprimir()
        {
            Graphics g = this.CreateGraphics();
            Console.WriteLine(this.Width);
            imagenFactura = new Bitmap(this.Width, this.Height, g);

            Graphics graphics = Graphics.FromImage(imagenFactura);
            graphics.CopyFromScreen(this.Location.X, this.Location.Y, -5, 0, this.Size);
            printPreviewDialog1.ShowDialog();
        }

        public void rellenarDatos(Alquiler alquiler)
        {
            
            Show();
            this.Update();
            imprimir();
        }
    }
}
