using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app.fomularios
{
    public partial class DateRegistre : Form
    {
        public DateRegistre(string inst_nam, string CodigoModularstring, int variable)
        {
            InitializeComponent();

            if(variable == 0 )
            {
                Lb1.Text = "Ingresa ";
            }
            else if(variable >= 1000 && variable <= 9999)
            {

            }
            else if (variable >= 100 && variable <= 999)
            {

            }
        }
    }
}


