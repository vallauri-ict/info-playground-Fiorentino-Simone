namespace Ese04_Ereditarietà
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
            this.btnCreaMannaro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreaMannaro
            // 
            this.btnCreaMannaro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreaMannaro.Location = new System.Drawing.Point(130, 62);
            this.btnCreaMannaro.Name = "btnCreaMannaro";
            this.btnCreaMannaro.Size = new System.Drawing.Size(139, 93);
            this.btnCreaMannaro.TabIndex = 0;
            this.btnCreaMannaro.Text = "CREA MANNARO\r\n";
            this.btnCreaMannaro.UseVisualStyleBackColor = true;
            this.btnCreaMannaro.Click += new System.EventHandler(this.btnCreaMannaro_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 234);
            this.Controls.Add(this.btnCreaMannaro);
            this.Name = "frmMain";
            this.Text = "EREDITARIETA\'";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreaMannaro;
    }
}

