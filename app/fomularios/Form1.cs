using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app
{
    public partial class Form1 : Form
    {
        private string app_nam;
        private string app_versio;

        //defininicion de var como instancia

        public Form1(string app_name, string app_version)
        {
            
            InitializeComponent();

            this.Text = $"{app_name} {app_version}";

            this.app_nam = app_name ;
            this.app_versio = app_version ;

            

        }


        private void login_Click(object sender, EventArgs e)
        {
            short boton = 0;

            access acceso = new access(boton, app_nam, app_versio);

            
            acceso.ShowDialog();

            

            

        }

        private void register_Click(object sender, EventArgs e)
        {

            short boton = 1;

            access acceso = new access(boton, app_nam, app_versio);
            
            acceso.ShowDialog();
            

        }

        

        private void invitado_Click(object sender, EventArgs e)
        {
            short boton = 2;

            access acceso = new access(boton, app_nam,app_versio);

            

            acceso.ShowDialog();

            
        }
    }
}
