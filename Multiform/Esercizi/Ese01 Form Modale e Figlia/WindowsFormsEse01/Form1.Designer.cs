namespace WindowsFormsEse01
{
    partial class Form1
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
            this.btnOpenForm2 = new System.Windows.Forms.Button();
            this.btnOpenForm2B = new System.Windows.Forms.Button();
            this.txtFormDaPassare = new System.Windows.Forms.TextBox();
            this.btnForm2Controllo = new System.Windows.Forms.Button();
            this.lblTestoDaPassare = new System.Windows.Forms.Label();
            this.btnApriFormModale = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenForm2
            // 
            this.btnOpenForm2.Location = new System.Drawing.Point(12, 12);
            this.btnOpenForm2.Name = "btnOpenForm2";
            this.btnOpenForm2.Size = new System.Drawing.Size(180, 63);
            this.btnOpenForm2.TabIndex = 0;
            this.btnOpenForm2.Text = "APRI FORM 2";
            this.btnOpenForm2.UseVisualStyleBackColor = true;
            this.btnOpenForm2.Click += new System.EventHandler(this.btnOpenForm2_Click);
            // 
            // btnOpenForm2B
            // 
            this.btnOpenForm2B.Location = new System.Drawing.Point(252, 12);
            this.btnOpenForm2B.Name = "btnOpenForm2B";
            this.btnOpenForm2B.Size = new System.Drawing.Size(180, 63);
            this.btnOpenForm2B.TabIndex = 1;
            this.btnOpenForm2B.Text = "APRI FORM 2B";
            this.btnOpenForm2B.UseVisualStyleBackColor = true;
            // 
            // txtFormDaPassare
            // 
            this.txtFormDaPassare.Location = new System.Drawing.Point(29, 139);
            this.txtFormDaPassare.Name = "txtFormDaPassare";
            this.txtFormDaPassare.Size = new System.Drawing.Size(242, 20);
            this.txtFormDaPassare.TabIndex = 2;
            // 
            // btnForm2Controllo
            // 
            this.btnForm2Controllo.Location = new System.Drawing.Point(290, 124);
            this.btnForm2Controllo.Name = "btnForm2Controllo";
            this.btnForm2Controllo.Size = new System.Drawing.Size(91, 48);
            this.btnForm2Controllo.TabIndex = 3;
            this.btnForm2Controllo.Text = "INVIA TESTO A FORM2";
            this.btnForm2Controllo.UseVisualStyleBackColor = true;
            this.btnForm2Controllo.Click += new System.EventHandler(this.btnForm2Controllo_Click);
            // 
            // lblTestoDaPassare
            // 
            this.lblTestoDaPassare.AutoSize = true;
            this.lblTestoDaPassare.Location = new System.Drawing.Point(29, 111);
            this.lblTestoDaPassare.Name = "lblTestoDaPassare";
            this.lblTestoDaPassare.Size = new System.Drawing.Size(242, 13);
            this.lblTestoDaPassare.TabIndex = 4;
            this.lblTestoDaPassare.Text = "INSERISCI UN TESTO DA PASSARE A FORM 2";
            // 
            // btnApriFormModale
            // 
            this.btnApriFormModale.Location = new System.Drawing.Point(145, 200);
            this.btnApriFormModale.Name = "btnApriFormModale";
            this.btnApriFormModale.Size = new System.Drawing.Size(143, 79);
            this.btnApriFormModale.TabIndex = 5;
            this.btnApriFormModale.Text = "APRI FORM MODALE";
            this.btnApriFormModale.UseVisualStyleBackColor = true;
            this.btnApriFormModale.Click += new System.EventHandler(this.btnApriFormModale_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 432);
            this.Controls.Add(this.btnApriFormModale);
            this.Controls.Add(this.lblTestoDaPassare);
            this.Controls.Add(this.btnForm2Controllo);
            this.Controls.Add(this.txtFormDaPassare);
            this.Controls.Add(this.btnOpenForm2B);
            this.Controls.Add(this.btnOpenForm2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenForm2;
        private System.Windows.Forms.Button btnOpenForm2B;
        private System.Windows.Forms.TextBox txtFormDaPassare;
        private System.Windows.Forms.Button btnForm2Controllo;
        private System.Windows.Forms.Label lblTestoDaPassare;
        private System.Windows.Forms.Button btnApriFormModale;
    }
}

