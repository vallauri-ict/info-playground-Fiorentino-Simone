namespace Ese10_VolumeOggetti
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtRaggio = new System.Windows.Forms.TextBox();
            this.txtAltezza = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLato1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLato2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAreaCilindro = new System.Windows.Forms.Button();
            this.btnVolumeCilindro = new System.Windows.Forms.Button();
            this.gbCilindro = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAreaParallelepipedo = new System.Windows.Forms.Button();
            this.btnVolumeParallelepipedo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.gbCilindro.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(352, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "RAGGIO:";
            // 
            // txtRaggio
            // 
            this.txtRaggio.Location = new System.Drawing.Point(475, 98);
            this.txtRaggio.Name = "txtRaggio";
            this.txtRaggio.Size = new System.Drawing.Size(143, 22);
            this.txtRaggio.TabIndex = 1;
            // 
            // txtAltezza
            // 
            this.txtAltezza.Location = new System.Drawing.Point(475, 142);
            this.txtAltezza.Name = "txtAltezza";
            this.txtAltezza.Size = new System.Drawing.Size(143, 22);
            this.txtAltezza.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(352, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "ALTEZZA:";
            // 
            // txtLato1
            // 
            this.txtLato1.Location = new System.Drawing.Point(475, 184);
            this.txtLato1.Name = "txtLato1";
            this.txtLato1.Size = new System.Drawing.Size(143, 22);
            this.txtLato1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(352, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "LATO 1:";
            // 
            // txtLato2
            // 
            this.txtLato2.Location = new System.Drawing.Point(475, 224);
            this.txtLato2.Name = "txtLato2";
            this.txtLato2.Size = new System.Drawing.Size(143, 22);
            this.txtLato2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(352, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "LATO 2:";
            // 
            // btnAreaCilindro
            // 
            this.btnAreaCilindro.Location = new System.Drawing.Point(20, 21);
            this.btnAreaCilindro.Name = "btnAreaCilindro";
            this.btnAreaCilindro.Size = new System.Drawing.Size(156, 97);
            this.btnAreaCilindro.TabIndex = 8;
            this.btnAreaCilindro.Text = "AREA CILINDRO";
            this.btnAreaCilindro.UseVisualStyleBackColor = true;
            this.btnAreaCilindro.Click += new System.EventHandler(this.btnAreaCilindro_Click);
            // 
            // btnVolumeCilindro
            // 
            this.btnVolumeCilindro.Location = new System.Drawing.Point(190, 21);
            this.btnVolumeCilindro.Name = "btnVolumeCilindro";
            this.btnVolumeCilindro.Size = new System.Drawing.Size(156, 97);
            this.btnVolumeCilindro.TabIndex = 9;
            this.btnVolumeCilindro.Text = "VOLUME CILINDRO";
            this.btnVolumeCilindro.UseVisualStyleBackColor = true;
            this.btnVolumeCilindro.Click += new System.EventHandler(this.btnVolumeCilindro_Click);
            // 
            // gbCilindro
            // 
            this.gbCilindro.Controls.Add(this.btnAreaCilindro);
            this.gbCilindro.Controls.Add(this.btnVolumeCilindro);
            this.gbCilindro.Location = new System.Drawing.Point(72, 271);
            this.gbCilindro.Name = "gbCilindro";
            this.gbCilindro.Size = new System.Drawing.Size(380, 135);
            this.gbCilindro.TabIndex = 10;
            this.gbCilindro.TabStop = false;
            this.gbCilindro.Text = "CILINDRO";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAreaParallelepipedo);
            this.groupBox1.Controls.Add(this.btnVolumeParallelepipedo);
            this.groupBox1.Location = new System.Drawing.Point(475, 271);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 135);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PARALLELEPIPEDO";
            // 
            // btnAreaParallelepipedo
            // 
            this.btnAreaParallelepipedo.Location = new System.Drawing.Point(19, 21);
            this.btnAreaParallelepipedo.Name = "btnAreaParallelepipedo";
            this.btnAreaParallelepipedo.Size = new System.Drawing.Size(156, 97);
            this.btnAreaParallelepipedo.TabIndex = 8;
            this.btnAreaParallelepipedo.Text = "AREA PARALLELEPIPEDO";
            this.btnAreaParallelepipedo.UseVisualStyleBackColor = true;
            this.btnAreaParallelepipedo.Click += new System.EventHandler(this.btnAreaParallelepipedo_Click);
            // 
            // btnVolumeParallelepipedo
            // 
            this.btnVolumeParallelepipedo.Location = new System.Drawing.Point(190, 21);
            this.btnVolumeParallelepipedo.Name = "btnVolumeParallelepipedo";
            this.btnVolumeParallelepipedo.Size = new System.Drawing.Size(156, 97);
            this.btnVolumeParallelepipedo.TabIndex = 9;
            this.btnVolumeParallelepipedo.Text = "VOLUME PARALLELEPIPEDO";
            this.btnVolumeParallelepipedo.UseVisualStyleBackColor = true;
            this.btnVolumeParallelepipedo.Click += new System.EventHandler(this.btnVolumeParallelepipedo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(242, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(481, 40);
            this.label5.TabIndex = 12;
            this.label5.Text = "CALCOLA IL VOLUME E L\'AREA";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbCilindro);
            this.Controls.Add(this.txtLato2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLato1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAltezza);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRaggio);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "VOLUME OGGETTI TRIDIMENSIONALI";
            this.gbCilindro.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRaggio;
        private System.Windows.Forms.TextBox txtAltezza;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLato1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLato2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAreaCilindro;
        private System.Windows.Forms.Button btnVolumeCilindro;
        private System.Windows.Forms.GroupBox gbCilindro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAreaParallelepipedo;
        private System.Windows.Forms.Button btnVolumeParallelepipedo;
        private System.Windows.Forms.Label label5;
    }
}

