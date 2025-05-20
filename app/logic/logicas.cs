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

            

            if (prePasswrd1 != prePasswrd2)
            {

                return "Error, Las contraseñas no son iguales.";
            }

            
       

            string[] wordsbad = { "puto", "gay", "puteador", "Perro", "perra", "imbecil", "pija", "puto", "admin", "owner"};

            foreach (string word in wordsbad)
            {
                if (user_name.ToLower() == word.ToLower())
                {

                    return "Error, el nombre de usuario ingresado no es válido";

                }
            }


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

        public string Logs_txt(string user_name, int tipo, string message, short nivel)
        {
            
            
            switch(tipo)
            {
                case 1: //delete admin databas-----------------------------------------------------------------
                    TextWriter AdmReset = new StreamWriter(@"D:\UPN-Test\app\data\AdmActions.txt");

                    AdmReset.WriteLine($"[ALERT:] (Acción irreversible) {user_name} Reseteó la base de datos de registro de acciones de administradores");

                    AdmReset.Close();

                    return $"[ALERT:] (Acción irreversible) {user_name} Reseteó la base de datos de registro de acciones de administradores";

                case 2://delete user_ID database --------------------------------------------------------------------
                    TextWriter UserReset = new StreamWriter(@"D:\UPN-Test\app\data\userData.txt");

                    UserReset.WriteLine($"[ALERT:] (Acción irreversible) {user_name} Reseteó la base de datos de registro de usuarios");

                    UserReset.Close();

                    return $"[ALERT:] (Acción irreversible) {user_name} Reseteó la base de datos de registro de usuarios";

                case 3:  //delete inst. database --------------------------------------------------------------------
                    TextWriter InstReset = new StreamWriter(@"D:\UPN-Test\app\data\InstList.txt");

                    InstReset.WriteLine($"[ALERT:] (Acción irreversible) {user_name} Reseteó la base de datos de registro de instituciones");

                    InstReset.Close();

                    return $"[ALERT:] (Acción irreversible) {user_name} Reseteó la base de datos de registro de instituciones";

                case 6:  //delete reclamos. database --------------------------------------------------------------------
                    TextWriter reporReset = new StreamWriter(@"D:\UPN-Test\app\data\InstList.txt");

                    reporReset.WriteLine($"[ALERT:] (Acción irreversible) {user_name} Reseteó la base de datos de reportes/reclamos");

                    reporReset.Close();

                    return $"[ALERT:] (Acción irreversible) {user_name} Reseteó la base de datos de reportes/reclamos";




                case 4:  //escribir en database administradores info, warn y errores--------------------------------------------------------------------
                    TextWriter admwrite = File.AppendText(@"D:\UPN-Test\app\data\AdmActions.txt");

                    switch (nivel)
                    {
                        case 1: 
                            admwrite.WriteLine($"[INFO:] {user_name} {message}");

                            admwrite.Close();

                            return $"[INFO:] {user_name} {message}";

                        case 2:
                            admwrite.WriteLine($"[WARN:] {user_name} {message}");

                            admwrite.Close();

                            return $"[WARN:] {user_name} {message}";
                        case 3:
                            admwrite.WriteLine($"[ERROR:] {user_name} {message}");

                            admwrite.Close();

                            return $"[ERROR:] {user_name} {message}";
                    }
                    return $"[ERROR CRiTICO:] {user_name} No existe el tipo de alerta";


                case 5:  //Escribir en database usuarios_ID (registro, eliminar cuenta y cambiar nombre --------------------------------------------------------------------
                    TextWriter userWrite= File.AppendText(@"D:\UPN-Test\app\data\userData.txt");

                    userWrite.WriteLine($"");

                    userWrite.Close();

                    return $"[INFO:] {user_name} {message}";




                
            }

            return "";
        }
    }
}
