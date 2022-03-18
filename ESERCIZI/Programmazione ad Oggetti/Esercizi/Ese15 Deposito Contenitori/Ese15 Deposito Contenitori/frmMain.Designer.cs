namespace Ese15_Deposito_Contenitori
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFiltra = new System.Windows.Forms.Button();
            this.txtCampione = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIndice2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnConfronta = new System.Windows.Forms.Button();
            this.txtIndice1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnElenco = new System.Windows.Forms.Button();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.NupQta = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLiquido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NupQta)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFiltra);
            this.groupBox1.Controls.Add(this.txtCampione);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtIndice2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnConfronta);
            this.groupBox1.Controls.Add(this.txtIndice1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnElenco);
            this.groupBox1.Controls.Add(this.btnAggiungi);
            this.groupBox1.Controls.Add(this.NupQta);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtLiquido);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbTipo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(107, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 369);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CONTENITORE";
            // 
            // btnFiltra
            // 
            this.btnFiltra.Location = new System.Drawing.Point(268, 290);
            this.btnFiltra.Name = "btnFiltra";
            this.btnFiltra.Size = new System.Drawing.Size(116, 48);
            this.btnFiltra.TabIndex = 18;
            this.btnFiltra.Text = "FILTRA CONTENITORI";
            this.btnFiltra.UseVisualStyleBackColor = true;
            this.btnFiltra.Click += new System.EventHandler(this.btnFiltra_Click);
            // 
            // txtCampione
            // 
            this.txtCampione.Location = new System.Drawing.Point(105, 318);
            this.txtCampione.Name = "txtCampione";
            this.txtCampione.Size = new System.Drawing.Size(138, 20);
            this.txtCampione.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "CAMPIONE: ";
            // 
            // txtIndice2
            // 
            this.txtIndice2.Location = new System.Drawing.Point(182, 253);
            this.txtIndice2.Name = "txtIndice2";
            this.txtIndice2.Size = new System.Drawing.Size(138, 20);
            this.txtIndice2.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "SECONDO CONTENITORE: ";
            // 
            // btnConfronta
            // 
            this.btnConfronta.Location = new System.Drawing.Point(344, 221);
            this.btnConfronta.Name = "btnConfronta";
            this.btnConfronta.Size = new System.Drawing.Size(116, 48);
            this.btnConfronta.TabIndex = 13;
            this.btnConfronta.Text = "COMPARA CONTENITORI";
            this.btnConfronta.UseVisualStyleBackColor = true;
            this.btnConfronta.Click += new System.EventHandler(this.btnConfronta_Click);
            // 
            // txtIndice1
            // 
            this.txtIndice1.Location = new System.Drawing.Point(182, 221);
            this.txtIndice1.Name = "txtIndice1";
            this.txtIndice1.Size = new System.Drawing.Size(138, 20);
            this.txtIndice1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "PRIMO CONTENITORE: ";
            // 
            // btnElenco
            // 
            this.btnElenco.Location = new System.Drawing.Point(282, 149);
            this.btnElenco.Name = "btnElenco";
            this.btnElenco.Size = new System.Drawing.Size(116, 48);
            this.btnElenco.TabIndex = 10;
            this.btnElenco.Text = "ELENCO CONTENITORI";
            this.btnElenco.UseVisualStyleBackColor = true;
            this.btnElenco.Click += new System.EventHandler(this.btnElenco_Click);
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.Location = new System.Drawing.Point(105, 149);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(116, 48);
            this.btnAggiungi.TabIndex = 9;
            this.btnAggiungi.Text = "AGGIUNGI CONTENITORE";
            this.btnAggiungi.UseVisualStyleBackColor = true;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // NupQta
            // 
            this.NupQta.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NupQta.Location = new System.Drawing.Point(228, 108);
            this.NupQta.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NupQta.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.NupQta.Name = "NupQta";
            this.NupQta.Size = new System.Drawing.Size(170, 20);
            this.NupQta.TabIndex = 8;
            this.NupQta.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "QUANTITA\':";
            // 
            // txtLiquido
            // 
            this.txtLiquido.Location = new System.Drawing.Point(228, 69);
            this.txtLiquido.Name = "txtLiquido";
            this.txtLiquido.Size = new System.Drawing.Size(170, 20);
            this.txtLiquido.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "LIQUIDO:";
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "LATTINE",
            "BIDONE"});
            this.cmbTipo.Location = new System.Drawing.Point(228, 34);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(170, 21);
            this.cmbTipo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "TIPOLOGIA: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(211, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(294, 25);
            this.label7.TabIndex = 3;
            this.label7.Text = "DEPOSITO CONTENITORI:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 470);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.Text = "DEPOSITO CONTENITORE";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NupQta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown NupQta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLiquido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.Button btnElenco;
        private System.Windows.Forms.TextBox txtIndice1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfronta;
        private System.Windows.Forms.TextBox txtIndice2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnFiltra;
        private System.Windows.Forms.TextBox txtCampione;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

