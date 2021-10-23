namespace Ese02_Controllo_compatibilità
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
            this.btnPassaggioPerValore = new System.Windows.Forms.Button();
            this.btnPassaggioPerREF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPassaggioPerValore
            // 
            this.btnPassaggioPerValore.Location = new System.Drawing.Point(166, 51);
            this.btnPassaggioPerValore.Name = "btnPassaggioPerValore";
            this.btnPassaggioPerValore.Size = new System.Drawing.Size(177, 68);
            this.btnPassaggioPerValore.TabIndex = 0;
            this.btnPassaggioPerValore.Text = "PASSAGGIO PER VALORE";
            this.btnPassaggioPerValore.UseVisualStyleBackColor = true;
            this.btnPassaggioPerValore.Click += new System.EventHandler(this.btnPassaggioPerValore_Click);
            // 
            // btnPassaggioPerREF
            // 
            this.btnPassaggioPerREF.Location = new System.Drawing.Point(166, 155);
            this.btnPassaggioPerREF.Name = "btnPassaggioPerREF";
            this.btnPassaggioPerREF.Size = new System.Drawing.Size(177, 68);
            this.btnPassaggioPerREF.TabIndex = 1;
            this.btnPassaggioPerREF.Text = "PASSAGGIO PER RIFERIMENTO";
            this.btnPassaggioPerREF.UseVisualStyleBackColor = true;
            this.btnPassaggioPerREF.Click += new System.EventHandler(this.btnPassaggioPerREF_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(504, 280);
            this.Controls.Add(this.btnPassaggioPerREF);
            this.Controls.Add(this.btnPassaggioPerValore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmMain";
            this.Text = "CONTROLLO COMPATIBILITA\'  E PASSAGGIO PARAMETRI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPassaggioPerValore;
        private System.Windows.Forms.Button btnPassaggioPerREF;
    }
}

