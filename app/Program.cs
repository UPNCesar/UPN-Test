using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app
{
    internal static class Program
    {
        
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        


        
        static void Main()
        {
            string app_name = "app name";
            string app_version = "v1.0.0";
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new Form1(app_name, app_version));

         //instrucciones de como emplear git hub
         //hola
        }
    }
}
