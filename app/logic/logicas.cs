using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace app.logic
{
    internal class logicas
    {
        public string registro(string user_name, string prePasswrd1, string prePasswrd2)
        {
            string resultado = "";
            
            
            if (prePasswrd1 != prePasswrd2)
            {

                resultado = "Error, Las contraseñas no son iguales.";

                return resultado;
            }

            resultado = filtro(user_name);

            //poner registro de TXT aqui

            return resultado;
        }

        public string login(string user_name, string prePasswrd1)
        {
            string resultado = "";

            //poner lectura de datos aqui  para el  login

            return resultado;
        }

        public string inviter(string user_name)
        {
            string resultado = "";

            resultado = filtro(user_name);

            return resultado;
        }

        public string filtro(string user_name)
        {
            string resultado = "";

            string[] palabras = { "puto", "gay", "puteador", "Perro", "perra", "imbecil", "pija", "puto" };

            for (int i = 0; i < 8; i++)
            {
                if (user_name.ToLower() == palabras[i].ToLower())
                {

                    resultado = "Error, el nombre de usuario ingresado no es válido";

                    return resultado;
                }
            }

            return resultado;
        }
    }
}
