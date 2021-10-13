using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verifica_FIORENTINO_SIMONE
{
    public partial class frmApri2 : Form
    {
        public frmApri2()
        {
            InitializeComponent();
        }

        public frmApri2(string lblMacchina, string lblChk)
        {
            InitializeComponent(); //da inserirlo sempre in qualsiasi costruttore
            this.lblRisultato.Text = lblMacchina+" "+lblChk;
        }
    }
}
