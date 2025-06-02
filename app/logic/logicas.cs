using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using app.fomularios;
using Microsoft.Win32;


namespace app.logic
{
    internal class logicas
    {
        public string registro(string user_name, string prePasswrd1, string prePasswrd2)
        {



            if (!Bs.libraryOne.VerifyWorldBlockList(user_name))
            {
                return "Error, El texto contiene términos restringidos. Por favor, utiliza un lenguaje adecuado.";
            }

            if (prePasswrd1 != prePasswrd2)
            {
                return "Error, Las contraseñas no son iguales.";
            }


            
            if (Bs.libraryOne.SearchUsername(user_name) != "") return $"Error, el nombre {user_name} ya está en uso";
   
            
            

            TextWriter registeruser = File.AppendText(@"D:\UPN-Test\app\data\userData.txt");

            registeruser.WriteLine($"{user_name},{prePasswrd1}");

            registeruser.Close();


            return "";
        }

        public string registroInst(string user_name, string inst_name, string CodigoModularstring)
        {


         

            if (!Bs.libraryOne.VerifyWorldBlockList(inst_name))
            {
                return "Error, El nombre contiene términos restringidos. Por favor, utiliza un lenguaje adecuado.";
            }

            if (!Bs.libraryOne.SearchInst(inst_name)) return $"Error, el nombre {inst_name} ya está en uso";

            int CodigoModular = 0;

            try
            {
                CodigoModular = Convert.ToInt32(CodigoModularstring);
            }
            catch
            {
                return "Error, El código modular ingresado no son números";
            }


            if (CodigoModular < 999999 || CodigoModular > 1000000000)
            {
                return "Error, El código modular debe comprender de 7 a 9 dígitos";
            }

            return ""; 

        }

        public string login(string user_name, string prePasswrd1)
        {

            if(Bs.libraryOne.SearchPasswordAndUsername(prePasswrd1, user_name))
            { 
                return "usuario"; 
            }
            else return "El usuario o contraseña ingresados son incorrectas";

        }


     

        //hola como estas



    }
}
