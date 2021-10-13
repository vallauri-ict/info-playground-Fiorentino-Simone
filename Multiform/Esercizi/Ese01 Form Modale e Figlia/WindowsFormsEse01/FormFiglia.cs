using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsEse01
{
    public partial class FormFiglia : Form
    {
        public FormFiglia()
        {
            InitializeComponent();
        }

        private void btnIndividuoFiglia_Click(object sender, EventArgs e)
        {
            if (Owner != null)
            {
                MessageBox.Show("Form figlia di: " + Owner.Text);
            }
            else MessageBox.Show("Non sei figlia di nessuno");
        }
    }
}
