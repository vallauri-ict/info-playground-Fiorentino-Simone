﻿using System;
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
    public partial class FormModale : Form
    {
        public string nome="";
        public string età="";

        public FormModale()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            nome = txtNome.Text;
            età = txtEtà.Text;
            //non c'è bisogno di inserirlo nell'ok dello show dialog siccome l'abbiamo inserito noi nelle proprietà
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            nome = "";
            età = "";
        }
    }
}
