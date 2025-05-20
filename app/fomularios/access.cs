using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using app.fomularios;
using app.logic;

namespace app
{
    public partial class access : Form
    {

        private string app_name; 
        private string app_version;
        
        public access(short boton, string app_name, string app_version)
        {
            InitializeComponent();
            this.app_name = app_name;
            this.app_version = app_version;

            this.Text = $"{app_name} {app_version}";

            switch (boton)
            {
                case 0:
                    password2.Visible = false;
                    invitado.Visible = false;
                    label3.Visible = false;
                    registrarse.Visible = false;
                    label2.Text = "Ingrese su contraseña:";
                    Label1.Text = "Ingrese su nombre de usuario:";

                    acceso.Text = "Acceder";
                    break;
                case 1:
                    invitado.Visible = false;
                    acceso.Visible = false;
                    label3.Text = "Repita contraseña:";
                    label2.Text = "Ingrese contraseña:";
                    Label1.Text = "Ingrese un nombre de usuario:";
                    registrarse.Text = "Registrarse";



                    break;
                case 2:

                    password2.Visible = false;
                    password1.Visible = false;
                    registrarse.Visible = false;
                    acceso.Visible = false;
                    invitado.Text = "Acceder como invitado";
                    Label1.Text = "¿Como quieres que te llamen?";
                    label2.Visible = false;
                    label3.Visible = false;

                    break;
               
            }

        }

        private void acceso_Click(object sender, EventArgs e)
        {
            logicas logic = new logicas();
            string resultadoError = logic.login(user_n.Text, password1.Text);



            
            if (resultadoError != "")
            {

                aplicacionadmin appad = new aplicacionadmin(app_name, app_version, resultadoError);



                switch (resultadoError)
                {
                    
                    case "Cesar":
                        
                        appad.ShowDialog();

          
                        break;
                    case "Blanco":
                        
                        appad.ShowDialog();

          
                        break;
                    case "Luis":
                        
                        appad.ShowDialog();

          
                        break;
                    default:
                        bool opciones = true;

                        menu_principal _menu = new menu_principal(app_name, app_version, opciones, user_n.Text);

                        _menu.ShowDialog();


                        break;
                }
            }
               
            else
            {
                

                MessageBox.Show(resultadoError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void registrarse_Click(object sender, EventArgs e)
        {
            logicas logic = new logicas();
            string resultadoError = logic.registro(user_n.Text, password1.Text, password2.Text);
            
            if (resultadoError != "") MessageBox.Show(resultadoError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                bool opciones = true;

                menu_principal _menu = new menu_principal(app_name, app_version, opciones, user_n.Text);

                _menu.ShowDialog();


            }
        }

        private void invitado_Click(object sender, EventArgs e)
        {
      

            string resultadoError = Bs.libraryOne.VerifyWorldBlockList(user_n.Text); 

            if (resultadoError != "") MessageBox.Show(resultadoError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                bool opciones = false;

                menu_principal _menu = new menu_principal(app_name, app_version, opciones, user_n.Text);

                _menu.ShowDialog();

                this.Close();
            }


        }
    }
}
