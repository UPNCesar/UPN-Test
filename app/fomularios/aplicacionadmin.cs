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
            this.Text = $"{app_name} {app_version}";

            this.user_name = user_name;

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
    }
}
