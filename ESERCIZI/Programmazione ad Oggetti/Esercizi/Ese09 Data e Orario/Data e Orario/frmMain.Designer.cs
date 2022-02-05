namespace Data_e_Orario
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
            this.gbData = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreaData = new System.Windows.Forms.Button();
            this.btnCreaDataConParametri = new System.Windows.Forms.Button();
            this.btnToString = new System.Windows.Forms.Button();
            this.btnBisestile = new System.Windows.Forms.Button();
            this.btnLeggiData = new System.Windows.Forms.Button();
            this.btnScriviData = new System.Windows.Forms.Button();
            this.btnDomani = new System.Windows.Forms.Button();
            this.btnDecrementa = new System.Windows.Forms.Button();
            this.btnConosciGiorno = new System.Windows.Forms.Button();
            this.gbDataEOra = new System.Windows.Forms.GroupBox();
            this.btnToStringDataEOra = new System.Windows.Forms.Button();
            this.btnCreaDataEOra = new System.Windows.Forms.Button();
            this.btnCreaOraConParametri = new System.Windows.Forms.Button();
            this.btnCreaOra = new System.Windows.Forms.Button();
            this.btnScriviDataEOra = new System.Windows.Forms.Button();
            this.btnLeggiDataEOra = new System.Windows.Forms.Button();
            this.gbData.SuspendLayout();
            this.gbDataEOra.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbData
            // 
            this.gbData.Controls.Add(this.btnConosciGiorno);
            this.gbData.Controls.Add(this.btnDecrementa);
            this.gbData.Controls.Add(this.btnDomani);
            this.gbData.Controls.Add(this.btnScriviData);
            this.gbData.Controls.Add(this.btnLeggiData);
            this.gbData.Controls.Add(this.btnBisestile);
            this.gbData.Controls.Add(this.btnToString);
            this.gbData.Controls.Add(this.btnCreaDataConParametri);
            this.gbData.Controls.Add(this.btnCreaData);
            this.gbData.Location = new System.Drawing.Point(296, 98);
            this.gbData.Name = "gbData";
            this.gbData.Size = new System.Drawing.Size(832, 308);
            this.gbData.TabIndex = 0;
            this.gbData.TabStop = false;
            this.gbData.Text = "DATA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(519, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "CALENDARIO GREGORIANO";
            // 
            // btnCreaData
            // 
            this.btnCreaData.Location = new System.Drawing.Point(61, 33);
            this.btnCreaData.Name = "btnCreaData";
            this.btnCreaData.Size = new System.Drawing.Size(163, 73);
            this.btnCreaData.TabIndex = 0;
            this.btnCreaData.Text = "CREA DATA (NO-PARAMETRI)";
            this.btnCreaData.UseVisualStyleBackColor = true;
            this.btnCreaData.Click += new System.EventHandler(this.btnCreaData_Click);
            // 
            // btnCreaDataConParametri
            // 
            this.btnCreaDataConParametri.Location = new System.Drawing.Point(241, 33);
            this.btnCreaDataConParametri.Name = "btnCreaDataConParametri";
            this.btnCreaDataConParametri.Size = new System.Drawing.Size(163, 73);
            this.btnCreaDataConParametri.TabIndex = 1;
            this.btnCreaDataConParametri.Text = "CREA DATA (CON PARAMETRI)";
            this.btnCreaDataConParametri.UseVisualStyleBackColor = true;
            this.btnCreaDataConParametri.Click += new System.EventHandler(this.btnCreaDataConParametri_Click);
            // 
            // btnToString
            // 
            this.btnToString.Location = new System.Drawing.Point(420, 33);
            this.btnToString.Name = "btnToString";
            this.btnToString.Size = new System.Drawing.Size(163, 73);
            this.btnToString.TabIndex = 2;
            this.btnToString.Text = "TO STRING SULLA DATA";
            this.btnToString.UseVisualStyleBackColor = true;
            this.btnToString.Click += new System.EventHandler(this.btnToString_Click);
            // 
            // btnBisestile
            // 
            this.btnBisestile.Location = new System.Drawing.Point(605, 33);
            this.btnBisestile.Name = "btnBisestile";
            this.btnBisestile.Size = new System.Drawing.Size(163, 73);
            this.btnBisestile.TabIndex = 3;
            this.btnBisestile.Text = "CONTROLLA SE BISESTILE";
            this.btnBisestile.UseVisualStyleBackColor = true;
            this.btnBisestile.Click += new System.EventHandler(this.btnBisestile_Click);
            // 
            // btnLeggiData
            // 
            this.btnLeggiData.Location = new System.Drawing.Point(61, 122);
            this.btnLeggiData.Name = "btnLeggiData";
            this.btnLeggiData.Size = new System.Drawing.Size(163, 73);
            this.btnLeggiData.TabIndex = 4;
            this.btnLeggiData.Text = "LEGGI DATA";
            this.btnLeggiData.UseVisualStyleBackColor = true;
            this.btnLeggiData.Click += new System.EventHandler(this.btnLeggiData_Click);
            // 
            // btnScriviData
            // 
            this.btnScriviData.Location = new System.Drawing.Point(241, 122);
            this.btnScriviData.Name = "btnScriviData";
            this.btnScriviData.Size = new System.Drawing.Size(163, 73);
            this.btnScriviData.TabIndex = 5;
            this.btnScriviData.Text = "SCRIVI DATA";
            this.btnScriviData.UseVisualStyleBackColor = true;
            this.btnScriviData.Click += new System.EventHandler(this.btnScriviData_Click);
            // 
            // btnDomani
            // 
            this.btnDomani.Location = new System.Drawing.Point(420, 122);
            this.btnDomani.Name = "btnDomani";
            this.btnDomani.Size = new System.Drawing.Size(163, 73);
            this.btnDomani.TabIndex = 6;
            this.btnDomani.Text = "INCREMENTA GIORNO";
            this.btnDomani.UseVisualStyleBackColor = true;
            this.btnDomani.Click += new System.EventHandler(this.btnDomani_Click);
            // 
            // btnDecrementa
            // 
            this.btnDecrementa.Location = new System.Drawing.Point(605, 122);
            this.btnDecrementa.Name = "btnDecrementa";
            this.btnDecrementa.Size = new System.Drawing.Size(163, 73);
            this.btnDecrementa.TabIndex = 7;
            this.btnDecrementa.Text = "DECREMENTA DATA";
            this.btnDecrementa.UseVisualStyleBackColor = true;
            this.btnDecrementa.Click += new System.EventHandler(this.btnDecrementa_Click);
            // 
            // btnConosciGiorno
            // 
            this.btnConosciGiorno.Location = new System.Drawing.Point(327, 210);
            this.btnConosciGiorno.Name = "btnConosciGiorno";
            this.btnConosciGiorno.Size = new System.Drawing.Size(163, 73);
            this.btnConosciGiorno.TabIndex = 8;
            this.btnConosciGiorno.Text = "CONOSCI GIORNO";
            this.btnConosciGiorno.UseVisualStyleBackColor = true;
            this.btnConosciGiorno.Click += new System.EventHandler(this.btnConosciGiorno_Click);
            // 
            // gbDataEOra
            // 
            this.gbDataEOra.Controls.Add(this.btnScriviDataEOra);
            this.gbDataEOra.Controls.Add(this.btnLeggiDataEOra);
            this.gbDataEOra.Controls.Add(this.btnToStringDataEOra);
            this.gbDataEOra.Controls.Add(this.btnCreaDataEOra);
            this.gbDataEOra.Controls.Add(this.btnCreaOraConParametri);
            this.gbDataEOra.Controls.Add(this.btnCreaOra);
            this.gbDataEOra.Location = new System.Drawing.Point(296, 437);
            this.gbDataEOra.Name = "gbDataEOra";
            this.gbDataEOra.Size = new System.Drawing.Size(832, 220);
            this.gbDataEOra.TabIndex = 2;
            this.gbDataEOra.TabStop = false;
            this.gbDataEOra.Text = "DATA E ORA";
            // 
            // btnToStringDataEOra
            // 
            this.btnToStringDataEOra.Location = new System.Drawing.Point(605, 33);
            this.btnToStringDataEOra.Name = "btnToStringDataEOra";
            this.btnToStringDataEOra.Size = new System.Drawing.Size(163, 73);
            this.btnToStringDataEOra.TabIndex = 3;
            this.btnToStringDataEOra.Text = "TO STRING DATA E ORA";
            this.btnToStringDataEOra.UseVisualStyleBackColor = true;
            this.btnToStringDataEOra.Click += new System.EventHandler(this.btnToStringDataEOra_Click);
            // 
            // btnCreaDataEOra
            // 
            this.btnCreaDataEOra.Location = new System.Drawing.Point(420, 33);
            this.btnCreaDataEOra.Name = "btnCreaDataEOra";
            this.btnCreaDataEOra.Size = new System.Drawing.Size(163, 73);
            this.btnCreaDataEOra.TabIndex = 2;
            this.btnCreaDataEOra.Text = "CREA DATA E ORA";
            this.btnCreaDataEOra.UseVisualStyleBackColor = true;
            this.btnCreaDataEOra.Click += new System.EventHandler(this.btnCreaDataEOra_Click);
            // 
            // btnCreaOraConParametri
            // 
            this.btnCreaOraConParametri.Location = new System.Drawing.Point(241, 33);
            this.btnCreaOraConParametri.Name = "btnCreaOraConParametri";
            this.btnCreaOraConParametri.Size = new System.Drawing.Size(163, 73);
            this.btnCreaOraConParametri.TabIndex = 1;
            this.btnCreaOraConParametri.Text = "CREA ORA (CON PARAMETRI)";
            this.btnCreaOraConParametri.UseVisualStyleBackColor = true;
            this.btnCreaOraConParametri.Click += new System.EventHandler(this.btnCreaOraConParametri_Click);
            // 
            // btnCreaOra
            // 
            this.btnCreaOra.Location = new System.Drawing.Point(61, 33);
            this.btnCreaOra.Name = "btnCreaOra";
            this.btnCreaOra.Size = new System.Drawing.Size(163, 73);
            this.btnCreaOra.TabIndex = 0;
            this.btnCreaOra.Text = "CREA ORA (NO-PARAMETRI)";
            this.btnCreaOra.UseVisualStyleBackColor = true;
            this.btnCreaOra.Click += new System.EventHandler(this.btnCreaOra_Click);
            // 
            // btnScriviDataEOra
            // 
            this.btnScriviDataEOra.Location = new System.Drawing.Point(420, 125);
            this.btnScriviDataEOra.Name = "btnScriviDataEOra";
            this.btnScriviDataEOra.Size = new System.Drawing.Size(163, 73);
            this.btnScriviDataEOra.TabIndex = 5;
            this.btnScriviDataEOra.Text = "SCRIVI DATA E ORARIO";
            this.btnScriviDataEOra.UseVisualStyleBackColor = true;
            this.btnScriviDataEOra.Click += new System.EventHandler(this.btnScriviDataEOra_Click);
            // 
            // btnLeggiDataEOra
            // 
            this.btnLeggiDataEOra.Location = new System.Drawing.Point(241, 125);
            this.btnLeggiDataEOra.Name = "btnLeggiDataEOra";
            this.btnLeggiDataEOra.Size = new System.Drawing.Size(163, 73);
            this.btnLeggiDataEOra.TabIndex = 4;
            this.btnLeggiDataEOra.Text = "LEGGI DATA E ORARIO";
            this.btnLeggiDataEOra.UseVisualStyleBackColor = true;
            this.btnLeggiDataEOra.Click += new System.EventHandler(this.btnLeggiDataEOra_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 703);
            this.Controls.Add(this.gbDataEOra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbData);
            this.Name = "frmMain";
            this.Text = "DATA E ORARIO";
            this.gbData.ResumeLayout(false);
            this.gbDataEOra.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.Button btnCreaData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConosciGiorno;
        private System.Windows.Forms.Button btnDecrementa;
        private System.Windows.Forms.Button btnDomani;
        private System.Windows.Forms.Button btnScriviData;
        private System.Windows.Forms.Button btnLeggiData;
        private System.Windows.Forms.Button btnBisestile;
        private System.Windows.Forms.Button btnToString;
        private System.Windows.Forms.Button btnCreaDataConParametri;
        private System.Windows.Forms.GroupBox gbDataEOra;
        private System.Windows.Forms.Button btnScriviDataEOra;
        private System.Windows.Forms.Button btnLeggiDataEOra;
        private System.Windows.Forms.Button btnToStringDataEOra;
        private System.Windows.Forms.Button btnCreaDataEOra;
        private System.Windows.Forms.Button btnCreaOraConParametri;
        private System.Windows.Forms.Button btnCreaOra;
    }
}

