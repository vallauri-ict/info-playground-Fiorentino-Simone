namespace Ese07_Factory_Quadrato
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
            this.btnFactory = new System.Windows.Forms.Button();
            this.btnProvaSingleton = new System.Windows.Forms.Button();
            this.btnIndexata = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFactory
            // 
            this.btnFactory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFactory.Location = new System.Drawing.Point(38, 38);
            this.btnFactory.Name = "btnFactory";
            this.btnFactory.Size = new System.Drawing.Size(202, 79);
            this.btnFactory.TabIndex = 0;
            this.btnFactory.Text = "PROVA CLASSE FACTORY";
            this.btnFactory.UseVisualStyleBackColor = true;
            this.btnFactory.Click += new System.EventHandler(this.btnFactory_Click);
            // 
            // btnProvaSingleton
            // 
            this.btnProvaSingleton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProvaSingleton.Location = new System.Drawing.Point(263, 38);
            this.btnProvaSingleton.Name = "btnProvaSingleton";
            this.btnProvaSingleton.Size = new System.Drawing.Size(202, 79);
            this.btnProvaSingleton.TabIndex = 1;
            this.btnProvaSingleton.Text = "PROVA CLASSE SINGLETON";
            this.btnProvaSingleton.UseVisualStyleBackColor = true;
            this.btnProvaSingleton.Click += new System.EventHandler(this.btnProvaSingleton_Click);
            // 
            // btnIndexata
            // 
            this.btnIndexata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIndexata.Location = new System.Drawing.Point(145, 123);
            this.btnIndexata.Name = "btnIndexata";
            this.btnIndexata.Size = new System.Drawing.Size(202, 79);
            this.btnIndexata.TabIndex = 2;
            this.btnIndexata.Text = "PROVA CLASSE INDEXATA";
            this.btnIndexata.UseVisualStyleBackColor = true;
            this.btnIndexata.Click += new System.EventHandler(this.btnIndexata_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 262);
            this.Controls.Add(this.btnIndexata);
            this.Controls.Add(this.btnProvaSingleton);
            this.Controls.Add(this.btnFactory);
            this.Name = "frmMain";
            this.Text = "FACTORY QUADRATO";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFactory;
        private System.Windows.Forms.Button btnProvaSingleton;
        private System.Windows.Forms.Button btnIndexata;
    }
}

