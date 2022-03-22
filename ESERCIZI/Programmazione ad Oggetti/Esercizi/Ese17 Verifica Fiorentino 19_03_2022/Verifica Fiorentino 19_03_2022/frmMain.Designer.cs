namespace Verifica_Fiorentino_19_03_2022
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
            this.gbPianta = new System.Windows.Forms.GroupBox();
            this.txtCostoPianta = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAggiungiPianta = new System.Windows.Forms.Button();
            this.txtColore = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbGenerePianta = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTipoPianta = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescrizionePianta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCostoRosa = new System.Windows.Forms.TextBox();
            this.btnAggiungiRosa = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbGenereRosa = new System.Windows.Forms.ComboBox();
            this.cmbTipoRosa = new System.Windows.Forms.ComboBox();
            this.txtVarietà = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescrizioneRosa = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnVisualizzaListaPianta = new System.Windows.Forms.Button();
            this.btnVisualizzaListaRosa = new System.Windows.Forms.Button();
            this.lstPianta = new System.Windows.Forms.ListBox();
            this.lstRosa = new System.Windows.Forms.ListBox();
            this.btnVenditaUltimaPianta = new System.Windows.Forms.Button();
            this.btnVenditaPiantaLst = new System.Windows.Forms.Button();
            this.btnVenditaRosaList = new System.Windows.Forms.Button();
            this.btnVenditaUltimaRosa = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.nupQuantità = new System.Windows.Forms.NumericUpDown();
            this.gbPianta.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupQuantità)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPianta
            // 
            this.gbPianta.Controls.Add(this.txtCostoPianta);
            this.gbPianta.Controls.Add(this.label10);
            this.gbPianta.Controls.Add(this.btnAggiungiPianta);
            this.gbPianta.Controls.Add(this.txtColore);
            this.gbPianta.Controls.Add(this.label4);
            this.gbPianta.Controls.Add(this.cmbGenerePianta);
            this.gbPianta.Controls.Add(this.label3);
            this.gbPianta.Controls.Add(this.cmbTipoPianta);
            this.gbPianta.Controls.Add(this.label2);
            this.gbPianta.Controls.Add(this.txtDescrizionePianta);
            this.gbPianta.Controls.Add(this.label1);
            this.gbPianta.Location = new System.Drawing.Point(53, 110);
            this.gbPianta.Name = "gbPianta";
            this.gbPianta.Size = new System.Drawing.Size(305, 269);
            this.gbPianta.TabIndex = 0;
            this.gbPianta.TabStop = false;
            this.gbPianta.Text = "PIANTA";
            // 
            // txtCostoPianta
            // 
            this.txtCostoPianta.Location = new System.Drawing.Point(113, 184);
            this.txtCostoPianta.Name = "txtCostoPianta";
            this.txtCostoPianta.Size = new System.Drawing.Size(165, 22);
            this.txtCostoPianta.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 184);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "COSTO:";
            // 
            // btnAggiungiPianta
            // 
            this.btnAggiungiPianta.Location = new System.Drawing.Point(97, 212);
            this.btnAggiungiPianta.Name = "btnAggiungiPianta";
            this.btnAggiungiPianta.Size = new System.Drawing.Size(107, 50);
            this.btnAggiungiPianta.TabIndex = 8;
            this.btnAggiungiPianta.Text = "AGGIUNGI PIANTA";
            this.btnAggiungiPianta.UseVisualStyleBackColor = true;
            this.btnAggiungiPianta.Click += new System.EventHandler(this.btnAggiungiPianta_Click);
            // 
            // txtColore
            // 
            this.txtColore.Location = new System.Drawing.Point(114, 149);
            this.txtColore.Name = "txtColore";
            this.txtColore.Size = new System.Drawing.Size(164, 22);
            this.txtColore.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "COLORE:";
            // 
            // cmbGenerePianta
            // 
            this.cmbGenerePianta.FormattingEnabled = true;
            this.cmbGenerePianta.Items.AddRange(new object[] {
            "COLORATA",
            "SEMPREVERDE"});
            this.cmbGenerePianta.Location = new System.Drawing.Point(114, 110);
            this.cmbGenerePianta.Name = "cmbGenerePianta";
            this.cmbGenerePianta.Size = new System.Drawing.Size(164, 24);
            this.cmbGenerePianta.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "GENERE:";
            // 
            // cmbTipoPianta
            // 
            this.cmbTipoPianta.FormattingEnabled = true;
            this.cmbTipoPianta.Items.AddRange(new object[] {
            "EUROPEA",
            "ESOTICA",
            "CARNIVORA"});
            this.cmbTipoPianta.Location = new System.Drawing.Point(114, 72);
            this.cmbTipoPianta.Name = "cmbTipoPianta";
            this.cmbTipoPianta.Size = new System.Drawing.Size(164, 24);
            this.cmbTipoPianta.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "TIPO: ";
            // 
            // txtDescrizionePianta
            // 
            this.txtDescrizionePianta.Location = new System.Drawing.Point(113, 35);
            this.txtDescrizionePianta.Name = "txtDescrizionePianta";
            this.txtDescrizionePianta.Size = new System.Drawing.Size(165, 22);
            this.txtDescrizionePianta.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "DESCRIZIONE:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nupQuantità);
            this.groupBox1.Controls.Add(this.txtCostoRosa);
            this.groupBox1.Controls.Add(this.btnAggiungiRosa);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cmbGenereRosa);
            this.groupBox1.Controls.Add(this.cmbTipoRosa);
            this.groupBox1.Controls.Add(this.txtVarietà);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtDescrizioneRosa);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(388, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 263);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ROSA";
            // 
            // txtCostoRosa
            // 
            this.txtCostoRosa.Location = new System.Drawing.Point(113, 184);
            this.txtCostoRosa.Name = "txtCostoRosa";
            this.txtCostoRosa.Size = new System.Drawing.Size(175, 22);
            this.txtCostoRosa.TabIndex = 12;
            // 
            // btnAggiungiRosa
            // 
            this.btnAggiungiRosa.Location = new System.Drawing.Point(9, 213);
            this.btnAggiungiRosa.Name = "btnAggiungiRosa";
            this.btnAggiungiRosa.Size = new System.Drawing.Size(107, 50);
            this.btnAggiungiRosa.TabIndex = 9;
            this.btnAggiungiRosa.Text = "AGGIUNGI ROSA";
            this.btnAggiungiRosa.UseVisualStyleBackColor = true;
            this.btnAggiungiRosa.Click += new System.EventHandler(this.btnAggiungiRosa_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 184);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 16);
            this.label11.TabIndex = 11;
            this.label11.Text = "COSTO:";
            // 
            // cmbGenereRosa
            // 
            this.cmbGenereRosa.FormattingEnabled = true;
            this.cmbGenereRosa.Items.AddRange(new object[] {
            "COLORATA",
            "SEMPREVERDE"});
            this.cmbGenereRosa.Location = new System.Drawing.Point(113, 110);
            this.cmbGenereRosa.Name = "cmbGenereRosa";
            this.cmbGenereRosa.Size = new System.Drawing.Size(175, 24);
            this.cmbGenereRosa.TabIndex = 8;
            // 
            // cmbTipoRosa
            // 
            this.cmbTipoRosa.FormattingEnabled = true;
            this.cmbTipoRosa.Items.AddRange(new object[] {
            "EUROPEA",
            "ESOTICA",
            "CARNIVORA"});
            this.cmbTipoRosa.Location = new System.Drawing.Point(113, 69);
            this.cmbTipoRosa.Name = "cmbTipoRosa";
            this.cmbTipoRosa.Size = new System.Drawing.Size(175, 24);
            this.cmbTipoRosa.TabIndex = 8;
            // 
            // txtVarietà
            // 
            this.txtVarietà.Location = new System.Drawing.Point(114, 149);
            this.txtVarietà.Name = "txtVarietà";
            this.txtVarietà.Size = new System.Drawing.Size(174, 22);
            this.txtVarietà.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "VARIETA\': ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "GENERE:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "TIPO: ";
            // 
            // txtDescrizioneRosa
            // 
            this.txtDescrizioneRosa.Location = new System.Drawing.Point(113, 35);
            this.txtDescrizioneRosa.Name = "txtDescrizioneRosa";
            this.txtDescrizioneRosa.Size = new System.Drawing.Size(175, 22);
            this.txtDescrizioneRosa.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "DESCRIZIONE:";
            // 
            // btnVisualizzaListaPianta
            // 
            this.btnVisualizzaListaPianta.Location = new System.Drawing.Point(63, 385);
            this.btnVisualizzaListaPianta.Name = "btnVisualizzaListaPianta";
            this.btnVisualizzaListaPianta.Size = new System.Drawing.Size(125, 58);
            this.btnVisualizzaListaPianta.TabIndex = 9;
            this.btnVisualizzaListaPianta.Text = "VISUALIZZA LISTA PIANTA";
            this.btnVisualizzaListaPianta.UseVisualStyleBackColor = true;
            this.btnVisualizzaListaPianta.Click += new System.EventHandler(this.btnVisualizzaListaPianta_Click);
            // 
            // btnVisualizzaListaRosa
            // 
            this.btnVisualizzaListaRosa.Location = new System.Drawing.Point(211, 385);
            this.btnVisualizzaListaRosa.Name = "btnVisualizzaListaRosa";
            this.btnVisualizzaListaRosa.Size = new System.Drawing.Size(125, 58);
            this.btnVisualizzaListaRosa.TabIndex = 10;
            this.btnVisualizzaListaRosa.Text = "VISUALIZZA LISTA ROSA";
            this.btnVisualizzaListaRosa.UseVisualStyleBackColor = true;
            this.btnVisualizzaListaRosa.Click += new System.EventHandler(this.btnVisualizzaListaRosa_Click);
            // 
            // lstPianta
            // 
            this.lstPianta.FormattingEnabled = true;
            this.lstPianta.ItemHeight = 16;
            this.lstPianta.Location = new System.Drawing.Point(63, 450);
            this.lstPianta.Name = "lstPianta";
            this.lstPianta.Size = new System.Drawing.Size(120, 132);
            this.lstPianta.TabIndex = 11;
            // 
            // lstRosa
            // 
            this.lstRosa.FormattingEnabled = true;
            this.lstRosa.ItemHeight = 16;
            this.lstRosa.Location = new System.Drawing.Point(211, 450);
            this.lstRosa.Name = "lstRosa";
            this.lstRosa.Size = new System.Drawing.Size(120, 132);
            this.lstRosa.TabIndex = 12;
            // 
            // btnVenditaUltimaPianta
            // 
            this.btnVenditaUltimaPianta.Location = new System.Drawing.Point(414, 413);
            this.btnVenditaUltimaPianta.Name = "btnVenditaUltimaPianta";
            this.btnVenditaUltimaPianta.Size = new System.Drawing.Size(150, 58);
            this.btnVenditaUltimaPianta.TabIndex = 13;
            this.btnVenditaUltimaPianta.Text = "VENDITA DELL\'ULTIMA PIANTA";
            this.btnVenditaUltimaPianta.UseVisualStyleBackColor = true;
            this.btnVenditaUltimaPianta.Click += new System.EventHandler(this.btnVenditaUltimaPianta_Click);
            // 
            // btnVenditaPiantaLst
            // 
            this.btnVenditaPiantaLst.Location = new System.Drawing.Point(570, 413);
            this.btnVenditaPiantaLst.Name = "btnVenditaPiantaLst";
            this.btnVenditaPiantaLst.Size = new System.Drawing.Size(96, 58);
            this.btnVenditaPiantaLst.TabIndex = 14;
            this.btnVenditaPiantaLst.Text = "VENDITA PIANTA LISTBOX";
            this.btnVenditaPiantaLst.UseVisualStyleBackColor = true;
            this.btnVenditaPiantaLst.Click += new System.EventHandler(this.btnVenditaPiantaLst_Click);
            // 
            // btnVenditaRosaList
            // 
            this.btnVenditaRosaList.Location = new System.Drawing.Point(570, 490);
            this.btnVenditaRosaList.Name = "btnVenditaRosaList";
            this.btnVenditaRosaList.Size = new System.Drawing.Size(96, 58);
            this.btnVenditaRosaList.TabIndex = 16;
            this.btnVenditaRosaList.Text = "VENDITA ROSA LISTBOX";
            this.btnVenditaRosaList.UseVisualStyleBackColor = true;
            this.btnVenditaRosaList.Click += new System.EventHandler(this.btnVenditaRosaList_Click);
            // 
            // btnVenditaUltimaRosa
            // 
            this.btnVenditaUltimaRosa.Location = new System.Drawing.Point(414, 490);
            this.btnVenditaUltimaRosa.Name = "btnVenditaUltimaRosa";
            this.btnVenditaUltimaRosa.Size = new System.Drawing.Size(150, 58);
            this.btnVenditaUltimaRosa.TabIndex = 15;
            this.btnVenditaUltimaRosa.Text = "VENDITA DELL\'ULTIMA ROSA";
            this.btnVenditaUltimaRosa.UseVisualStyleBackColor = true;
            this.btnVenditaUltimaRosa.Click += new System.EventHandler(this.btnVenditaUltimaRosa_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(239, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(274, 32);
            this.label9.TabIndex = 17;
            this.label9.Text = "GESTIONE VIVAIO";
            // 
            // nupQuantità
            // 
            this.nupQuantità.Location = new System.Drawing.Point(158, 227);
            this.nupQuantità.Name = "nupQuantità";
            this.nupQuantità.Size = new System.Drawing.Size(120, 22);
            this.nupQuantità.TabIndex = 13;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 610);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnVenditaRosaList);
            this.Controls.Add(this.btnVenditaUltimaRosa);
            this.Controls.Add(this.btnVenditaPiantaLst);
            this.Controls.Add(this.btnVenditaUltimaPianta);
            this.Controls.Add(this.lstRosa);
            this.Controls.Add(this.lstPianta);
            this.Controls.Add(this.btnVisualizzaListaRosa);
            this.Controls.Add(this.btnVisualizzaListaPianta);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbPianta);
            this.Name = "frmMain";
            this.Text = "VERIFICA FIORENTINO";
            this.gbPianta.ResumeLayout(false);
            this.gbPianta.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupQuantità)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPianta;
        private System.Windows.Forms.ComboBox cmbGenerePianta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTipoPianta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescrizionePianta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtColore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtVarietà;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDescrizioneRosa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbTipoRosa;
        private System.Windows.Forms.ComboBox cmbGenereRosa;
        private System.Windows.Forms.Button btnAggiungiPianta;
        private System.Windows.Forms.Button btnAggiungiRosa;
        private System.Windows.Forms.Button btnVisualizzaListaPianta;
        private System.Windows.Forms.Button btnVisualizzaListaRosa;
        private System.Windows.Forms.ListBox lstPianta;
        private System.Windows.Forms.ListBox lstRosa;
        private System.Windows.Forms.Button btnVenditaUltimaPianta;
        private System.Windows.Forms.Button btnVenditaPiantaLst;
        private System.Windows.Forms.Button btnVenditaRosaList;
        private System.Windows.Forms.Button btnVenditaUltimaRosa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCostoPianta;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCostoRosa;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nupQuantità;
    }
}

