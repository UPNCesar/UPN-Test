using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app.fomularios
{
    public partial class menu_principal : Form
    {
        private string app_nam;
        private string app_versio;
        private string user_nam;


        public menu_principal(string app_name, string app_version, short opciones, string user_name)
        {
            InitializeComponent();

            this.app_nam = app_name;
            this.app_versio = app_version;
            this.user_nam = user_name;

            switch (opciones)
            {

                case 1:

                    //-------------------------------------------------------------------------------------
                    //-------------------------ACCEDIO A SU CUENTA USUARIO -----------
                    //-------------------------------------------------------------------------------------
                    //-------------------------------------------------------------------------------------

                    hello.Text = $"Hola {user_nam} Debes estar en una institución para desbloquear mas funciones";
                    register2.Visible = false;
                    login2.Visible = false;
                    CloseAll.Text = "Cerrar sesión";
                    TXTann.Text = $"{user_nam} Adquiere nuestro plan plus para obetenr beneficios";

                    crear_inst.Visible = false;
                    unirse_inst.Visible=false;
                    register2.Visible=false;
                    login2.Visible=false;

                    break;
                case 2:

                    //-------------------------------------------------------------------------------------
                    //----------------------------------------- MODO INVITADO --------------------------------------------
                    //-------------------------------------------------------------------------------------

                    hello.Text = $"Hola {user_nam} Debes iniciar sesión para desbloquear más funciones";
                    crear_inst.Visible = false;
                    unirse_inst.Visible = false;

                    CloseAll.Visible = false;
                    /*
                    
                    asistencia_inst.Enabled = false;
                    personal_inst.Enabled = false;
                    inv_inst.Enabled = false;
                    Encuestas_inst.Enabled = false; //plan vip
                    Anuncios_inst.Enabled = false;
                    sugerenci_inst.Enabled = false; 
                    reclamos_inst.Enabled = false;

                    */
                    TXTann.Text = $"{user_nam} inicia sesion para desbloquear más opciones";
                    break;
                case 3:
                    //-------------------------------------------------------------------------------------
                    //-------------------------ACCEDIO A SU CUENTA DE INST -----------
                    //-------------------------------------------------------------------------------------
                    //-------------------------------------------------------------------------------------

                    hello.Text = $"Hola {user_nam} ¿que quieres hacer hoy?";
                    break;
            }
        }

        private void register2_Click(object sender, EventArgs e)
        {

            access acceso = new access(1, app_nam, app_versio);
            this.Hide();
            acceso.ShowDialog();
            this.Close();
        }

        private void login2_Click(object sender, EventArgs e)
        {
            access acceso = new access(0, app_nam, app_versio);
            this.Hide();
            acceso.ShowDialog();

            this.Close();
        }

        private void CloseAll_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void ver_reunion_Click(object sender, EventArgs e)
        {

        }

        private void crear_inst_Click(object sender, EventArgs e)
        {
            access accesint = new access(3, app_nam, app_versio);
            this.Hide();
            accesint.ShowDialog();

            this.Close();
            

        }

        public void cerrarForm() 
        {
            this.Close();
            
        }

    }
}
