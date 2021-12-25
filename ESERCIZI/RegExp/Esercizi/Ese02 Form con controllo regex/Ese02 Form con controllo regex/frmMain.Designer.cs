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
            this.gbForm = new System.Windows.Forms.GroupBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCF = new System.Windows.Forms.TextBox();
            this.lblCF = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtCittà = new System.Windows.Forms.TextBox();
            this.lblCitta = new System.Windows.Forms.Label();
            this.txtCAP = new System.Windows.Forms.TextBox();
            this.lblCAP = new System.Windows.Forms.Label();
            this.txtEtà = new System.Windows.Forms.TextBox();
            this.lblEta = new System.Windows.Forms.Label();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.lblCognome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblTitolo = new System.Windows.Forms.Label();
            this.btnAvviaForm = new System.Windows.Forms.Button();
            this.btnInvia = new System.Windows.Forms.Button();
            this.menuStripMain.SuspendLayout();
            this.gbForm.SuspendLayout();
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
            // gbForm
            // 
            this.gbForm.Controls.Add(this.btnInvia);
            this.gbForm.Controls.Add(this.txtUserName);
            this.gbForm.Controls.Add(this.lblUserName);
            this.gbForm.Controls.Add(this.txtPwd);
            this.gbForm.Controls.Add(this.label7);
            this.gbForm.Controls.Add(this.txtCF);
            this.gbForm.Controls.Add(this.lblCF);
            this.gbForm.Controls.Add(this.txtMail);
            this.gbForm.Controls.Add(this.lblMail);
            this.gbForm.Controls.Add(this.txtCittà);
            this.gbForm.Controls.Add(this.lblCitta);
            this.gbForm.Controls.Add(this.txtCAP);
            this.gbForm.Controls.Add(this.lblCAP);
            this.gbForm.Controls.Add(this.txtEtà);
            this.gbForm.Controls.Add(this.lblEta);
            this.gbForm.Controls.Add(this.txtCognome);
            this.gbForm.Controls.Add(this.lblCognome);
            this.gbForm.Controls.Add(this.txtNome);
            this.gbForm.Controls.Add(this.lblNome);
            this.gbForm.Location = new System.Drawing.Point(225, 97);
            this.gbForm.Name = "gbForm";
            this.gbForm.Size = new System.Drawing.Size(501, 451);
            this.gbForm.TabIndex = 3;
            this.gbForm.TabStop = false;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(196, 290);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(174, 20);
            this.txtUserName.TabIndex = 17;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblUserName.Location = new System.Drawing.Point(48, 290);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(109, 22);
            this.lblUserName.TabIndex = 16;
            this.lblUserName.Text = "USER NAME:";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(196, 327);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(174, 20);
            this.txtPwd.TabIndex = 15;
            this.txtPwd.TextChanged += new System.EventHandler(this.txtPwd_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label7.Location = new System.Drawing.Point(52, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 22);
            this.label7.TabIndex = 14;
            this.label7.Text = "PASSWORD:";
            // 
            // txtCF
            // 
            this.txtCF.Location = new System.Drawing.Point(196, 258);
            this.txtCF.Name = "txtCF";
            this.txtCF.Size = new System.Drawing.Size(174, 20);
            this.txtCF.TabIndex = 13;
            this.txtCF.TextChanged += new System.EventHandler(this.txtCF_TextChanged);
            // 
            // lblCF
            // 
            this.lblCF.AutoSize = true;
            this.lblCF.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblCF.Location = new System.Drawing.Point(103, 258);
            this.lblCF.Name = "lblCF";
            this.lblCF.Size = new System.Drawing.Size(42, 22);
            this.lblCF.TabIndex = 12;
            this.lblCF.Text = "C.F:";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(196, 219);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(174, 20);
            this.txtMail.TabIndex = 11;
            this.txtMail.TextChanged += new System.EventHandler(this.txtMail_TextChanged);
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblMail.Location = new System.Drawing.Point(34, 216);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(123, 22);
            this.lblMail.TabIndex = 10;
            this.lblMail.Text = "ELENCO MAIL:";
            // 
            // txtCittà
            // 
            this.txtCittà.Location = new System.Drawing.Point(196, 181);
            this.txtCittà.Name = "txtCittà";
            this.txtCittà.Size = new System.Drawing.Size(174, 20);
            this.txtCittà.TabIndex = 9;
            this.txtCittà.TextChanged += new System.EventHandler(this.txtCittà_TextChanged);
            // 
            // lblCitta
            // 
            this.lblCitta.AutoSize = true;
            this.lblCitta.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblCitta.Location = new System.Drawing.Point(81, 181);
            this.lblCitta.Name = "lblCitta";
            this.lblCitta.Size = new System.Drawing.Size(72, 22);
            this.lblCitta.TabIndex = 8;
            this.lblCitta.Text = "CITTA\':";
            // 
            // txtCAP
            // 
            this.txtCAP.Location = new System.Drawing.Point(196, 142);
            this.txtCAP.Name = "txtCAP";
            this.txtCAP.Size = new System.Drawing.Size(174, 20);
            this.txtCAP.TabIndex = 7;
            this.txtCAP.TextChanged += new System.EventHandler(this.txtCAP_TextChanged);
            // 
            // lblCAP
            // 
            this.lblCAP.AutoSize = true;
            this.lblCAP.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblCAP.Location = new System.Drawing.Point(108, 142);
            this.lblCAP.Name = "lblCAP";
            this.lblCAP.Size = new System.Drawing.Size(45, 22);
            this.lblCAP.TabIndex = 6;
            this.lblCAP.Text = "CAP:";
            // 
            // txtEtà
            // 
            this.txtEtà.Location = new System.Drawing.Point(196, 106);
            this.txtEtà.Name = "txtEtà";
            this.txtEtà.Size = new System.Drawing.Size(174, 20);
            this.txtEtà.TabIndex = 5;
            this.txtEtà.TextChanged += new System.EventHandler(this.txtEtà_TextChanged);
            // 
            // lblEta
            // 
            this.lblEta.AutoSize = true;
            this.lblEta.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblEta.Location = new System.Drawing.Point(99, 106);
            this.lblEta.Name = "lblEta";
            this.lblEta.Size = new System.Drawing.Size(54, 22);
            this.lblEta.TabIndex = 4;
            this.lblEta.Text = "ETA\':";
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(196, 73);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(174, 20);
            this.txtCognome.TabIndex = 3;
            this.txtCognome.TextChanged += new System.EventHandler(this.txtCognome_TextChanged);
            // 
            // lblCognome
            // 
            this.lblCognome.AutoSize = true;
            this.lblCognome.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblCognome.Location = new System.Drawing.Point(63, 73);
            this.lblCognome.Name = "lblCognome";
            this.lblCognome.Size = new System.Drawing.Size(94, 22);
            this.lblCognome.TabIndex = 2;
            this.lblCognome.Text = "COGNOME:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(196, 40);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(174, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblNome.Location = new System.Drawing.Point(94, 40);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(63, 22);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "NOME:";
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
            // btnAvviaForm
            // 
            this.btnAvviaForm.Font = new System.Drawing.Font("Comic Sans MS", 15.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnAvviaForm.Location = new System.Drawing.Point(743, 248);
            this.btnAvviaForm.Name = "btnAvviaForm";
            this.btnAvviaForm.Size = new System.Drawing.Size(207, 76);
            this.btnAvviaForm.TabIndex = 0;
            this.btnAvviaForm.Text = "AVVIA FORM";
            this.btnAvviaForm.UseVisualStyleBackColor = true;
            this.btnAvviaForm.Click += new System.EventHandler(this.avviaForm_Click);
            // 
            // btnInvia
            // 
            this.btnInvia.Font = new System.Drawing.Font("Comic Sans MS", 15.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnInvia.Location = new System.Drawing.Point(147, 375);
            this.btnInvia.Name = "btnInvia";
            this.btnInvia.Size = new System.Drawing.Size(204, 51);
            this.btnInvia.TabIndex = 18;
            this.btnInvia.Text = "INVIA FORM";
            this.btnInvia.UseVisualStyleBackColor = true;
            this.btnInvia.Click += new System.EventHandler(this.btnInvia_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 560);
            this.Controls.Add(this.btnAvviaForm);
            this.Controls.Add(this.lblTitolo);
            this.Controls.Add(this.gbForm);
            this.Controls.Add(this.lblInizia);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "frmMain";
            this.Text = "FORM CON REGEX";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.gbForm.ResumeLayout(false);
            this.gbForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem avviaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem esciToolStripMenuItem;
        private System.Windows.Forms.Label lblInizia;
        private System.Windows.Forms.GroupBox gbForm;
        private System.Windows.Forms.Label lblTitolo;
        private System.Windows.Forms.Button btnAvviaForm;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCF;
        private System.Windows.Forms.Label lblCF;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtCittà;
        private System.Windows.Forms.Label lblCitta;
        private System.Windows.Forms.TextBox txtCAP;
        private System.Windows.Forms.Label lblCAP;
        private System.Windows.Forms.TextBox txtEtà;
        private System.Windows.Forms.Label lblEta;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.Label lblCognome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnInvia;
    }
}

