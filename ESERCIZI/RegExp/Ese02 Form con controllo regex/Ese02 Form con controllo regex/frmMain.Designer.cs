namespace Ese02_Form_con_controllo_regex
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
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.avviaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.esciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblInizia = new System.Windows.Forms.Label();
            this.btnAvviaForm = new System.Windows.Forms.Button();
            this.gbForm = new System.Windows.Forms.GroupBox();
            this.lblTitolo = new System.Windows.Forms.Label();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.avviaToolStripMenuItem,
            this.toolStripMenuItem1,
            this.esciToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(950, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // avviaToolStripMenuItem
            // 
            this.avviaToolStripMenuItem.Name = "avviaToolStripMenuItem";
            this.avviaToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.avviaToolStripMenuItem.Text = "Avvia";
            this.avviaToolStripMenuItem.Click += new System.EventHandler(this.avviaForm_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // esciToolStripMenuItem
            // 
            this.esciToolStripMenuItem.Name = "esciToolStripMenuItem";
            this.esciToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.esciToolStripMenuItem.Text = "Esci";
            // 
            // lblInizia
            // 
            this.lblInizia.AutoSize = true;
            this.lblInizia.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInizia.Location = new System.Drawing.Point(68, 97);
            this.lblInizia.Name = "lblInizia";
            this.lblInizia.Size = new System.Drawing.Size(0, 38);
            this.lblInizia.TabIndex = 1;
            // 
            // btnAvviaForm
            // 
            this.btnAvviaForm.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvviaForm.Location = new System.Drawing.Point(732, 485);
            this.btnAvviaForm.Name = "btnAvviaForm";
            this.btnAvviaForm.Size = new System.Drawing.Size(218, 75);
            this.btnAvviaForm.TabIndex = 2;
            this.btnAvviaForm.Text = "AVVIA FORM";
            this.btnAvviaForm.UseVisualStyleBackColor = true;
            this.btnAvviaForm.Visible = false;
            this.btnAvviaForm.Click += new System.EventHandler(this.avviaForm_Click);
            // 
            // gbForm
            // 
            this.gbForm.Location = new System.Drawing.Point(225, 97);
            this.gbForm.Name = "gbForm";
            this.gbForm.Size = new System.Drawing.Size(501, 404);
            this.gbForm.TabIndex = 3;
            this.gbForm.TabStop = false;
            // 
            // lblTitolo
            // 
            this.lblTitolo.AutoSize = true;
            this.lblTitolo.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblTitolo.Location = new System.Drawing.Point(325, 44);
            this.lblTitolo.Name = "lblTitolo";
            this.lblTitolo.Size = new System.Drawing.Size(270, 38);
            this.lblTitolo.TabIndex = 0;
            this.lblTitolo.Text = "FORM CON REGEX";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 560);
            this.Controls.Add(this.lblTitolo);
            this.Controls.Add(this.gbForm);
            this.Controls.Add(this.btnAvviaForm);
            this.Controls.Add(this.lblInizia);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "frmMain";
            this.Text = "FORM CON REGEX";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem avviaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem esciToolStripMenuItem;
        private System.Windows.Forms.Label lblInizia;
        private System.Windows.Forms.Button btnAvviaForm;
        private System.Windows.Forms.GroupBox gbForm;
        private System.Windows.Forms.Label lblTitolo;
    }
}

