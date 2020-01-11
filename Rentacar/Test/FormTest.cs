using Rentacar.Excepciones;
using Rentacar.Modelos;
using Rentacar.Repositorio.Interfaces;
using Rentacar.Repositorio.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rentacar.Test
{
    public partial class FormTest : Form
    {
        private IRepositorioFotografia _repositorioFotografia;
        private IRepositorioVehiculo _repositorioVehiculo;

        public FormTest(IRepositorioFotografia repositorioFotografia,
                        IRepositorioVehiculo repositorioVehiculo)
        {
            _repositorioFotografia = repositorioFotografia;
            _repositorioVehiculo = repositorioVehiculo;
            InitializeComponent();
        }

        //Abrir ventanita de dialogo para buscar imagen con filtro
        private void button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Filter = "JPG(*.jpg)|*.jpg|PNG(*.png)|*.png|GIF(*… *.Png, *.Gif, *.Tiff, *.Jpeg, *.Bmp)|*.Jpg; *.Png; *.Gif; *.Tiff; *.Jpeg; *.Bmp"; 
            openFileDialog1.FilterIndex = 4;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string ruta = openFileDialog1.FileName;
                Bitmap foto = new Bitmap(ruta);
                pictureBox1.Image = (Image)foto;
            }
            else
            {
                if (string.IsNullOrEmpty(openFileDialog1.FileName))
                {
                    MessageBox.Show("No ha Seleccionado ninguna Imagen");
                    return;
                }
            }


        }

        private async void button2_Click(object sender, EventArgs e)
        {
            string rutaRelativa = "";
            bool guardado = false;
            try
            {
                //Guarda la imagen en la carpeta y retorna la ruta relativa de la imagen
                //para guardarla en la base de datos
                //Lanza una excepcion, en tal caso no se guarda el vehiculo
                 rutaRelativa = _repositorioFotografia.Guardar(pictureBox1.Image);

                Vehiculo vehiculo = new Vehiculo()
                {
                    Matricula = "gtit154",
                    Marca = new Marca
                    {
                        Id = 1
                    },
                    Modelo = "ddwd",
                    Anio = "2015",
                    Capacidad = 5,
                    CostoDia = 45.99f,
                    PathFoto = rutaRelativa                  
                };

                 guardado = await _repositorioVehiculo.Crear(vehiculo);
            }
            catch (MatriculaYaExisteException matriculaYaExisteException)
            {
                Console.WriteLine(matriculaYaExisteException.Message);
                //si falla el insert se borra la imagen
                _repositorioFotografia.Borrar(rutaRelativa);
            }
            catch(Exception)
            {
                //si falla el insert se borra la imagen
                _repositorioFotografia.Borrar(rutaRelativa);
                Console.WriteLine("Ocurrió un error");
            }

            if (guardado)
            {
                //Actualizar la lista  y lo que sea
            }

        }

        private async void button3_Click(object sender, EventArgs e)
        {
            Vehiculo vehiculo = await _repositorioVehiculo.Obtener("gtit154");


            pictureBox2.Image = Image.FromFile(vehiculo.PathAbsolutoFoto);
        }
    }
    }
