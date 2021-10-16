using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verifica2021
{
    public partial class FormApri1 : Form
    {
        public string scelta;

        FormModale frmM;
        frmFinestra2 frm2;
        frmMain frm=new frmMain();
        

        public FormApri1()
        {
            InitializeComponent();
        }

        public FormApri1(bool abilita)
        {
            InitializeComponent();
            this.Enabled = abilita;
        }

        private void FormApri1_Load(object sender, EventArgs e)
        {
            this.Enabled = true;
            foreach (Button btn in this.Controls)
                btn.Click += new EventHandler(ButtonClick);
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            frm.Close();
            Button btn = (Button)sender;
            btn.Focus();
            btn.BackColor = Color.Aquamarine;

            scelta = btn.Text;
            frmM = new FormModale();

            if (frmM.ShowDialog() == DialogResult.Yes)
            {
                //this.Enabled = false;
                frm2 = new frmFinestra2(scelta,this);
                frm2.MdiParent = this.ParentForm; //this.ParentForm ==> per assegnare MdiParent al main
                frm2.StartPosition = FormStartPosition.Manual;
                frm2.Location = new Point(700, 0);
                frm2.Show();
            }
        }
    }
}
