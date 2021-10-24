using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ese_03_Squadre_di_Calcio
{
    public partial class frmSquadreCalcio : Form
    {
        public frmSquadreCalcio()
        {
            InitializeComponent();
        }

        private void frmSquadreCalcio_Load(object sender, EventArgs e)
        {
            Squadre sq = new Squadre();
        }
    }
}
 