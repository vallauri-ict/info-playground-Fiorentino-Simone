using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ese04_Ereditarietà
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCreaMannaro_Click(object sender, EventArgs e)
        {
            //per casa visualizzare sia i valori di mostro che di mannaro
            Mannaro m1 = new Mannaro("");
        }
    }
}
