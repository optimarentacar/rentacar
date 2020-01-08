using Rentacar.Interfaz;
using Rentacar.Repositorio.Interfaces;
using Rentacar.Repositorio.Repositorios;
using Rentacar.Servicios.Interfaces;
using Rentacar.Servicios.Servicios;
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
        private static Container container;
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            RegistrarDependencias();
            Application.Run(container.GetInstance<Form1>());
        }

        private static void RegistrarDependencias()
        {
            container = new Container();

            container.Register<Form1>();

            container.Register<IServicioVehiculo, ServicioVehiculo>(Lifestyle.Transient);

            container.Register<IRepositorioVehiculo, RepositorioVehiculo>(Lifestyle.Transient);
        }
    }
}
