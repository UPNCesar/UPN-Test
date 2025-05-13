using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using app.logic;

namespace app.fomularios
{
    public partial class console : Form
    {

        private string user_nam;

        public console(string user_name, short options)
        {
            InitializeComponent();

            this.ControlBox = false;

            this.user_nam = user_name;

            this.Text = $"Consola de {user_nam}";

            switch (options)
            {
                case 1:
                    reportesView.Visible = false;
                    delREports.Visible = false;

                    break;
                case 2:

                    Admdelreg.Visible = false;
                    ViewActi.Visible = false;
                    break;
            }
        }


        private void ViewActi_Click(object sender, EventArgs e)
        {
            TextReader AdminAction = new StreamReader(@"D:\app2\app\data\AdmActions.txt");

            MultConsol.Text = AdminAction.ReadToEnd();

            AdminAction.Close();

            logicas logic = new logicas();

            logic.Logs_txt(user_nam, 4, "Visualizó el historial de acciones de los administradores", 1);
        }


        private void Admdelreg_Click(object sender, EventArgs e)
        {
            logicas logic = new logicas();

            MessageBox.Show(logic.Logs_txt(user_nam, 1, "", 1));

            
        }

        private void reportesView_Click(object sender, EventArgs e)
        {
            TextReader reportAction = new StreamReader(@"D:\app2\app\data\reports.txt");

            MultConsol.Text = reportAction.ReadToEnd();

            logicas logic = new logicas();

            logic.Logs_txt(user_nam, 4, "Visualizó los reportes activos de la aplicacion", 1);
        }

        private void delREports_Click(object sender, EventArgs e)
        {
            logicas logic = new logicas();

            MessageBox.Show(logic.Logs_txt(user_nam, 6, "", 1));


        }

        private void leave_Click(object sender, EventArgs e)
        {
            this.Close();

            logicas logic = new logicas();

            logic.Logs_txt(user_nam, 4, "Salió de su consola personal", 1);
        }
    }
}
