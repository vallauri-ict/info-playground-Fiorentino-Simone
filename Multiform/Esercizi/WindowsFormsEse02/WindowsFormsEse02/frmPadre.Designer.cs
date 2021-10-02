namespace WindowsFormsEse02
{
    partial class frmPadre
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
            this.bntApriFiglia1 = new System.Windows.Forms.Button();
            this.btnApriFiglia2 = new System.Windows.Forms.Button();
            this.btnFinestreAperte = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menùToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apri1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apri2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bntApriFiglia1
            // 
            this.bntApriFiglia1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntApriFiglia1.Location = new System.Drawing.Point(144, 217);
            this.bntApriFiglia1.Name = "bntApriFiglia1";
            this.bntApriFiglia1.Size = new System.Drawing.Size(176, 125);
            this.bntApriFiglia1.TabIndex = 1;
            this.bntApriFiglia1.Text = "APRI PRIMA FIGLIA ";
            this.bntApriFiglia1.UseVisualStyleBackColor = true;
            this.bntApriFiglia1.Click += new System.EventHandler(this.bntApriFiglia1_Click);
            // 
            // btnApriFiglia2
            // 
            this.btnApriFiglia2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApriFiglia2.Location = new System.Drawing.Point(490, 217);
            this.btnApriFiglia2.Name = "btnApriFiglia2";
            this.btnApriFiglia2.Size = new System.Drawing.Size(176, 125);
            this.btnApriFiglia2.TabIndex = 2;
            this.btnApriFiglia2.Text = "APRI SECONDA FIGLIA ";
            this.btnApriFiglia2.UseVisualStyleBackColor = true;
            this.btnApriFiglia2.Click += new System.EventHandler(this.btnApriFiglia2_Click);
            // 
            // btnFinestreAperte
            // 
            this.btnFinestreAperte.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinestreAperte.Location = new System.Drawing.Point(316, 348);
            this.btnFinestreAperte.Name = "btnFinestreAperte";
            this.btnFinestreAperte.Size = new System.Drawing.Size(176, 125);
            this.btnFinestreAperte.TabIndex = 3;
            this.btnFinestreAperte.Text = "FINESTRE APERTE";
            this.btnFinestreAperte.UseVisualStyleBackColor = true;
            this.btnFinestreAperte.Click += new System.EventHandler(this.btnFinestreAperte_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menùToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(811, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menùToolStripMenuItem
            // 
            this.menùToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.apri1ToolStripMenuItem,
            this.apri2ToolStripMenuItem,
            this.esciToolStripMenuItem});
            this.menùToolStripMenuItem.Name = "menùToolStripMenuItem";
            this.menùToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menùToolStripMenuItem.Text = "&Menù";
            // 
            // apri1ToolStripMenuItem
            // 
            this.apri1ToolStripMenuItem.Name = "apri1ToolStripMenuItem";
            this.apri1ToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.apri1ToolStripMenuItem.Text = "Apri &1";
            this.apri1ToolStripMenuItem.Click += new System.EventHandler(this.apri1ToolStripMenuItem_Click);
            // 
            // apri2ToolStripMenuItem
            // 
            this.apri2ToolStripMenuItem.Name = "apri2ToolStripMenuItem";
            this.apri2ToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.apri2ToolStripMenuItem.Text = "Apri &2";
            this.apri2ToolStripMenuItem.Click += new System.EventHandler(this.apri2ToolStripMenuItem_Click);
            // 
            // esciToolStripMenuItem
            // 
            this.esciToolStripMenuItem.Name = "esciToolStripMenuItem";
            this.esciToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.esciToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.esciToolStripMenuItem.Text = "Esci";
            this.esciToolStripMenuItem.Click += new System.EventHandler(this.esciToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "&Info";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "&?";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLbl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 476);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(811, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLbl
            // 
            this.toolStripStatusLbl.Name = "toolStripStatusLbl";
            this.toolStripStatusLbl.Size = new System.Drawing.Size(76, 17);
            this.toolStripStatusLbl.Text = "BENVENUTO:";
            // 
            // frmPadre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 498);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnFinestreAperte);
            this.Controls.Add(this.btnApriFiglia2);
            this.Controls.Add(this.bntApriFiglia1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPadre";
            this.Text = "Form Padre";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPadre_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntApriFiglia1;
        private System.Windows.Forms.Button btnApriFiglia2;
        private System.Windows.Forms.Button btnFinestreAperte;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menùToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apri1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apri2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLbl;
    }
}

