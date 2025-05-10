using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;


namespace app.logic
{
    internal class logicas
    {
        public string registro(string user_name, string prePasswrd1, string prePasswrd2)
        {
            string resultadoError = "";
            string password = "", IDuser = "";
            string IDdata = "032156";

            if (prePasswrd1 != prePasswrd2)
            {

                return "Error, Las contraseñas no son iguales.";
            }

            if ((resultadoError = filtro(user_name)) != "")
            {
                return resultadoError;
            }

            Random rand = new Random();

            do
            {
                for (int i = 0; i < 6; i++)
                {
                    IDuser = IDuser + rand.Next(0, 10).ToString();
                }

                Console.WriteLine($"Se creó el ID {IDuser} para el nuevo usuario {user_name}.");

                //Verificar IDuser hay uno igual en db y lo guarda en IDdata

            } while (IDuser != IDdata);


            password = prePasswrd1;




            /*
            variables a poner registro de TXT:
                user_name
                password
                ID_user
            */


            return resultadoError;
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

        public string inviter(string user_name)
        {
            string resultadoError = "";

            resultadoError = filtro(user_name);

            return resultadoError;
        }

        public string filtro(string user_name)
        {
            string resultadoError = "";

            string[] wordsbad = { "puto", "gay", "puteador", "Perro", "perra", "imbecil", "pija", "puto", 
                "admin", "owner" };

            foreach (string word in wordsbad)
            {
                if (user_name.ToLower() == word.ToLower())
                {

                    return "Error, el nombre de usuario ingresado no es válido";

                }
            }

            return resultadoError;

  
        }
    }
}
