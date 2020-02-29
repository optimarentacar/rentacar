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

namespace Rentacar.Interfaz.Accesorios
{
    public partial class FormAlquilerAccesorios : Form
    {

        private readonly IRepositorioAccesorio _repositorioAccesorio;
        private readonly IRepositorioAlquiler _repositorioAlquiler;
        private List<Accesorio> Accesorios;
        private List<Accesorio> AccesoriosAlquiler;
        private int IdAlquiler;
        public bool Cerrado { get; set; }

        public FormAlquilerAccesorios(IRepositorioAccesorio repositorioAccesorio,
            IRepositorioAlquiler repositorioAlquiler)
        {
            _repositorioAccesorio = repositorioAccesorio;
            _repositorioAlquiler = repositorioAlquiler;
            InitializeComponent();
           
        }

        public async Task ListarAccesoriosAlquiler(int idAlquiler)
        {
            IdAlquiler = idAlquiler;
            try
            {
                AccesoriosAlquiler = await _repositorioAccesorio
                    .ListarPorAlquiler(idAlquiler);
               

                AccesoriosAlquiler.ForEach(a =>
                {
                    
                    dgvAccesoriosAlquiler.Rows.Add(a.Id, a.Nombre, a.Costo);
                });
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocurrión un error"+ex);
            }
        }

        private void btnDerecha_Click(object sender, EventArgs e)
        {
            int id = (int)dgvAccesorios.SelectedRows[0].Cells[0].Value;

            bool existe = false;

            for (int i = 0; i < dgvAccesoriosAlquiler.Rows.Count && !existe; i++)
            {
                if ((int)dgvAccesoriosAlquiler.Rows[i].Cells[0].Value == id)
                {
                    existe = true;
                }
            }

            if (!existe)
            {
                Accesorio a = Accesorios.FirstOrDefault(acc => acc.Id == id);
                AccesoriosAlquiler.Add(a);
                dgvAccesoriosAlquiler.Rows.Add(a.Id, a.Nombre, a.Costo);

            }
        }

        private void btnIzquierda_Click(object sender, EventArgs e)
        {
            if (dgvAccesoriosAlquiler.Rows.Count > 0)
            {
                int id = (int)dgvAccesoriosAlquiler.SelectedRows[0].Cells[0].Value;
                AccesoriosAlquiler.RemoveAll(acc => acc.Id == id);
                dgvAccesoriosAlquiler.Rows.RemoveAt(dgvAccesoriosAlquiler.SelectedRows[0].Index);
            }
        }

        private async void FormAlquilerAccesorios_Load(object sender, EventArgs e)
        {
            Cerrado = false;
            try
            {
                Accesorios = await _repositorioAccesorio.Listar();

                
                    Accesorios.ForEach(a =>
                    {                
                        dgvAccesorios.Rows.Add(a.Id, a.Nombre, a.Costo);
                    });
                
             
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrión un error");
            }
        }

        private void dgvAccesorios_SelectionChanged(object sender, EventArgs e)
        {

        }

        private async void FormAlquilerAccesorios_FormClosed(object sender, FormClosedEventArgs e)
        {
            List<int> ids = AccesoriosAlquiler.Select(acc => acc.Id).ToList();

            try
            {
                bool asignados = await _repositorioAlquiler.AsignarAccesorios(IdAlquiler, ids);
                Cerrado = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocurrió un error.");
            }

            
        }

       
    }
}
