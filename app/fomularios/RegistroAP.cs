using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app.fomularios
{   

    public partial class RegistroAP : Form
    {
        private string app_nam;
        private string app_versio;
        private string user_nam;
        private string inst_nam;
        public RegistroAP(string app_name, string app_version, string user_name, string inst_name)
        {
            InitializeComponent();
            this.Text = $"{app_name} {app_version} | I.E. {inst_name}";
            this.Lbinstrucc.Text = "";
            this.app_nam = app_name ;
            this.app_versio = app_version ;
            this.user_nam = user_name ;
            this.inst_nam = inst_name ;

            
        }
        private void RbEstudiante_CheckedChanged(object sender, EventArgs e)
        {
            GbProfes.Visible = false;
            GbEstudiante.Visible = true;
            Gbpadres.Visible = false;
            LBalums.Visible = true;
            LBpadres.Visible = false;
            LBprofesores.Visible = false;
        }

        private void RbPadres_CheckedChanged(object sender, EventArgs e)
        {
            GbProfes.Visible = false;
            GbEstudiante.Visible = false;
            Gbpadres.Visible = true;
            LBalums.Visible = false;
            LBpadres.Visible = true;
            LBprofesores.Visible = false;
        }

        private void RbProfesor_CheckedChanged(object sender, EventArgs e)
        {
            GbProfes.Visible = true;
            GbEstudiante.Visible = false;
            Gbpadres.Visible = false;
            LBalums.Visible = false;
            LBpadres.Visible = false;
            LBprofesores.Visible = true;
        }

        private string codigoMod()
        {
            string[] db = File.ReadAllLines(@"C:\UPN-Test\app\data\InstList.txt");
            for (int i = 0; i < db.Length; i++)
            {
                string[] codModular = db[i].Split(',');
                if (codModular[1] == inst_nam)
                {
                    return codModular[2];
                }
            }
            return "";
        }
        //el 100 a 999 padres, 1000 hasta 9999 profesores, 10000 hasta 100000 directores
        private void Btnaddest_Click(object sender, EventArgs e)
        {
            DateRegistre dregistre = new DateRegistre(inst_nam, codigoMod(), 0);
        }

        private void BtnAddProfe_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            DateRegistre dregistre = new DateRegistre(inst_nam, codigoMod(), random.Next(1000,9999));
        }

        private void BtnAddPadre_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            DateRegistre dregistre = new DateRegistre(inst_nam, codigoMod(), random.Next(100, 999));
        }
    }
}
