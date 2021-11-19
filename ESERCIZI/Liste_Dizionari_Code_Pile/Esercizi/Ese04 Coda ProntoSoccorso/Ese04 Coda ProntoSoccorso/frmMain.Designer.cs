namespace Ese04_Coda_ProntoSoccorso
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
            this.lblRisultato = new System.Windows.Forms.Label();
            this.lblInserimentoRis = new System.Windows.Forms.Label();
            this.cmbColore = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEtà = new System.Windows.Forms.TextBox();
            this.nupTemperatura = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInserisciPaziente = new System.Windows.Forms.Button();
            this.btnGestisciPazienti = new System.Windows.Forms.Button();
            this.btnResocontoTemp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nupTemperatura)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRisultato
            // 
            this.lblRisultato.AutoSize = true;
            this.lblRisultato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblRisultato.Location = new System.Drawing.Point(28, 170);
            this.lblRisultato.Name = "lblRisultato";
            this.lblRisultato.Size = new System.Drawing.Size(118, 20);
            this.lblRisultato.TabIndex = 0;
            this.lblRisultato.Text = "RISULTATO: ";
            // 
            // lblInserimentoRis
            // 
            this.lblInserimentoRis.AutoSize = true;
            this.lblInserimentoRis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInserimentoRis.Location = new System.Drawing.Point(182, 170);
            this.lblInserimentoRis.Name = "lblInserimentoRis";
            this.lblInserimentoRis.Size = new System.Drawing.Size(0, 18);
            this.lblInserimentoRis.TabIndex = 1;
            // 
            // cmbColore
            // 
            this.cmbColore.FormattingEnabled = true;
            this.cmbColore.Items.AddRange(new object[] {
            "Rosso (Urgentissimo)",
            "Giallo (Grave)",
            "Verde (Moderato)",
            "Bianco (Lieve)"});
            this.cmbColore.Location = new System.Drawing.Point(134, 77);
            this.cmbColore.Name = "cmbColore";
            this.cmbColore.Size = new System.Drawing.Size(121, 21);
            this.cmbColore.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(28, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "NOME:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(134, 15);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(28, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "ETA\':";
            // 
            // txtEtà
            // 
            this.txtEtà.Location = new System.Drawing.Point(134, 44);
            this.txtEtà.Name = "txtEtà";
            this.txtEtà.Size = new System.Drawing.Size(100, 20);
            this.txtEtà.TabIndex = 9;
            // 
            // nupTemperatura
            // 
            this.nupTemperatura.DecimalPlaces = 2;
            this.nupTemperatura.Increment = new decimal(new int[] {
            20,
            0,
            0,
            131072});
            this.nupTemperatura.Location = new System.Drawing.Point(190, 124);
            this.nupTemperatura.Maximum = new decimal(new int[] {
            43,
            0,
            0,
            0});
            this.nupTemperatura.Minimum = new decimal(new int[] {
            37,
            0,
            0,
            0});
            this.nupTemperatura.Name = "nupTemperatura";
            this.nupTemperatura.Size = new System.Drawing.Size(120, 20);
            this.nupTemperatura.TabIndex = 10;
            this.nupTemperatura.Value = new decimal(new int[] {
            37,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(28, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "COLORE:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "TEMPERATURA:";
            // 
            // btnInserisciPaziente
            // 
            this.btnInserisciPaziente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserisciPaziente.Location = new System.Drawing.Point(48, 288);
            this.btnInserisciPaziente.Name = "btnInserisciPaziente";
            this.btnInserisciPaziente.Size = new System.Drawing.Size(128, 61);
            this.btnInserisciPaziente.TabIndex = 12;
            this.btnInserisciPaziente.Text = "INSERISCI PAZIENTE";
            this.btnInserisciPaziente.UseVisualStyleBackColor = true;
            this.btnInserisciPaziente.Click += new System.EventHandler(this.btnInserisciPaziente_Click);
            // 
            // btnGestisciPazienti
            // 
            this.btnGestisciPazienti.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestisciPazienti.Location = new System.Drawing.Point(182, 288);
            this.btnGestisciPazienti.Name = "btnGestisciPazienti";
            this.btnGestisciPazienti.Size = new System.Drawing.Size(128, 61);
            this.btnGestisciPazienti.TabIndex = 13;
            this.btnGestisciPazienti.Text = "GESTISCI PAZIENTI";
            this.btnGestisciPazienti.UseVisualStyleBackColor = true;
            this.btnGestisciPazienti.Click += new System.EventHandler(this.btnGestisciPazienti_Click);
            // 
            // btnResocontoTemp
            // 
            this.btnResocontoTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResocontoTemp.Location = new System.Drawing.Point(316, 288);
            this.btnResocontoTemp.Name = "btnResocontoTemp";
            this.btnResocontoTemp.Size = new System.Drawing.Size(145, 61);
            this.btnResocontoTemp.TabIndex = 14;
            this.btnResocontoTemp.Text = "RESOCONTO TEMPERATURE";
            this.btnResocontoTemp.UseVisualStyleBackColor = true;
            this.btnResocontoTemp.Click += new System.EventHandler(this.btnResocontoTemp_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(504, 390);
            this.Controls.Add(this.btnResocontoTemp);
            this.Controls.Add(this.btnGestisciPazienti);
            this.Controls.Add(this.btnInserisciPaziente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nupTemperatura);
            this.Controls.Add(this.txtEtà);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbColore);
            this.Controls.Add(this.lblInserimentoRis);
            this.Controls.Add(this.lblRisultato);
            this.Name = "frmMain";
            this.Text = "PRONTO SOCCORSO";
            ((System.ComponentModel.ISupportInitialize)(this.nupTemperatura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRisultato;
        private System.Windows.Forms.Label lblInserimentoRis;
        private System.Windows.Forms.ComboBox cmbColore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEtà;
        private System.Windows.Forms.NumericUpDown nupTemperatura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnInserisciPaziente;
        private System.Windows.Forms.Button btnGestisciPazienti;
        private System.Windows.Forms.Button btnResocontoTemp;
    }
}

