namespace Gioco_interfacce
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
            this.btnIniziaGioco = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIniziaGioco
            // 
            this.btnIniziaGioco.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniziaGioco.Location = new System.Drawing.Point(40, 34);
            this.btnIniziaGioco.Name = "btnIniziaGioco";
            this.btnIniziaGioco.Size = new System.Drawing.Size(141, 54);
            this.btnIniziaGioco.TabIndex = 0;
            this.btnIniziaGioco.Text = "Inizia gioco";
            this.btnIniziaGioco.UseVisualStyleBackColor = true;
            this.btnIniziaGioco.Click += new System.EventHandler(this.btnIniziaGioco_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 183);
            this.Controls.Add(this.btnIniziaGioco);
            this.Name = "Form1";
            this.Text = "Form1";
            
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIniziaGioco;
    }
}

