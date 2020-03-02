using FluentValidation.Results;
using Rentacar.Enums;
using Rentacar.Excepciones;
using Rentacar.Modelos;
using Rentacar.Repositorio.Interfaces;
using Rentacar.Validacion;
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
    public partial class FormGestionVehiculos : Form
    {
        private IRepositorioVehiculo _repositorioVehiculo;
        private IRepositorioMarca _repositorioMarca;
        private IRepositorioFotografia _repositorioFotografia;
        private List<Vehiculo> Vehiculos;
        private Vehiculo vehiculo;
        private Operacion operacion;
        private bool FotoCambiada;

        public FormGestionVehiculos(IRepositorioVehiculo repositorioVehiculo,
            IRepositorioMarca repositorioMarca,
            IRepositorioFotografia repositorioFotografia)
        {
            _repositorioVehiculo = repositorioVehiculo;
            _repositorioMarca = repositorioMarca;
            _repositorioFotografia = repositorioFotografia;
            InitializeComponent();
        }

        private async void FormGestionVehiculos_Load(object sender, EventArgs e)
        {
            await cargarComboBox();
            await Listar();
            btnCaracteristicas.Enabled = false;
            this.FotoVehiculo.Click -= new System.EventHandler(this.FotoVehiculo_Click);
        }

        private async Task Listar()
        {
            try
            {
                Vehiculos = await _repositorioVehiculo.Listar();

                Tabla.Rows.Clear();
                for (int i = 0; i < Vehiculos.Count; i++)
                {

                    Tabla.Rows.Add(Vehiculos[i].Matricula, Vehiculos[i].Marca.Nombre,
                        Vehiculos[i].Modelo, Vehiculos[i].Capacidad, Vehiculos[i].Anio, Vehiculos[i].CostoDia);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private async Task cargarComboBox()
        {
            try
            {
                List<Marca> marcas = await _repositorioMarca.Listar();

                comboBoxMarca.DataSource = marcas;
                comboBoxMarca.DisplayMember = "Nombre";
                comboBoxMarca.ValueMember = "Id";

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void TablaVehiculos_SelectionChanged(object sender, EventArgs e)
        {
            if (Tabla.SelectedRows.Count > 0)
            {
                String matricula = Tabla.SelectedRows[0].Cells[0].Value.ToString();
                vehiculo = Vehiculos.FirstOrDefault(v => v.Matricula == matricula);
                textMatricula.Text = vehiculo.Matricula;
                comboBoxMarca.SelectedValue = vehiculo.Marca.Id;
                textModelo.Text = vehiculo.Modelo;
                textAño.Text = vehiculo.Anio;
                textCapacidad.Text = vehiculo.Capacidad.ToString();
                textCosto.Text = vehiculo.CostoDia.ToString();
                FotoVehiculo.Image = Image.FromFile(vehiculo.PathAbsolutoFoto);
                FotoCambiada = false;
                btnCaracteristicas.Enabled = false;
            }
        }
        public void limpiar()
        {
            textMatricula.Text = "";
            comboBoxMarca.Text = "";
            textModelo.Text = "";
            textAño.Text = "";
            textCapacidad.Text = "";
            textCosto.Text = "";
        }

        private void activar()
        {
            btnCancelar.Enabled = false;
            btnValidar.Enabled = false;
            btnPrimero.Enabled = true;
            btnAtras.Enabled = true;
            btnSiguiente.Enabled = true;
            btnUltimo.Enabled = true;
            btnAñadir.Enabled = true;
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
            textMatricula.Enabled = false;
            comboBoxMarca.Enabled = false;
            textModelo.Enabled = false;
            textAño.Enabled = false;
            textCapacidad.Enabled = false;
            textCosto.Enabled = false;
            Tabla.Enabled = true;
            this.FotoVehiculo.Click -= new System.EventHandler(this.FotoVehiculo_Click);

        }

        private void desactivar()
        {
            Tabla.Enabled = false;

            comboBoxMarca.Enabled = true;
            textModelo.Enabled = true;
            textAño.Enabled = true;
            textCapacidad.Enabled = true;
            textCosto.Enabled = true;

            this.FotoVehiculo.Click += new System.EventHandler(this.FotoVehiculo_Click);

            btnAtras.Enabled = false;
            btnPrimero.Enabled = false;
            btnSiguiente.Enabled = false;
            btnUltimo.Enabled = false;
            btnAñadir.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;

            btnValidar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            if (Tabla.Rows.Count > 0)
            {
                Tabla.Rows[0].Selected = true;
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            if (Tabla.Rows.Count > 0)
            {
                if (Tabla.SelectedRows[0].Index > 0)
                {
                    Tabla.Rows[Tabla.SelectedRows[0].Index - 1].Selected = true;
                }
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (Tabla.Rows.Count > 0)
            {
                if (Tabla.SelectedRows[0].Index < Tabla.Rows.Count - 1)
                {
                    Tabla.Rows[Tabla.SelectedRows[0].Index + 1].Selected = true;
                }
            }
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            if (Tabla.Rows.Count > 0)
            {
                Tabla.Rows[Tabla.Rows.Count - 1].Selected = true;
            }
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            limpiar();
            desactivar();
            textMatricula.Enabled = true;
            btnCaracteristicas.Enabled = true;
            operacion = Operacion.CREAR;           
            Graphics graphic = Graphics.FromImage(FotoVehiculo.Image);
            graphic.Clear(Color.White);
            FotoVehiculo.Refresh();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            desactivar();
            Tabla.Enabled = true;

            btnPrimero.Enabled = true;
            btnAtras.Enabled = true;
            btnSiguiente.Enabled = true;
            btnUltimo.Enabled = true;

            textMatricula.Enabled = false;
            comboBoxMarca.Enabled = false;
            textModelo.Enabled = false;
            textAño.Enabled = false;
            textCapacidad.Enabled = false;
            textCosto.Enabled = false;

            operacion = Operacion.ELIMINAR;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            desactivar();
            btnCaracteristicas.Enabled = true;
            operacion = Operacion.MODIFICAR;
        }

        private async void btnValidar_Click(object sender, EventArgs e)
        {
            if (operacion == Operacion.MODIFICAR)
            {

                if (await this.Modificar() == true)
                {
                    await Listar();
                    activar();
                    btnCaracteristicas.Enabled = false;
                }
            }
            if (operacion == Operacion.CREAR)
            {
                if (await this.Crear() == true)
                {
                    await Listar();
                    activar();
                    limpiar();
                    btnCaracteristicas.Enabled = false;
                }
            }
            if (operacion == Operacion.ELIMINAR)
            {
                if (await this.Eliminar() == true)
                {
                    await Listar();
                    activar();
                    limpiar();
                    btnCaracteristicas.Enabled = false;
                }
            }
            
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
            btnCaracteristicas.Enabled = false;
            activar();

        }

        private async Task<bool> Crear()
        {
            
            bool creado = false;
            Vehiculo v = new Vehiculo()
            {
                Matricula = textMatricula.Text.ToUpper(),
                Marca = new Marca()
                {
                    Id = 0
                },
                Modelo = textModelo.Text,
                Capacidad = -1,
                Anio = textAño.Text,
                CostoDia = -1,
                Caracteristicas = vehiculo.Caracteristicas

            };
            try
            {

                int capacidad = Int16.Parse(textCapacidad.Text);
                v.Capacidad = capacidad;
            }
            catch (Exception ex)
            {
                MessageBox.Show("La capacidad no es correcta.");
            }
            try
            {
                float costoDia = float.Parse(textCosto.Text);
                v.CostoDia = costoDia;
            }
            catch (Exception ex)
            {
                MessageBox.Show("El costo no es correcto");
            }
            try
            {
                Marca marca = new Marca()
                {
                    Id = (int)comboBoxMarca.SelectedValue
                };
                v.Marca = marca;
            }
            catch (Exception ex)
            {
                MessageBox.Show("La marca no es correcta.");
            }
            



            ValidacionVehiculo validator = new ValidacionVehiculo();
            ValidationResult results = validator.Validate(v);
            if (!results.IsValid)
            {
                string mensaje = results.Errors[0].ErrorMessage;
                MessageBox.Show(mensaje);
            }
            else
            {
                string rutaRelativa = "";

               

                try
                {
                    //Guarda la imagen en la carpeta y retorna la ruta relativa de la imagen
                    //para guardarla en la base de datos
                    //Lanza una excepcion, en tal caso no se guarda el vehiculo


                    if (FotoCambiada)
                    {
                        rutaRelativa = _repositorioFotografia.Guardar(FotoVehiculo.Image);
                        v.PathFoto = rutaRelativa;
                        creado = await _repositorioVehiculo.Crear(v);
                    }
                    else
                    {
                        MessageBox.Show("El vehiculo debe tener una fotografia");
                    }




                }
                catch (MatriculaYaExisteException matriculaYaExisteException)
                {
                    Console.WriteLine(matriculaYaExisteException.Message);
                    MessageBox.Show("La matrícula ya es usada por otro vehículo");
                    //si falla el insert se borra la imagen
                    _repositorioFotografia.Borrar(rutaRelativa);
                }
                catch (Exception)
                {
                    //si falla el insert se borra la imagen
                    _repositorioFotografia.Borrar(rutaRelativa);
                    Console.WriteLine("Ocurrió un error");
                }
            }
            return creado;
        }

        private async Task<bool> Modificar()
        {
            bool modificado = false;

            Vehiculo v = new Vehiculo()
            {
                Matricula = textMatricula.Text.ToUpper(),
                Marca = new Marca()
                {
                    Id = 0
                },
                Modelo = textModelo.Text,
                Capacidad = -1,
                Anio = textAño.Text,
                CostoDia = -1,
                Caracteristicas = vehiculo.Caracteristicas,
                
            };
            try
            {

                int capacidad = Int16.Parse(textCapacidad.Text);
                v.Capacidad = capacidad;
            }
            catch (Exception ex)
            {
                MessageBox.Show("La capacidad no es correcta.");
            }
            try
            {
                float costoDia = float.Parse(textCosto.Text);
                v.CostoDia = costoDia;
            }
            catch (Exception ex)
            {
                MessageBox.Show("El costo no es correcto.");
            }
            try
            {
                Marca marca = new Marca()
                {
                    Id = (int)comboBoxMarca.SelectedValue
                };
                v.Marca = marca;
            }
            catch (Exception ex)
            {
                MessageBox.Show("La marca no es correcta.");
            }

            ValidacionVehiculo validator = new ValidacionVehiculo();
            ValidationResult results = validator.Validate(v);
            if (!results.IsValid)
            {
                string mensaje = results.Errors[0].ErrorMessage;
                MessageBox.Show(mensaje);
            }
            else
            {
                string rutaRelativa = "";


                try
                {
                    //Guarda la imagen en la carpeta y retorna la ruta relativa de la imagen
                    //para guardarla en la base de datos
                    //Lanza una excepcion, en tal caso no se guarda el vehiculo


                    if (FotoCambiada)
                        rutaRelativa = _repositorioFotografia.Guardar(FotoVehiculo.Image);
                    else
                        rutaRelativa = vehiculo.PathFoto;

                    v.PathFoto = rutaRelativa;
                    modificado = await _repositorioVehiculo.Modificar(v);

                   
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error." + ex);
                    //si falla la modificacion se borra la nueva imagen 
                    if(FotoCambiada)
                    _repositorioFotografia.Borrar(rutaRelativa);
                    Console.WriteLine("Ocurrió un error");
                }
                
                
            }
            return modificado;


        }

        private async Task<bool> Eliminar()
        {
            bool borrado = false;
            String matricula = textMatricula.Text;
            try
            {
                if (!(await _repositorioVehiculo.TieneAlquileresAsignados(matricula)))
                {
                    borrado = await _repositorioVehiculo.Borrar(matricula);
                }
                else
                {
                    MessageBox.Show("No se puede borrar este vehículo" +
                        " porque tiene alquileres asignados");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return borrado;
        }

        private async void btnCaracteristicas_Click(object sender, EventArgs e)
        {

            FormCaracteristicas fc = Program.container.GetInstance<FormCaracteristicas>();
            await fc.ListarCaracteristicasVehiculo(vehiculo);
            fc.Show();



        }

        private void FotoVehiculo_Click(object sender, EventArgs e)
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
                FotoVehiculo.Image = (Image)foto;
                FotoCambiada = true;
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
    }
}
