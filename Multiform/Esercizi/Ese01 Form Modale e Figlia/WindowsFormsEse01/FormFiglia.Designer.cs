namespace WindowsFormsEse01
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
            this.btnIndividuoFiglia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIndividuoFiglia
            // 
            this.btnIndividuoFiglia.Location = new System.Drawing.Point(90, 141);
            this.btnIndividuoFiglia.Name = "btnIndividuoFiglia";
            this.btnIndividuoFiglia.Size = new System.Drawing.Size(140, 59);
            this.btnIndividuoFiglia.TabIndex = 3;
            this.btnIndividuoFiglia.Text = "DI CHI SONO FIGLIA?";
            this.btnIndividuoFiglia.UseVisualStyleBackColor = true;
            this.btnIndividuoFiglia.Click += new System.EventHandler(this.btnIndividuoFiglia_Click);
            // 
            // FormFiglia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 431);
            this.Controls.Add(this.btnIndividuoFiglia);
            this.Name = "FormFiglia";
            this.Text = "FormFiglia";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIndividuoFiglia;
    }
}