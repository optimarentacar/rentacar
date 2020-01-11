using Rentacar.Interfaz;
using Rentacar.Interfaz.Clientes;
using Rentacar.Interfaz.Principal;
using Rentacar.Interfaz.Vehiculos;
using Rentacar.Repositorio.Interfaces;
using Rentacar.Repositorio.Repositorios;
using Rentacar.Test;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rentacar
{
    static class Program
    {
        public static Container container;
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            RegistrarDependencias();
            Application.Run(container.GetInstance<FormPrincipal>());
        }

        private static void RegistrarDependencias()
        {
            container = new Container();

            container.Register<FormPrincipal>();
            container.Register<FormGestionCliente>();
            container.Register<FormGestionVehiculos>();
            container.Register<FormTest>();



            //Repositorios
            container.Register<IRepositorioVehiculo, RepositorioVehiculo>(Lifestyle.Transient);
            container.Register<IRepositorioAlquiler, RepositorioAlquiler>(Lifestyle.Transient);
            container.Register<IRepositorioCaracteristica, RepositorioCaracteristica>(Lifestyle.Transient);
            container.Register<IRepositorioCliente, RepositorioCliente>(Lifestyle.Transient);
            container.Register<IRepositorioAccesorio, RepositorioAccesorio>(Lifestyle.Transient);
            container.Register<IRepositorioMarca, RepositorioMarca>(Lifestyle.Transient);
            container.Register<IRepositorioFotografia, RepositorioFotografia>(Lifestyle.Transient);
        }
    }
}
