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
                    //------------------------------------------------------------------------------------------------------------------
                    //-------------------------------------------------- login de usuario ----------------------------------------------------------------
                    //------------------------------------------------------------------------------------------------------------------
                    password2.Visible = false;
                    invitado.Visible = false;
                    label3.Visible = false;
                    registrarse.Visible = false;
                    label2.Text = "Ingrese su contraseña:";
                    Label1.Text = "Ingrese su nombre de usuario:";
                    label4.Visible = false;
                    acceso.Text = "Acceder";
                    password3.Visible = false;
                    Create_institucion.Visible = false;
                    break;
                case 1:

                    //------------------------------------------------------------------------------------------------------------------
                    //-------------------------------------------------- Registro de usuario ----------------------------------------------------------------
                    //------------------------------------------------------------------------------------------------------------------

                    invitado.Visible = false;
                    acceso.Visible = false;
                    label3.Text = "Repita contraseña:";
                    label2.Text = "Ingrese contraseña:";
                    Label1.Text = "Ingrese un nombre de usuario:";
                    registrarse.Text = "Registrarse";
                    label4.Visible = false;
                    password3.Visible = false;
                    Create_institucion.Visible = false;
                    break;
                case 2:

                    //------------------------------------------------------------------------------------------------------------------
                    //-------------------------------------------------- acceso invitado ----------------------------------------------------------------
                    //------------------------------------------------------------------------------------------------------------------

                    password2.Visible = false;
                    password1.Visible = false;
                    registrarse.Visible = false;
                    acceso.Visible = false;
                    invitado.Text = "Acceder como invitado";
                    Label1.Text = "¿Como quieres que te llamen?";
                    label2.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                    password3.Visible = false;
                    Create_institucion.Visible = false;

                    break;
                case 3:

                    //------------------------------------------------------------------------------------------------------------------
                    //-------------------------------------------------- creacion de institucion ----------------------------------------------------------------
                    //------------------------------------------------------------------------------------------------------------------

                    
                    registrarse.Visible = false;
                    acceso.Visible = false;
                    invitado.Visible= false;
                    Create_institucion.Text = "Crear Institucion";
                    Label1.Text = "Ingresa tu nombre de usuario";
                    label2.Text = "¿Como se llama tu institución?";
                    label3.Text = "Ingrese el Código Modular de su IE:";
                    label4.Text = "Ingrese contraseña para acceso institucional";
                    
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
                Form1 f1 = new Form1(app_name, app_version);


                switch (resultadoError)
                {
                    
                    case "Cesar":

                        this.Hide();

                        f1.Hide();
                        appad.ShowDialog();
                        
                        this.Close();
          
                        break;
                    case "Blanco":

                        this.Hide();

                        f1.Hide();
                        appad.ShowDialog();
                        
                        this.Close();

                        break;
                    case "Luis":

                        this.Hide();

                        f1.Hide();
                        appad.ShowDialog();
                        
                        this.Close();

                        break;

                    case "usuario":
                        f1.Hide();

                        menu_principal _menu = new menu_principal(app_name, app_version, 1, user_n.Text);
             
                        _menu.ShowDialog();
                        
                        this.Close();

                        break;

                    default:

                        MessageBox.Show(resultadoError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        break;
                }
            }
               
           
        }

        private void registrarse_Click(object sender, EventArgs e)
        {
            logicas logic = new logicas();
            string resultadoError = logic.registro(user_n.Text, password1.Text, password2.Text);
            
            if (resultadoError != "") MessageBox.Show(resultadoError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                menu_principal _menu = new menu_principal(app_name, app_version, 1, user_n.Text);

                this.Hide();

                Form1 f1 = new Form1(app_name, app_version);
                f1.Hide();

                _menu.ShowDialog();
                
                this.Close();

            }
        }

        private void invitado_Click(object sender, EventArgs e)
        {
      

            bool resultadoError = Bs.libraryOne.VerifyWorldBlockList(user_n.Text); 

            if (!resultadoError) MessageBox.Show("Error, El texto contiene términos restringidos.Por favor, utiliza un lenguaje adecuado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                menu_principal _menu = new menu_principal(app_name, app_version, 2, user_n.Text);

                this.Hide();
                Form1 f1 = new Form1(app_name, app_version);
                
                f1.Hide();

                _menu.ShowDialog();
                
                this.Close();

            }


        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Create_institucion_Click(object sender, EventArgs e)
        {                      
            logicas crearinst = new logicas();

            string resultado = crearinst.registroInst(user_n.Text, password1.Text, password2.Text, password3.Text);

            if (resultado != "") MessageBox.Show(resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {

                menu_principal principal_menu = new menu_principal(app_name, app_version, 3, user_n.Text);

                this.Hide();

                principal_menu.ShowDialog();              
                this.Close();

            }
        }
    }
}
