namespace Ese_03_Squadre_di_Calcio
{
    partial class frmSquadreCalcio
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
            this.lblAtlante = new System.Windows.Forms.Label();
            this.lblMacedonia = new System.Windows.Forms.Label();
            this.lblVirtus = new System.Windows.Forms.Label();
            this.txtPrimaSquadra = new System.Windows.Forms.TextBox();
            this.txtPrimoValore = new System.Windows.Forms.TextBox();
            this.txtSecondoValore = new System.Windows.Forms.TextBox();
            this.txtSecondaSquadra = new System.Windows.Forms.TextBox();
            this.txtTerzoValore = new System.Windows.Forms.TextBox();
            this.txtTerzaSquadra = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblAtlante
            // 
            this.lblAtlante.AutoSize = true;
            this.lblAtlante.Location = new System.Drawing.Point(13, 36);
            this.lblAtlante.Name = "lblAtlante";
            this.lblAtlante.Size = new System.Drawing.Size(43, 13);
            this.lblAtlante.TabIndex = 0;
            this.lblAtlante.Text = "Atlante:";
            // 
            // lblMacedonia
            // 
            this.lblMacedonia.AutoSize = true;
            this.lblMacedonia.Location = new System.Drawing.Point(13, 83);
            this.lblMacedonia.Name = "lblMacedonia";
            this.lblMacedonia.Size = new System.Drawing.Size(63, 13);
            this.lblMacedonia.TabIndex = 1;
            this.lblMacedonia.Text = "Macedonia:";
            // 
            // lblVirtus
            // 
            this.lblVirtus.AutoSize = true;
            this.lblVirtus.Location = new System.Drawing.Point(13, 131);
            this.lblVirtus.Name = "lblVirtus";
            this.lblVirtus.Size = new System.Drawing.Size(33, 13);
            this.lblVirtus.TabIndex = 2;
            this.lblVirtus.Text = "Virtus";
            // 
            // txtPrimaSquadra
            // 
            this.txtPrimaSquadra.Location = new System.Drawing.Point(176, 29);
            this.txtPrimaSquadra.Name = "txtPrimaSquadra";
            this.txtPrimaSquadra.Size = new System.Drawing.Size(100, 20);
            this.txtPrimaSquadra.TabIndex = 3;
            // 
            // txtPrimoValore
            // 
            this.txtPrimoValore.Location = new System.Drawing.Point(354, 29);
            this.txtPrimoValore.Name = "txtPrimoValore";
            this.txtPrimoValore.Size = new System.Drawing.Size(100, 20);
            this.txtPrimoValore.TabIndex = 4;
            // 
            // txtSecondoValore
            // 
            this.txtSecondoValore.Location = new System.Drawing.Point(354, 76);
            this.txtSecondoValore.Name = "txtSecondoValore";
            this.txtSecondoValore.Size = new System.Drawing.Size(100, 20);
            this.txtSecondoValore.TabIndex = 6;
            // 
            // txtSecondaSquadra
            // 
            this.txtSecondaSquadra.Location = new System.Drawing.Point(176, 76);
            this.txtSecondaSquadra.Name = "txtSecondaSquadra";
            this.txtSecondaSquadra.Size = new System.Drawing.Size(100, 20);
            this.txtSecondaSquadra.TabIndex = 5;
            // 
            // txtTerzoValore
            // 
            this.txtTerzoValore.Location = new System.Drawing.Point(354, 124);
            this.txtTerzoValore.Name = "txtTerzoValore";
            this.txtTerzoValore.Size = new System.Drawing.Size(100, 20);
            this.txtTerzoValore.TabIndex = 8;
            // 
            // txtTerzaSquadra
            // 
            this.txtTerzaSquadra.Location = new System.Drawing.Point(176, 124);
            this.txtTerzaSquadra.Name = "txtTerzaSquadra";
            this.txtTerzaSquadra.Size = new System.Drawing.Size(100, 20);
            this.txtTerzaSquadra.TabIndex = 7;
            // 
            // frmSquadreCalcio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 421);
            this.Controls.Add(this.txtTerzoValore);
            this.Controls.Add(this.txtTerzaSquadra);
            this.Controls.Add(this.txtSecondoValore);
            this.Controls.Add(this.txtSecondaSquadra);
            this.Controls.Add(this.txtPrimoValore);
            this.Controls.Add(this.txtPrimaSquadra);
            this.Controls.Add(this.lblVirtus);
            this.Controls.Add(this.lblMacedonia);
            this.Controls.Add(this.lblAtlante);
            this.Name = "frmSquadreCalcio";
            this.Text = "SQUADRE DI CALCIO";
            this.Load += new System.EventHandler(this.frmSquadreCalcio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAtlante;
        private System.Windows.Forms.Label lblMacedonia;
        private System.Windows.Forms.Label lblVirtus;
        private System.Windows.Forms.TextBox txtPrimaSquadra;
        private System.Windows.Forms.TextBox txtPrimoValore;
        private System.Windows.Forms.TextBox txtSecondoValore;
        private System.Windows.Forms.TextBox txtSecondaSquadra;
        private System.Windows.Forms.TextBox txtTerzoValore;
        private System.Windows.Forms.TextBox txtTerzaSquadra;
    }
}

