using Aplicacion.IoC;
using StructureMap;
using System;
using System.Windows.Forms;

namespace CommerceApp
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            // Configuracion del Inyector (StructureMap)
            new StructureMapContainer().Configure();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //

            var formLogin = ObjectFactory.GetInstance<Login>();
            formLogin.ShowDialog();

            if (formLogin.PuedeIngresar)
            {
                Application.Run(ObjectFactory.GetInstance<Principal>());
            }
            else
            {
                Application.Exit();
            }
        }
    }
}