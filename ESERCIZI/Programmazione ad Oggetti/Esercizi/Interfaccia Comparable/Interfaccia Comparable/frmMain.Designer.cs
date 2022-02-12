namespace Interfaccia_Comparable
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEtà = new System.Windows.Forms.TextBox();
            this.btnInserisci = new System.Windows.Forms.Button();
            this.btnElenca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(373, 44);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 22);
            this.txtNome.TabIndex = 0;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(270, 50);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(53, 16);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "NOME: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "COGNOME:";
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(373, 82);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(100, 22);
            this.txtCognome.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "ETA\': ";
            // 
            // txtEtà
            // 
            this.txtEtà.Location = new System.Drawing.Point(373, 123);
            this.txtEtà.Name = "txtEtà";
            this.txtEtà.Size = new System.Drawing.Size(100, 22);
            this.txtEtà.TabIndex = 4;
            // 
            // btnInserisci
            // 
            this.btnInserisci.Location = new System.Drawing.Point(175, 182);
            this.btnInserisci.Name = "btnInserisci";
            this.btnInserisci.Size = new System.Drawing.Size(118, 73);
            this.btnInserisci.TabIndex = 6;
            this.btnInserisci.Text = "INSERISCI";
            this.btnInserisci.UseVisualStyleBackColor = true;
            this.btnInserisci.Click += new System.EventHandler(this.btnInserisci_Click);
            // 
            // btnElenca
            // 
            this.btnElenca.Location = new System.Drawing.Point(468, 182);
            this.btnElenca.Name = "btnElenca";
            this.btnElenca.Size = new System.Drawing.Size(118, 73);
            this.btnElenca.TabIndex = 7;
            this.btnElenca.Text = "ELENCA";
            this.btnElenca.UseVisualStyleBackColor = true;
            this.btnElenca.Click += new System.EventHandler(this.btnElenca_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnElenca);
            this.Controls.Add(this.btnInserisci);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEtà);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCognome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Name = "frmMain";
            this.Text = "INTERFACCIA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEtà;
        private System.Windows.Forms.Button btnInserisci;
        private System.Windows.Forms.Button btnElenca;
    }
}

