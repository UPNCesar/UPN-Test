using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app.fomularios
{
    public partial class menu_principal : Form
    {
        private string app_nam;
        private string app_versio;
        //private string user_name;


        public menu_principal(string app_name, string app_version, bool opciones, string user_name)
        {
            InitializeComponent();

            this.app_nam = app_name;
            this.app_versio = app_version;

            hello.Text = $"Hola {user_name} ¿que quieres hacer hoy?";

            switch (opciones){

                case true:

                    Encuestas_inst.Enabled = false; //plan vip
                    register2.Visible = false;
                    login2.Visible = false;

                    TXTann.Text = $"{user_name} Adquiere nuestro plan plus para obetenr beneficios";

                    break;
                case false:

                    crear_inst.Visible = false;
                    unirse_inst.Visible=false;

                    Tareas_inst.Enabled = false;
                    asistencia_inst.Enabled = false;
                    personal_inst.Enabled = false;
                    inv_inst.Enabled = false;
                    Encuestas_inst.Enabled = false; //plan vip
                    Anuncios_inst.Enabled = false;
                    sugerenci_inst.Enabled = false; 
                    reclamos_inst.Enabled = false;

                    TXTann.Text = $"{user_name} inicia sesion para desbloquear más opciones";

                    break;
            }
        }

        private void register2_Click(object sender, EventArgs e)
        {
            short boton = 1;

            access acceso = new access(boton, app_nam, app_versio);

            acceso.ShowDialog();
        }

        private void login2_Click(object sender, EventArgs e)
        {
            short boton = 0;

            access acceso = new access(boton, app_nam, app_versio);

            acceso.ShowDialog();
        }

        private void CloseAll_Click(object sender, EventArgs e)
        {
            this.Close();            
        }
    }
}
