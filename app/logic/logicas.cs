using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;


namespace app.logic
{
    internal class logicas
    {
        public string registro(string user_name, string prePasswrd1, string prePasswrd2)
        {



            if (Bs.libraryOne.VerifyWorldBlockList(user_name) != "") return "Error, El texto contiene términos restringidos. Por favor, utiliza un lenguaje adecuado.";

            if (prePasswrd1 != prePasswrd2) return "Error, Las contraseñas no son iguales.";
            


            string[] user_basedata = File.ReadAllLines(@"D:\UPN-Test\app\data\userData.txt");
            //D:\UPN-Test\app\data\userData.txt

            for (int i = 0; i < user_basedata.Length; i++)
            {
                string[] dato = user_basedata[i].Split(',');

                if (dato[0] == user_name)
                {

                    return $"Error, el nombre {user_name} ya está en uso";
                }
                

            }



            


            /*
            variables a poner registro de TXT:
                user_name
                password
                ID_user
            */


            return "";
        }

        public string login(string user_name, string prePasswrd1)
        {
            string resultadoError = "";

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
            
            //poner lectura de datos aqui  para el  login si se detecta capturaos en variables los datos

            

            return resultadoError;
        }





        
    }
}
