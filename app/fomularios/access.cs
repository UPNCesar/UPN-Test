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
        private string cuent_actual;


        public access(short boton, string app_name, string app_version, string cuenta_actual)
        {
            InitializeComponent();
            this.app_name = app_name;
            this.app_version = app_version;
            this.cuent_actual = cuenta_actual;

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
                    acceso_inst.Visible = false;

                    if (cuenta_actual == "form")
                    {
                        cancel_access_menupinricpal.Visible = false;
                        cancelar_acces_form.Visible = true;
                        cancelar_join_invitado.Visible = false;
                    }
                    else
                    {
                        cancel_access_menupinricpal.Visible = true;
                        cancelar_acces_form.Visible = false;
                        cancelar_join_invitado.Visible = false;
                    }
                        
                    break;
                case 1:

                    //------------------------------------------------------------------------------------------------------------------
                    //-------------------------------------------------- Registro de usuario----------------------------------------------------------------
                    //------------------------------------------------------------------------------------------------------------------
                    acceso_inst.Visible = false;
                    invitado.Visible = false;
                    acceso.Visible = false;
                    label3.Text = "Repita contraseña:";
                    label2.Text = "Ingrese contraseña:";
                    Label1.Text = "Ingrese un nombre de usuario:";
                    registrarse.Text = "Registrarse";
                    label4.Visible = false;
                    password3.Visible = false;
                    Create_institucion.Visible = false;
                    cancel_access_menupinricpal.Visible = false;
                    cancelar_join_invitado.Visible = false;

                    if (cuenta_actual == "form")
                    {
                        cancel_access_menupinricpal.Visible = false;
                        cancelar_acces_form.Visible = true;
                        cancelar_join_invitado.Visible = false;
                    }
                    else
                    {
                        cancel_access_menupinricpal.Visible = true;
                        cancelar_acces_form.Visible = false;
                        cancelar_join_invitado.Visible = false;
                    }

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
                    acceso_inst.Visible = false;

                    cancelar_join_invitado.Visible= true;
                    cancel_access_menupinricpal.Visible = false;
                    cancelar_acces_form.Visible = false;

                    break;
                case 3:

                    //------------------------------------------------------------------------------------------------------------------
                    //-------------------------------------------------- creacion de institucion ----------------------------------------------------------------
                    //------------------------------------------------------------------------------------------------------------------

    
                    registrarse.Visible = false;
                    acceso.Visible = false;
                    invitado.Visible= false;
                    Create_institucion.Text = "Crear Institucion";
                    Label1.Visible = false;
                    label4.Visible = false;
                    user_n.Visible = false;
                    password3.Visible = false;
                    label2.Text = "¿Como se llama su institución?";
                    label3.Text = "Ingrese el Código Modular de su IE:";
                    acceso_inst.Visible = false;

                    cancelar_join_invitado.Visible = false;
                    cancel_access_menupinricpal.Visible = true;
                    cancelar_acces_form.Visible = false;
                    break;
                case 4:

                    //------------------------------------------------------------------------------------------------------------------
                    //-------------------------------------------------- acceso a institucion  ----------------------------------------------------------------
                    //------------------------------------------------------------------------------------------------------------------


                    registrarse.Visible = false;
                    acceso.Visible = false;
                    invitado.Visible = false;
                    acceso_inst.Text = "Acceder a Institucion";
                    password3.Visible= false;
                    user_n.Visible= false;
                    Label1.Visible = false;
                    label4.Visible = false;
                    label2.Text = "Ingrese el Código Modular de su IE:";
                    label3.Text = "Ingrese su codigo de 4 dígitos institucional";


                    cancelar_join_invitado.Visible = false;
                    cancel_access_menupinricpal.Visible = true;
                    cancelar_acces_form.Visible = false;

                    break;
                
                

            }

        }

        private void acceso_Click(object sender, EventArgs e)
        {
            logicas logic = new logicas();
            string resultadoError = logic.login(user_n.Text, password1.Text);




            if (resultadoError == "usuario")
            {

                this.Hide();
                menu_principal _menu = new menu_principal(app_name, app_version, 1, user_n.Text, "");
                _menu.ShowDialog();

                this.Close();
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
                menu_principal _menu = new menu_principal(app_name, app_version, 1, user_n.Text, "");

                this.Hide();

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
                menu_principal _menu = new menu_principal(app_name, app_version, 2, user_n.Text, "");

                this.Hide();

                _menu.ShowDialog();
                
                this.Close();

            }


        }


        private void Create_institucion_Click(object sender, EventArgs e)
        {                      
            logicas crearinst = new logicas();

            string resultado = crearinst.registroInst(cuent_actual, password1.Text, password2.Text);

            if (resultado != "") MessageBox.Show(resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                //el 100 a 999 padres, 1000 hasta 9999 profesores, 10000 hasta 100000 directores
                MessageBox.Show($"Tu código: {Bs.libraryOne.GenerateCodigoInst(cuent_actual, password1.Text, password2.Text)}","Tu código de acceso personal:");
                
                menu_principal principal_menu = new menu_principal(app_name, app_version, 3, cuent_actual, password1.Text);

                this.Hide();

                principal_menu.ShowDialog();              
                this.Close();

            }
        }

        private void acceso_inst_Click(object sender, EventArgs e)
        {


            string retorno = Bs.libraryOne.SearchInstAndUSer(cuent_actual, password1.Text, password2.Text);

            if (retorno != "")
            {
                menu_principal principal_menu = new menu_principal(app_name, app_version, 3, cuent_actual, retorno);

                this.Hide();

                principal_menu.ShowDialog();
                this.Close();
            }
            else MessageBox.Show("El codigo modular o dígitos no son correctos, si el error persiste contactate con tu superior.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }


        private void cancel_Click(object sender, EventArgs e) //cancel menu principal
        {

            menu_principal principal_menu = new menu_principal(app_name, app_version, 2, cuent_actual, "");
            this.Hide();
            principal_menu.ShowDialog();
            this.Close();


        }
        private void cancelar_invitado_Click(object sender, EventArgs e) //cancel acces form
        {
            Form1 form1 = new Form1(app_name, app_version);
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }

        private void cancelar_join_invitado_Click(object sender, EventArgs e) //cancelar join invitado
        {


            Form1 form1 = new Form1(app_name, app_version);
            this.Hide();
            form1.ShowDialog();
            this.Close();

        }
    }
}
