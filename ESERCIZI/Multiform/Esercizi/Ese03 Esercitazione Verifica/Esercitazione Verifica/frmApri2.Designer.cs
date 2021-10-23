namespace Esercitazione_Verifica
{
    partial class frmApri2
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grbInterni = new System.Windows.Forms.GroupBox();
            this.lblInterni = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.grbInterni.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblMarca);
            this.groupBox2.Location = new System.Drawing.Point(21, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 61);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SELEZIONE MARCA AUTO";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(174, 28);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(25, 13);
            this.lblMarca.TabIndex = 7;
            this.lblMarca.Text = "???";
            // 
            // grbInterni
            // 
            this.grbInterni.Controls.Add(this.lblInterni);
            this.grbInterni.Location = new System.Drawing.Point(21, 116);
            this.grbInterni.Name = "grbInterni";
            this.grbInterni.Size = new System.Drawing.Size(333, 61);
            this.grbInterni.TabIndex = 7;
            this.grbInterni.TabStop = false;
            this.grbInterni.Text = "SELEZIONE INTERNI";
            // 
            // lblInterni
            // 
            this.lblInterni.AutoSize = true;
            this.lblInterni.Location = new System.Drawing.Point(66, 27);
            this.lblInterni.Name = "lblInterni";
            this.lblInterni.Size = new System.Drawing.Size(25, 13);
            this.lblInterni.TabIndex = 7;
            this.lblInterni.Text = "???";
            // 
            // frmApri2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 216);
            this.Controls.Add(this.grbInterni);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmApri2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmApri2";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grbInterni.ResumeLayout(false);
            this.grbInterni.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblMarca;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grbInterni;
        private System.Windows.Forms.Label lblInterni;
    }
}