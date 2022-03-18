namespace Scontro_fra_veicoli
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
            this.btnCamion = new System.Windows.Forms.Button();
            this.btnAuto = new System.Windows.Forms.Button();
            this.btnMoto = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCamion
            // 
            this.btnCamion.Location = new System.Drawing.Point(12, 12);
            this.btnCamion.Name = "btnCamion";
            this.btnCamion.Size = new System.Drawing.Size(75, 23);
            this.btnCamion.TabIndex = 0;
            this.btnCamion.Text = "Camion";
            this.btnCamion.UseVisualStyleBackColor = true;
            this.btnCamion.Click += new System.EventHandler(this.btnCamion_Click);
            // 
            // btnAuto
            // 
            this.btnAuto.Location = new System.Drawing.Point(102, 12);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(75, 23);
            this.btnAuto.TabIndex = 1;
            this.btnAuto.Text = "Auto";
            this.btnAuto.UseVisualStyleBackColor = true;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // btnMoto
            // 
            this.btnMoto.Location = new System.Drawing.Point(193, 12);
            this.btnMoto.Name = "btnMoto";
            this.btnMoto.Size = new System.Drawing.Size(75, 23);
            this.btnMoto.TabIndex = 2;
            this.btnMoto.Text = "Moto";
            this.btnMoto.UseVisualStyleBackColor = true;
            this.btnMoto.Click += new System.EventHandler(this.btnMoto_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(90, 90);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(103, 33);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = "Inizia scontro";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 182);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnMoto);
            this.Controls.Add(this.btnAuto);
            this.Controls.Add(this.btnCamion);
            this.Name = "frmMain";
            this.Text = "Scontri fra veicoli";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCamion;
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.Button btnMoto;
        private System.Windows.Forms.Button btnPlay;
    }
}

