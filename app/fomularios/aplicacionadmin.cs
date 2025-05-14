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
using app.logic;

namespace app.fomularios
{
    public partial class aplicacionadmin : Form
    {

        private string user_name;
        public aplicacionadmin(string app_name, string app_version, string user_name)
        {
            InitializeComponent();
            this.Text = $"{app_name} {app_version} - Admin Menú";

            this.user_name = user_name;


            Welcome.Text = $" Bienvenido {user_name} a el panel de control de {app_name}. ¿Qué deseas hacer hoy?";
        }



        private void button1_Click(object sender, EventArgs e)
        {//eliminar db admin

            logicas logic = new logicas();

            consoleAdmin.AppendText(logic.Logs_txt(user_name, 1, "", 1) + Environment.NewLine);
            consoleAdmin.ScrollToCaret();

        }

        private void ActivityAdmin_Click(object sender, EventArgs e)
        {

            logicas logic = new logicas();

            consoleAdmin.AppendText(logic.Logs_txt(user_name, 4, "accedió en modo lectura a la base de datos de administradores", 1 ) + Environment.NewLine);
            consoleAdmin.ScrollToCaret();

            console cs = new console(user_name, 1);
            cs.ShowDialog();
        }

        private void ListInst_Click(object sender, EventArgs e)
        {
            logicas logic = new logicas();

            consoleAdmin.AppendText(logic.Logs_txt(user_name, 4, "accedió en modo lectura a la base de datos de lista de instituciones", 1) + Environment.NewLine);
            consoleAdmin.ScrollToCaret();
        }

        private void ListUsers_Click(object sender, EventArgs e)
        {
            logicas logic = new logicas();

            consoleAdmin.AppendText(logic.Logs_txt(user_name, 4, "accedió en modo lectura a la base de datos de lista de usuarios registrados", 1) + Environment.NewLine);
            consoleAdmin.ScrollToCaret();
        }

        private void EditListUsers_Click(object sender, EventArgs e)
        {
            logicas logic = new logicas();

            consoleAdmin.AppendText(logic.Logs_txt(user_name, 4, "accedió en modo editor a la base de datos de lista de instituciones", 2) + Environment.NewLine);
            consoleAdmin.ScrollToCaret();
        }

        private void EditListInst_Click(object sender, EventArgs e)
        {
            logicas logic = new logicas();

            consoleAdmin.AppendText(logic.Logs_txt(user_name, 4, "accedió en modo editor a la base de datos de lista de usuarios registrados", 2) + Environment.NewLine);
            consoleAdmin.ScrollToCaret();
        }

        private void BugandClaim_Click(object sender, EventArgs e)
        {
            logicas logic = new logicas();

            consoleAdmin.AppendText(logic.Logs_txt(user_name, 4, "Está visualizando los reportes/reclamos de la aplicacion", 1) + Environment.NewLine);
            consoleAdmin.ScrollToCaret();

            console cs = new console(user_name, 2);
            cs.ShowDialog();

        }

        private void ClearConsole_Click(object sender, EventArgs e)
        {
            consoleAdmin.Text = "";
        }

        private void addAdmin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Debes solicitar a el dueño principal un nombre y contraseña para su acceso!", "Informacion", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            logicas logic = new logicas();

            consoleAdmin.AppendText("----------------------------------------" + Environment.NewLine);
            consoleAdmin.AppendText(logic.Logs_txt(user_name, 4, "Realizó una solicitud para agregar un nuevo administrador", 1) + Environment.NewLine);
            consoleAdmin.AppendText("----------------------------------------" + Environment.NewLine);
            consoleAdmin.ScrollToCaret();
        }

        private void DeleteAdmin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Debes solicitar a el dueño principal eliminar un usuario", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void TemeClaro_Click(object sender, EventArgs e)
        {
            
            
            
            ListUsers.BackColor = Color.FromArgb(39, 24, 126);
            ListInst.BackColor = Color.FromArgb(39, 24, 126);
            EditListUsers.BackColor = Color.FromArgb(39, 24, 126);
            EditListInst.BackColor = Color.FromArgb(39, 24, 126);
            ActivityAdmin.BackColor = Color.FromArgb(39, 24, 126);
            BugandClaim.BackColor = Color.FromArgb(39, 24, 126);
            addAdmin.BackColor = Color.FromArgb(39, 24, 126);
            DeleteAdmin.BackColor = Color.FromArgb(39, 24, 126);
            Welcome.ForeColor = Color.Black;
            consoleAdmin.BackColor = Color.FromArgb(35, 32, 55);
            paneladmin.BackColor = Color.FromArgb(174, 184, 254);

            this.BackColor = Color.FromArgb(241, 242, 246); 

            pictureBox1.Visible = true;
            TemeClaro.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            ListUsers.BackColor = Color.FromArgb(23, 21, 36);
            ListInst.BackColor = Color.FromArgb(23, 21, 36);
            EditListUsers.BackColor = Color.FromArgb(23, 21, 36);
            EditListInst.BackColor = Color.FromArgb(23, 21, 36);
            ActivityAdmin.BackColor = Color.FromArgb(23, 21, 36);
            BugandClaim.BackColor = Color.FromArgb(23, 21, 36);
            addAdmin.BackColor = Color.FromArgb(23, 21, 36);
            DeleteAdmin.BackColor = Color.FromArgb(23, 21, 36);
            Welcome.ForeColor = Color.White;
            consoleAdmin.BackColor = Color.FromArgb(35, 32, 55);
            paneladmin.BackColor = Color.FromArgb(23, 21, 36);

            this.BackColor = Color.FromArgb(23, 21, 27);

            pictureBox1.Visible = false;
            TemeClaro.Visible = true;
        }

     
    }
}
