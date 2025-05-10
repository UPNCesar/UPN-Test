using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void EscribirConsola(string mensaje)
        {
            consoleAdmin.AppendText(mensaje + Environment.NewLine);
            consoleAdmin.ScrollToCaret();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EscribirConsola($"[ADMIN] {user_name}: Eliminó la base de datos de registro");
        }
    }
}
