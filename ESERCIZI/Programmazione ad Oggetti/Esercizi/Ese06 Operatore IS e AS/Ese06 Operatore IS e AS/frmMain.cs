using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ese06_Operatore_IS_e_AS
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGeneraMostro_Click(object sender, EventArgs e)
        {
            Mostro guardiano;
            if (rnd.Next(2) == 0)
                guardiano = new Mannaro();
            else guardiano = new Zombie();

            MessageBox.Show("Verso del mostro: "+guardiano.Verso()); //siccome non specifichiamo(as) e non controlliamo(is) lui andrà a prendere il verso della classe padre
            if(guardiano is Mannaro) MessageBox.Show("Verso del Mannaro: " + (guardiano as Mannaro).Verso()); //si può anche fare il cast, (anche perchè as fa un cast) ---> ((Mannaro)guardiano).Verso();
            else if (guardiano is Zombie) MessageBox.Show("Verso del Zombie: " + (guardiano as Zombie).Verso());
        }

        private void btnOrLabel_Click(object sender, EventArgs e)
        {
            //Object --> è il padre di tutti gli oggetti
            
            // Equivalente al cast di as: Button btn=(Button) sender;
            if (sender is Button)
            {
                (sender as Button).Text = "Cliccato";
            }
            else if (sender is Label)
            {
                (sender as Label).BackColor = Color.Red;
            }
        }
    }
}