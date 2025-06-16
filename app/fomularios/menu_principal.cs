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
        private string inst_nam;

        public menu_principal(string app_name, string app_version, short opciones, string user_name, string inst_name)
        {
            InitializeComponent();

            this.app_nam = app_name;
            this.app_versio = app_version;
            this.user_nam = user_name;
            this.inst_nam = inst_name;

            switch (opciones)
            {

                case 1:

                    //-------------------------------------------------------------------------------------
                    //-------------------------ACCEDIO A SU CUENTA USUARIO --------------------------------
                    //-------------------------------------------------------------------------------------
                    //-------------------------------------------------------------------------------------

                    hello.Text = $"Hola {user_nam} Debes estar en una institución para desbloquear mas funciones";
                    this.Text = $"{app_name} {app_version}";
                    register2.Visible = false;
                    login2.Visible = false;
                    crear_inst.Visible = true;
                    unirse_inst.Visible = true;
                    asistencia_mi_hijo.Enabled = false;
                    Asistencia_alum.Enabled = false;
                    Asistencias_generales.Enabled = false;
                    Btncrearreuniones.Enabled = false;
                    BtnRealizarSolicitud.Enabled = false;
                    BtnRegAlumandpadres.Enabled = false;
                    Btnverreunion.Enabled = false;
                    BtnVerSolicitudes.Enabled = false;
                    BtnLeaveinst.Visible = false;
                    Gbxpadres.Visible = true;
                    GbxProfesores.Visible = true;
                    break;
                case 3:
                    //-------------------------------------------------------------------------------------
                    //-------------------------ACCEDIO A SU CUENTA DE DIRECTOR -----------
                    //-------------------------------------------------------------------------------------
                    //-------------------------------------------------------------------------------------

                    hello.Text = $"Hola Sñr. Director {user_nam} ¿que desea hacer hoy?";
                    this.Text = $"{app_name} {app_version} | I.E. {inst_nam} ";
                    crear_inst.Visible = false;
                    unirse_inst.Visible = false;
                    register2.Visible = false;
                    login2.Visible = false;
                    asistencia_mi_hijo.Visible = false;
                    Asistencia_alum.Visible = false;
                    Asistencias_generales.Visible = true; 
                    Btncrearreuniones.Visible = true;
                    BtnRealizarSolicitud.Visible = false;
                    BtnRegAlumandpadres.Visible = true;
                    Btnverreunion.Visible = true;
                    BtnVerSolicitudes.Visible = true;
                    BtnLeaveinst.Visible = true;
                    Gbxpadres.Visible = false;
                    GbxProfesores.Visible = false;
                    break;
            }
        }

        private void register2_Click(object sender, EventArgs e)
        {

            access acceso = new access(1, app_nam, app_versio, user_nam);
            this.Hide();
            acceso.ShowDialog();
            this.Close();
        }

        private void login2_Click(object sender, EventArgs e)
        {
            access acceso = new access(0, app_nam, app_versio, user_nam);
            this.Hide();
            acceso.ShowDialog();

            this.Close();
        }

        private void CloseAll_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void crear_inst_Click(object sender, EventArgs e)
        {
            access accesint = new access(3, app_nam, app_versio, user_nam);
            this.Hide();
            accesint.ShowDialog();

            this.Close();
            

        }

        private void unirse_inst_Click(object sender, EventArgs e)
        {
            access accesint = new access(4, app_nam, app_versio, user_nam);
            this.Hide();
            accesint.ShowDialog();

            this.Close();
        }
        private void Asistencias_generales_Click(object sender, EventArgs e)
        {





















        }

        private void asistencia_mi_hijo_Click(object sender, EventArgs e)
        {




















        }

        private void Asistencia_alum_Click(object sender, EventArgs e)
        {




















        }

        private void BtnLeaveinst_Click_1(object sender, EventArgs e)
        {
            hello.Text = $"Hola {user_nam} Debes estar en una institución para desbloquear mas funciones";
            this.Text = $"{app_nam} {app_versio}";
            asistencia_mi_hijo.Visible = true;
            Asistencia_alum.Visible = true;
            register2.Visible = false;
            login2.Visible = false;
            crear_inst.Visible = true;
            unirse_inst.Visible = true;
            asistencia_mi_hijo.Enabled = false;
            Asistencia_alum.Enabled = false;
            Asistencias_generales.Enabled = false;
            Btncrearreuniones.Enabled = false;
            BtnRealizarSolicitud.Enabled = false;
            BtnRegAlumandpadres.Enabled = false;
            Btnverreunion.Enabled = false;
            BtnVerSolicitudes.Enabled = false;
            Gbxpadres.Visible = true;
            GbxProfesores.Visible = true;
        }
    }
}
