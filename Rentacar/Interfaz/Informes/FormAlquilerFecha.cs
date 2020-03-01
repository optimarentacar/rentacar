using Rentacar.Enums;
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

namespace Rentacar.Interfaz.Informes
{
    public partial class FormAlquilerFecha : Form
    {
        private readonly IRepositorioAlquiler _repositorioAlquiler;
        private List<Alquiler> Alquileres;

        public FormAlquilerFecha(IRepositorioAlquiler repositorioAlquiler)
        {
            _repositorioAlquiler = repositorioAlquiler;
            InitializeComponent();
        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            DateTime inicio;
            DateTime fin;

            Orden orden = Orden.FECHA;

            if (rbCliente.Checked)
            {
                orden = Orden.CLIENTE;
            }
            if (rbMatricula.Checked)
            {
                orden = Orden.MATRICULA;
            }

            if (checkBoxDesde.Checked)
            {
                inicio = dateTimePickerDesde.Value;
            }
            else
            {
                inicio = DateTime.MinValue;
            }

            if (checkBoxHasta.Checked)
            {
                fin = dateTimePickerHasta.Value;
            }
            else
            {
                fin = DateTime.MaxValue;
            }


            if (rbResumido.Checked)
            {
                try
                {
                    Alquileres = await _repositorioAlquiler.ListarPorFechaResumido(inicio, fin, orden);
                    Console.WriteLine(Alquileres.Count);
                }catch(Exception ex)
                {
                    MessageBox.Show("Ocurrio un error");
                }
            }

            if (rbDetallado.Checked)
            {
                try
                {
                    Alquileres = await _repositorioAlquiler.ListarPorFechaDetallado(inicio, fin, orden);
                    Console.WriteLine(Alquileres.Count);
                    FormListadoDetalladoAlquileres al = Program.container.GetInstance<FormListadoDetalladoAlquileres>();
                    await al.Listar(Alquileres);
                    al.Show();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrio un error");
                }
            }
        }

        private void checkBoxDesde_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerDesde.Enabled = checkBoxDesde.Checked;
        }

        private void checkBoxHasta_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerHasta.Enabled = checkBoxHasta.Checked;
        }
    }
}
