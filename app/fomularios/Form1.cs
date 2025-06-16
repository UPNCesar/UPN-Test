using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app
{
    public partial class Form1 : Form
    {

    
        private string app_nam;
        private string app_versio;
        
        //defininicion de var como instancia

        public Form1(string app_name, string app_version)
        {      
            InitializeComponent();  
            this.Text = $"{app_name} {app_version}";
            this.app_nam = app_name ;
            this.app_versio = app_version ;
        }
        private void login_Click(object sender, EventArgs e)
        {
            access acceso = new access(0, app_nam, app_versio, "form");
            this.Hide();
            acceso.ShowDialog();
            this.Close();
        }
        private void register_Click(object sender, EventArgs e)
        {
            access acceso = new access(1, app_nam, app_versio, "form");
            this.Hide();
            acceso.ShowDialog();
            this.Close();
        }
    }
}
