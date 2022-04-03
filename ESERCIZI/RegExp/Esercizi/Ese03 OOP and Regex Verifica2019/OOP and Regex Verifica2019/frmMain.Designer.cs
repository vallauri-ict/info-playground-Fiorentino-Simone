
namespace OOP_and_Regex_Verifica2019
{
    partial class frmMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMatricola = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInviaDati = new System.Windows.Forms.Button();
            this.btnVisualizzaSoci = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "VERIFICA OOP E REGEX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(111, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Matricola:";
            // 
            // txtMatricola
            // 
            this.txtMatricola.Location = new System.Drawing.Point(194, 91);
            this.txtMatricola.Name = "txtMatricola";
            this.txtMatricola.Size = new System.Drawing.Size(176, 20);
            this.txtMatricola.TabIndex = 2;
            this.txtMatricola.TextChanged += new System.EventHandler(this.txtMatricola_TextChanged);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(193, 122);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(176, 20);
            this.txtNome.TabIndex = 4;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(110, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nome:";
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(193, 155);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(176, 20);
            this.txtCognome.TabIndex = 6;
            this.txtCognome.TextChanged += new System.EventHandler(this.txtCognome_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(110, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cognome:";
            // 
            // btnInviaDati
            // 
            this.btnInviaDati.Location = new System.Drawing.Point(113, 191);
            this.btnInviaDati.Name = "btnInviaDati";
            this.btnInviaDati.Size = new System.Drawing.Size(117, 40);
            this.btnInviaDati.TabIndex = 7;
            this.btnInviaDati.Text = "INVIA DATI";
            this.btnInviaDati.UseVisualStyleBackColor = true;
            this.btnInviaDati.Click += new System.EventHandler(this.btnInviaDati_Click);
            // 
            // btnVisualizzaSoci
            // 
            this.btnVisualizzaSoci.Location = new System.Drawing.Point(253, 191);
            this.btnVisualizzaSoci.Name = "btnVisualizzaSoci";
            this.btnVisualizzaSoci.Size = new System.Drawing.Size(117, 40);
            this.btnVisualizzaSoci.TabIndex = 8;
            this.btnVisualizzaSoci.Text = "VISUALIZZAZIONE SOCI";
            this.btnVisualizzaSoci.UseVisualStyleBackColor = true;
            this.btnVisualizzaSoci.Click += new System.EventHandler(this.btnVisualizzaSoci_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 265);
            this.Controls.Add(this.btnVisualizzaSoci);
            this.Controls.Add(this.btnInviaDati);
            this.Controls.Add(this.txtCognome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMatricola);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "VERIFICA 2019";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMatricola;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnInviaDati;
        private System.Windows.Forms.Button btnVisualizzaSoci;
    }
}

