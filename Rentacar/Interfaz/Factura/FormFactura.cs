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
            //DATOS VEHICULO
            lbMatricula.Text = alquiler.Vehiculo.Matricula;
            lbMarca.Text = alquiler.Vehiculo.Marca.Nombre;
            lbModelo.Text = alquiler.Vehiculo.Modelo;
            lbAyo.Text = alquiler.Vehiculo.Anio;
            lbPrecioDia.Text = alquiler.Vehiculo.CostoDia.ToString() + " €";
            pictureBoxVehiculo.Image = Image.FromFile(alquiler.Vehiculo.PathAbsolutoFoto);

            alquiler.Vehiculo.Caracteristicas.ForEach(c =>
            {
                Label label = new Label();
                label.Text = c.Nombre;
                label.Size = new Size(label.PreferredWidth, label.PreferredHeight);
                listViewCaracteristicas.Controls.Add(label);
            });
            
            //DATOS CLIENTE
            lbDni.Text = alquiler.Cliente.Dni;
            lbNombre.Text = alquiler.Cliente.Nombre;
            lbTelefono.Text = alquiler.Cliente.Telefono;
            lbDomicilio.Text = alquiler.Cliente.Domilicio;

            //DATOS ALQUILER
            lbFechaInicio.Text = alquiler.FechaInicio.ToString("dd/MM/yyyy");
            lbFechaEntrega.Text = alquiler.FechaFin.ToString("dd/MM/yyyy");
            lbDias.Text = (alquiler.FechaFin - alquiler.FechaInicio).Days.ToString();
            lbCosteDia.Text = alquiler.Vehiculo.CostoDia.ToString() + " €";
            lbPrecioTotalDias.Text = ((alquiler.FechaFin - alquiler.FechaInicio).Days * (alquiler.Vehiculo.CostoDia)).ToString() + " €";
            lbTotalAcceorios.Text = alquiler.CostoTotalAccesorios.ToString() + " €";
            lbTotal.Text = alquiler.Importe.ToString() + " €";
            
            alquiler.Accesorios.ForEach(a =>
            {
                Label label = new Label();
                label.Text = a.Nombre;
                label.Size = new Size(label.PreferredWidth, label.PreferredHeight);
                listViewAccesorios.Controls.Add(label);
            });


            Show();
            this.Update();
            imprimir();
        }
    }
}
