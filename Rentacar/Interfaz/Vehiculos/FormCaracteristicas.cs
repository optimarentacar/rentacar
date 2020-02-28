using Rentacar.Interfaz.Caracteristicas;
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

namespace Rentacar.Interfaz.Vehiculos
{
    public partial class FormCaracteristicas : Form
    {

        private readonly IRepositorioCaracteristica _repositorioCaracteristica;
        private List<Caracteristica> Caracteristicas;
        private Vehiculo Vehiculo;

        public FormCaracteristicas(IRepositorioCaracteristica repositorioCaracteristica)
        {
            _repositorioCaracteristica = repositorioCaracteristica;
            InitializeComponent();
        }

        private async void FormCaracteristicas_Load(object sender, EventArgs e)
        {
            await Listar();

        }


        public async Task ListarCaracteristicasVehiculo(Vehiculo vehiculo)
        {
            Vehiculo = vehiculo;

            groupBox2.Text = groupBox2.Text + " " + vehiculo.Matricula;


            
            if (vehiculo.Caracteristicas is null)
            {
                
                try
                {
                    Vehiculo.Caracteristicas = await _repositorioCaracteristica.ListarPorMatricula(vehiculo.Matricula);


                    listBoxVehiculo.DataSource = Vehiculo.Caracteristicas;
                    listBoxVehiculo.DisplayMember = "Nombre";
                    listBoxVehiculo.ValueMember = "Id";


                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                listBoxVehiculo.DataSource = Vehiculo.Caracteristicas;
                listBoxVehiculo.DisplayMember = "Nombre";
                listBoxVehiculo.ValueMember = "Id";
            }

           
            if (Vehiculo.Caracteristicas.Count > 0 || !(Vehiculo.Caracteristicas is null))
            {
                btnIzquierda.Enabled = true;
            }

        }

        private async Task Listar()
        {
            try
            {
                
                Caracteristicas = await _repositorioCaracteristica.Listar();


                listBoxTodas.DataSource = Caracteristicas;
                listBoxTodas.DisplayMember = "Nombre";
                listBoxTodas.ValueMember = "Id";


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnDerecha_Click(object sender, EventArgs e)
        {
            int id = (int)listBoxTodas.SelectedValue;

            bool existe = false;

            for (int i = 0; i < listBoxVehiculo.Items.Count && !existe; i++)
            {
                if ((listBoxVehiculo.Items[i] as Caracteristica).Id == id)
                {
                    existe = true;
                }
            }

            if (!existe)
            {
                Caracteristica c = new Caracteristica()
                {
                    Id = id,
                    Nombre = (listBoxTodas.SelectedItem as Caracteristica).Nombre
                };
                Console.WriteLine(c.Nombre);
                Vehiculo.Caracteristicas.Add(c);

                listBoxVehiculo.DataSource = null;
                listBoxVehiculo.Items.Clear();
                listBoxVehiculo.DataSource = Vehiculo.Caracteristicas;
                listBoxVehiculo.DisplayMember = "Nombre";
                listBoxVehiculo.ValueMember = "Id";

            }
        }

        private void btnIzquierda_Click(object sender, EventArgs e)
        {
            int id = (int)listBoxVehiculo.SelectedValue;

            Vehiculo.Caracteristicas.RemoveAll(c => c.Id == id);

            listBoxVehiculo.DataSource = null;
            listBoxVehiculo.Items.Clear();
            listBoxVehiculo.DataSource = Vehiculo.Caracteristicas;
            listBoxVehiculo.DisplayMember = "Nombre";
            listBoxVehiculo.ValueMember = "Id";

            if (Vehiculo.Caracteristicas.Count == 0)
            {
                btnIzquierda.Enabled = false;
            }

        }

        

        private async void btnCaracteristicas_Click(object sender, EventArgs e)
        {
            FormGestionCaracteristicas fgc = Program.container
              .GetInstance<FormGestionCaracteristicas>();
            fgc.ShowDialog();

            if (fgc.Cerrado)
            {
                await Listar();
            }
            
        }
    }
}
