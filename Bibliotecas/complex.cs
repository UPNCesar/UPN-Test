using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bs
{
    public class libraryOne
    {

        public static string AdminResetdb(string user_name)
        {
            TextWriter AdmReset = new StreamWriter(@"C:\UPN-Test\app\data\AdmActions.txt");
            // 

            AdmReset.WriteLine($"[ALERT:] (Acción irreversible) {user_name} Reseteó la base de datos de registro de acciones de administradores");

            AdmReset.Close();

            return $"[ALERT:] (Acción irreversible) {user_name} Reseteó la base de datos de registro de acciones de administradores";
        }


        public static string UserResetdb(string user_name)
        {
            TextWriter UserReset = new StreamWriter(@"C:\UPN-Test\app\data\userData.txt");

            UserReset.WriteLine($"[ALERT:] (Acción irreversible) {user_name} Reseteó la base de datos de registro de usuarios");

            UserReset.Close();

            return $"[ALERT:] (Acción irreversible) {user_name} Reseteó la base de datos de registro de usuarios";
        }


        public static string IntitucionResetdb(string user_name)
        {
            TextWriter InstReset = new StreamWriter(@"C:\UPN-Test\app\data\InstList.txt");

            InstReset.WriteLine($"[ALERT:] (Acción irreversible) {user_name} Reseteó la base de datos de registro de instituciones");

            InstReset.Close();

            return $"[ALERT:] (Acción irreversible) {user_name} Reseteó la base de datos de registro de instituciones";
        }



        public static string ReportesResetdb(string user_name)
        {
            TextWriter reporReset = new StreamWriter(@"D:\UPN-Test\app\data\InstList.txt");

            reporReset.WriteLine($"[ALERT:] (Acción irreversible) {user_name} Reseteó la base de datos de reportes/reclamos");

            reporReset.Close();

            return $"[ALERT:] (Acción irreversible) {user_name} Reseteó la base de datos de reportes/reclamos";
        }



        public static string ReportsToBugs(string user_name, string message)
        {
            TextWriter reportes = File.AppendText(@"C:\UPN-Test\app\data\AdmActions.txt");

            reportes.WriteLine($"[Reporte de {user_name}:] {message}");

            reportes.Close();

            return $"Gracias por realizar un reporte. ¡Tus reportes nos ayudan a mejorar cada día!";
        }



        public static string SearchUsername(string user_name)
        {
            string[] user_basedata = File.ReadAllLines(@"C:\UPN-Test\app\data\userData.txt");
            //D:\UPN-Test\app\data\userData.txt

            for (int i = 0; i < user_basedata.Length; i++)
            {
                string[] dato = user_basedata[i].Split(',');

                if (dato[0] == user_name)
                {

                    return $"Existe";
                }

                
            }

            return "";
        }


        public static bool SearchInst(string inst_name)
        {
            string[] inst_basedata = File.ReadAllLines(@"C:\UPN-Test\app\data\InstList.txt");

            for (int i = 0; i < inst_basedata.Length; i++)
            {
                string[] dato = inst_basedata[i].Split(',');

                if (dato[0] == inst_name)
                {
                    return false;
                }
            }
            return true;
        }

        public static string GenerateCodigoInst(string user_name, string inst_name, string CodigoModularstring)
        {
            Random rand = new Random();
            string variable = Convert.ToString(rand.Next(10000, 100000));

            TextWriter registeruser = File.AppendText(@"C:\UPN-Test\app\data\InstList.txt");

            registeruser.WriteLine($"{user_name},{inst_name},{CodigoModularstring},{variable}");

            registeruser.Close();

            return variable;
        }
        public static string SearchInstAndUSer(string user_name, string CodigoModularstring, string digit)
        {
            string[] inst_basedata = File.ReadAllLines(@"C:\UPN-Test\app\data\InstList.txt");

            for (int i = 0; i < inst_basedata.Length; i++)
            {
                string[] dato = inst_basedata[i].Split(',');

                if (dato[0] == user_name)
                {
                    if (dato[2] == CodigoModularstring)
                    {
                        if (dato[3] == digit)
                        {
                            return dato[1];
                        }
                    }
                    
                }
            }
            return "";
        }

        public static string SearchPassword(string password)
        {
            string[] user_basedata = File.ReadAllLines(@"D:\UPN-Test\app\data\userData.txt");
            //D:\UPN-Test\app\data\userData.txt

            for (int i = 0; i < user_basedata.Length; i++)
            {
                string[] dato = user_basedata[i].Split(',');

                if (dato[0] == password)
                {

                    return $"Existe";
                }


            }

            return "";
        }

        public static bool SearchPasswordAndUsername(string password, string user_name)
        {
            string[] user_basedata = File.ReadAllLines(@"C:\UPN-Test\app\data\userData.txt");
            //D:\UPN-Test\app\data\userData.txt

            for (int i = 0; i < user_basedata.Length; i++)
            {
                string[] dato = user_basedata[i].Split(',');

                if (dato[0] == user_name)
                {
                    if (dato[1] == password)
                    {

                        return true;
                    }
                }


            }

            return false;
        }




        public static string WriteLogAdmin(string user_name, short nivel, string message)
        {
            TextWriter admwrite = File.AppendText(@"C:\UPN-Test\app\data\AdmActions.txt");
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
        }



        public static bool VerifyWorldBlockList(string palabra)
        {



            string[] wordsbad = { "gay", "puteador", "Perro", "perra", "imbecil", "pija",
                "admin", "owner", "maldicion", "ofensa", "prohibido", "insulto", "spam",
                "tonto", "idiota", "xxx", "asqueroso", "estúpido",
                "imbécil", "maldito", "inútil", "tarado", "capullo",
                "puta", "puto", "mierda", "cabrón", "coño",
                "perra", "bastardo", "zorra", "gilipollas", "joder",
                "pedo", "porno", "nazi", "racista", "homofóbico",
                "intolerante", "violación", "asesinato", "suicidio", "terrorismo",
                "droga", "cocaína", "heroína", "alcohol", "sexo",
                "desnudo", "orgía", "masturbar", "violento", "matón",
                "acoso", "bullying", "esclavo", "nazismo", "satanás",
                "infierno", "infernal", "diablo", "lucifer", "satanico" };

            foreach (string word in wordsbad)
            {
                if (palabra.ToLower() == word.ToLower())
                {

                    return false;

                }
            }

            return true;
        }
    }
}
