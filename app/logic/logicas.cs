using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
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



            if (Bs.libraryOne.VerifyWorldBlockList(user_name) != "")
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

        public string login(string user_name, string prePasswrd1)
        {
     

            if (user_name.ToLower() == "admin")
            {
                switch (prePasswrd1)
                {
                    case "AdminCesar2014.":

                        return $"Cesar";
                    case "AdminBlanco2025.":
                        return $"Blanco";
                    case "AdminLuis2034.":
                        return $"Luis";
                }
                
            }
            
            if(Bs.libraryOne.SearchPasswordAndUsername(prePasswrd1, user_name) != "")
            { 
                return "usuario"; 
            }
            else return "El usuario o contraseña ingresado son incorrectas";

        }





        
    }
}
