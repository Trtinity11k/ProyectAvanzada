using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestiónCRUDNorthwind
{
    internal static class Program
    {
        internal static IConfiguration Configuration = null;
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            

             Configuration = new ConfigurationBuilder()
             .AddJsonFile("appsettings.json")
             .Build();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MenuInicio());



        }
    }
}
