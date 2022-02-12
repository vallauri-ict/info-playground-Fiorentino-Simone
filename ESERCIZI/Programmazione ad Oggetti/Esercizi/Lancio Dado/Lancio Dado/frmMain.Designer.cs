namespace Lancio_Dado
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
            this.btnLancioMoneta = new System.Windows.Forms.Button();
            this.btnLancioDado = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLancioDadoAbstract = new System.Windows.Forms.Button();
            this.btnLancioMonetaAbstract = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLancioMoneta
            // 
            this.btnLancioMoneta.Location = new System.Drawing.Point(240, 34);
            this.btnLancioMoneta.Name = "btnLancioMoneta";
            this.btnLancioMoneta.Size = new System.Drawing.Size(130, 84);
            this.btnLancioMoneta.TabIndex = 0;
            this.btnLancioMoneta.Text = "Lancio Moneta";
            this.btnLancioMoneta.UseVisualStyleBackColor = true;
            this.btnLancioMoneta.Click += new System.EventHandler(this.btnLancioMoneta_Click);
            // 
            // btnLancioDado
            // 
            this.btnLancioDado.Location = new System.Drawing.Point(49, 34);
            this.btnLancioDado.Name = "btnLancioDado";
            this.btnLancioDado.Size = new System.Drawing.Size(130, 84);
            this.btnLancioDado.TabIndex = 1;
            this.btnLancioDado.Text = "Lancio Dado";
            this.btnLancioDado.UseVisualStyleBackColor = true;
            this.btnLancioDado.Click += new System.EventHandler(this.btnLancioDado_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLancioDado);
            this.groupBox1.Controls.Add(this.btnLancioMoneta);
            this.groupBox1.Location = new System.Drawing.Point(172, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 144);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LANCIO DATO SENZA ABSTRACT";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLancioDadoAbstract);
            this.groupBox2.Controls.Add(this.btnLancioMonetaAbstract);
            this.groupBox2.Location = new System.Drawing.Point(172, 203);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(440, 144);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LANCIO DATO CON ABSTRACT";
            // 
            // btnLancioDadoAbstract
            // 
            this.btnLancioDadoAbstract.Location = new System.Drawing.Point(49, 34);
            this.btnLancioDadoAbstract.Name = "btnLancioDadoAbstract";
            this.btnLancioDadoAbstract.Size = new System.Drawing.Size(130, 84);
            this.btnLancioDadoAbstract.TabIndex = 1;
            this.btnLancioDadoAbstract.Text = "Lancio Dado ";
            this.btnLancioDadoAbstract.UseVisualStyleBackColor = true;
            this.btnLancioDadoAbstract.Click += new System.EventHandler(this.btnLancioDadoAbstract_Click);
            // 
            // btnLancioMonetaAbstract
            // 
            this.btnLancioMonetaAbstract.Location = new System.Drawing.Point(240, 34);
            this.btnLancioMonetaAbstract.Name = "btnLancioMonetaAbstract";
            this.btnLancioMonetaAbstract.Size = new System.Drawing.Size(130, 84);
            this.btnLancioMonetaAbstract.TabIndex = 0;
            this.btnLancioMonetaAbstract.Text = "Lancio Moneta";
            this.btnLancioMonetaAbstract.UseVisualStyleBackColor = true;
            this.btnLancioMonetaAbstract.Click += new System.EventHandler(this.btnLancioMonetaAbstract_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.Text = "LANCIO DADO";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLancioMoneta;
        private System.Windows.Forms.Button btnLancioDado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLancioDadoAbstract;
        private System.Windows.Forms.Button btnLancioMonetaAbstract;
    }
}

