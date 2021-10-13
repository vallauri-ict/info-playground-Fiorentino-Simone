using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esercitazione_Verifica
{
    public partial class frmApri2 : Form
    {

        public frmApri2()
        {
            InitializeComponent();
        }

        public frmApri2(string lblAuto, string lblRivestimento)
        {
            InitializeComponent(); //da inserirlo sempre in qualsiasi costruttore
            this.lblMarca.Text = lblAuto;
            this.lblInterni.Text = lblRivestimento;
        }
    }
}
