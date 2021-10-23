namespace WindowsFormsEse02
{
    partial class FormFiglia
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
            this.lblFiglia1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFiglia1
            // 
            this.lblFiglia1.AutoSize = true;
            this.lblFiglia1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiglia1.Location = new System.Drawing.Point(12, 27);
            this.lblFiglia1.Name = "lblFiglia1";
            this.lblFiglia1.Size = new System.Drawing.Size(126, 18);
            this.lblFiglia1.TabIndex = 0;
            this.lblFiglia1.Text = "FORM FIGLIA 1";
            // 
            // FormFiglia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(165, 79);
            this.Controls.Add(this.lblFiglia1);
            this.Name = "FormFiglia";
            this.Text = "FormFiglia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFiglia1;
    }
}