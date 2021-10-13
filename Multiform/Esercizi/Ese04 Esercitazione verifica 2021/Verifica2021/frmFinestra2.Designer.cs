
namespace Verifica2021
{
    partial class frmFinestra2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rbBianco = new System.Windows.Forms.RadioButton();
            this.rbNero = new System.Windows.Forms.RadioButton();
            this.rbRandom = new System.Windows.Forms.RadioButton();
            this.btnInizia = new System.Windows.Forms.Button();
            this.btnAnnulla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbBianco
            // 
            this.rbBianco.AutoSize = true;
            this.rbBianco.Checked = true;
            this.rbBianco.Location = new System.Drawing.Point(75, 55);
            this.rbBianco.Name = "rbBianco";
            this.rbBianco.Size = new System.Drawing.Size(58, 17);
            this.rbBianco.TabIndex = 0;
            this.rbBianco.TabStop = true;
            this.rbBianco.Text = "Bianco";
            this.rbBianco.UseVisualStyleBackColor = true;
            // 
            // rbNero
            // 
            this.rbNero.AutoSize = true;
            this.rbNero.Location = new System.Drawing.Point(75, 78);
            this.rbNero.Name = "rbNero";
            this.rbNero.Size = new System.Drawing.Size(48, 17);
            this.rbNero.TabIndex = 1;
            this.rbNero.TabStop = true;
            this.rbNero.Text = "Nero";
            this.rbNero.UseVisualStyleBackColor = true;
            // 
            // rbRandom
            // 
            this.rbRandom.AutoSize = true;
            this.rbRandom.Location = new System.Drawing.Point(75, 101);
            this.rbRandom.Name = "rbRandom";
            this.rbRandom.Size = new System.Drawing.Size(98, 17);
            this.rbRandom.TabIndex = 2;
            this.rbRandom.TabStop = true;
            this.rbRandom.Text = "Colore Random";
            this.rbRandom.UseVisualStyleBackColor = true;
            // 
            // btnInizia
            // 
            this.btnInizia.Location = new System.Drawing.Point(23, 141);
            this.btnInizia.Name = "btnInizia";
            this.btnInizia.Size = new System.Drawing.Size(100, 55);
            this.btnInizia.TabIndex = 3;
            this.btnInizia.Text = "INIZIA";
            this.btnInizia.UseVisualStyleBackColor = true;
            this.btnInizia.Click += new System.EventHandler(this.btnInizia_Click);
            // 
            // btnAnnulla
            // 
            this.btnAnnulla.Location = new System.Drawing.Point(170, 141);
            this.btnAnnulla.Name = "btnAnnulla";
            this.btnAnnulla.Size = new System.Drawing.Size(100, 55);
            this.btnAnnulla.TabIndex = 4;
            this.btnAnnulla.Text = "ANNULLA";
            this.btnAnnulla.UseVisualStyleBackColor = true;
            this.btnAnnulla.Click += new System.EventHandler(this.btnAnnulla_Click);
            // 
            // frmFinestra2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 219);
            this.Controls.Add(this.btnAnnulla);
            this.Controls.Add(this.btnInizia);
            this.Controls.Add(this.rbRandom);
            this.Controls.Add(this.rbNero);
            this.Controls.Add(this.rbBianco);
            this.Name = "frmFinestra2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmFinestra2";
            this.Load += new System.EventHandler(this.frmFinestra2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbBianco;
        private System.Windows.Forms.RadioButton rbNero;
        private System.Windows.Forms.RadioButton rbRandom;
        private System.Windows.Forms.Button btnInizia;
        private System.Windows.Forms.Button btnAnnulla;
    }
}