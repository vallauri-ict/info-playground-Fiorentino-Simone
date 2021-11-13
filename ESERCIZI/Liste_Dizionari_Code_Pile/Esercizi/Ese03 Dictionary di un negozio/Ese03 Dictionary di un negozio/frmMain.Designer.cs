namespace Ese03_Dictionary_di_un_negozio
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
            this.txtNomeArticolo = new System.Windows.Forms.TextBox();
            this.txtKeyArticolo = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblKey = new System.Windows.Forms.Label();
            this.btnInserisciArticolo = new System.Windows.Forms.Button();
            this.btnVisualizzaArticoli = new System.Windows.Forms.Button();
            this.vbtnRicercaWithKey = new System.Windows.Forms.Button();
            this.lblRisu = new System.Windows.Forms.Label();
            this.lblRisultato = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNomeArticolo
            // 
            this.txtNomeArticolo.Location = new System.Drawing.Point(196, 82);
            this.txtNomeArticolo.Name = "txtNomeArticolo";
            this.txtNomeArticolo.Size = new System.Drawing.Size(100, 20);
            this.txtNomeArticolo.TabIndex = 0;
            // 
            // txtKeyArticolo
            // 
            this.txtKeyArticolo.Location = new System.Drawing.Point(196, 124);
            this.txtKeyArticolo.Name = "txtKeyArticolo";
            this.txtKeyArticolo.Size = new System.Drawing.Size(100, 20);
            this.txtKeyArticolo.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblNome.Location = new System.Drawing.Point(31, 81);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(146, 18);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "NOME ARTICOLO";
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblKey.Location = new System.Drawing.Point(34, 123);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(128, 18);
            this.lblKey.TabIndex = 3;
            this.lblKey.Text = "KEY ARTICOLO";
            // 
            // btnInserisciArticolo
            // 
            this.btnInserisciArticolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserisciArticolo.Location = new System.Drawing.Point(374, 64);
            this.btnInserisciArticolo.Name = "btnInserisciArticolo";
            this.btnInserisciArticolo.Size = new System.Drawing.Size(172, 55);
            this.btnInserisciArticolo.TabIndex = 5;
            this.btnInserisciArticolo.Text = "INSERISCI ARTICOLO";
            this.btnInserisciArticolo.UseVisualStyleBackColor = true;
            this.btnInserisciArticolo.Click += new System.EventHandler(this.btnInserisciArticolo_Click);
            // 
            // btnVisualizzaArticoli
            // 
            this.btnVisualizzaArticoli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnVisualizzaArticoli.Location = new System.Drawing.Point(374, 150);
            this.btnVisualizzaArticoli.Name = "btnVisualizzaArticoli";
            this.btnVisualizzaArticoli.Size = new System.Drawing.Size(172, 55);
            this.btnVisualizzaArticoli.TabIndex = 6;
            this.btnVisualizzaArticoli.Text = "VISUALIZZA INSERIMENTI";
            this.btnVisualizzaArticoli.UseVisualStyleBackColor = true;
            this.btnVisualizzaArticoli.Click += new System.EventHandler(this.btnVisualizzaArticoli_Click);
            // 
            // vbtnRicercaWithKey
            // 
            this.vbtnRicercaWithKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.vbtnRicercaWithKey.Location = new System.Drawing.Point(374, 253);
            this.vbtnRicercaWithKey.Name = "vbtnRicercaWithKey";
            this.vbtnRicercaWithKey.Size = new System.Drawing.Size(172, 55);
            this.vbtnRicercaWithKey.TabIndex = 7;
            this.vbtnRicercaWithKey.Text = "RICERCA ARTICOLO IN BASE ALLA CHIAVE";
            this.vbtnRicercaWithKey.UseVisualStyleBackColor = true;
            this.vbtnRicercaWithKey.Click += new System.EventHandler(this.vbtnRicercaWithKey_Click);
            // 
            // lblRisu
            // 
            this.lblRisu.AutoSize = true;
            this.lblRisu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRisu.Location = new System.Drawing.Point(34, 192);
            this.lblRisu.Name = "lblRisu";
            this.lblRisu.Size = new System.Drawing.Size(109, 18);
            this.lblRisu.TabIndex = 8;
            this.lblRisu.Text = "RISULTATO: ";
            // 
            // lblRisultato
            // 
            this.lblRisultato.AutoSize = true;
            this.lblRisultato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRisultato.Location = new System.Drawing.Point(161, 192);
            this.lblRisultato.Name = "lblRisultato";
            this.lblRisultato.Size = new System.Drawing.Size(0, 20);
            this.lblRisultato.TabIndex = 9;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 354);
            this.Controls.Add(this.lblRisultato);
            this.Controls.Add(this.lblRisu);
            this.Controls.Add(this.vbtnRicercaWithKey);
            this.Controls.Add(this.btnVisualizzaArticoli);
            this.Controls.Add(this.btnInserisciArticolo);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtKeyArticolo);
            this.Controls.Add(this.txtNomeArticolo);
            this.Name = "frmMain";
            this.Text = "DICTIONARY NEGOZIO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeArticolo;
        private System.Windows.Forms.TextBox txtKeyArticolo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.Button btnInserisciArticolo;
        private System.Windows.Forms.Button btnVisualizzaArticoli;
        private System.Windows.Forms.Button vbtnRicercaWithKey;
        private System.Windows.Forms.Label lblRisu;
        private System.Windows.Forms.Label lblRisultato;
    }
}

