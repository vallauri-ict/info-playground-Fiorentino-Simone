using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ese02_Form_con_controllo_regex
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblInizia.Text = "AVVIA LA FORM, premendo il pulsante qui sotto";
        }

        private void avviaForm_Click(object sender, EventArgs e)
        {
            lblInizia.Visible = false;
            btnAvviaForm.Visible = false;
        }
    }
}
