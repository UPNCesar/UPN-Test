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
    public partial class asisteas : Form
    {
        public asisteas(string app_name, string app_version, int codigo)
        {
            InitializeComponent();

            //el 100 a 999 padres, 1000 hasta 9999 profesores, 10000 hasta 100000 directores

            string hola = Txt1.Text;
        }

        private void Boton_asistencias_Click(object sender, EventArgs e)
        {

        }
    }
}
