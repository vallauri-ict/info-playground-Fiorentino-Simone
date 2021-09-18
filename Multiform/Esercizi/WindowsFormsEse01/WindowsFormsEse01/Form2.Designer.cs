namespace WindowsFormsEse01
{
    partial class Form2
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
            this.label2lblForm2 = new System.Windows.Forms.Label();
            this.BtnLeggiValoriDaTxt = new System.Windows.Forms.Button();
            this.txtF2 = new System.Windows.Forms.TextBox();
            this.btnInviaForm1 = new System.Windows.Forms.Button();
            this.lblForm2 = new System.Windows.Forms.Label();
            this.btnForm2ApriFiglia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2lblForm2
            // 
            this.label2lblForm2.AutoSize = true;
            this.label2lblForm2.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2lblForm2.Location = new System.Drawing.Point(247, 87);
            this.label2lblForm2.Name = "label2lblForm2";
            this.label2lblForm2.Size = new System.Drawing.Size(316, 45);
            this.label2lblForm2.TabIndex = 1;
            this.label2lblForm2.Text = "SONO LA FORM 2";
            // 
            // BtnLeggiValoriDaTxt
            // 
            this.BtnLeggiValoriDaTxt.Location = new System.Drawing.Point(71, 191);
            this.BtnLeggiValoriDaTxt.Name = "BtnLeggiValoriDaTxt";
            this.BtnLeggiValoriDaTxt.Size = new System.Drawing.Size(140, 59);
            this.BtnLeggiValoriDaTxt.TabIndex = 2;
            this.BtnLeggiValoriDaTxt.Text = "LEGGI VALORE DA TXT";
            this.BtnLeggiValoriDaTxt.UseVisualStyleBackColor = true;
            this.BtnLeggiValoriDaTxt.Click += new System.EventHandler(this.BtnLeggiValoriDaTxt_Click);
            // 
            // txtF2
            // 
            this.txtF2.Location = new System.Drawing.Point(71, 289);
            this.txtF2.Name = "txtF2";
            this.txtF2.Size = new System.Drawing.Size(140, 20);
            this.txtF2.TabIndex = 3;
            // 
            // btnInviaForm1
            // 
            this.btnInviaForm1.Location = new System.Drawing.Point(217, 269);
            this.btnInviaForm1.Name = "btnInviaForm1";
            this.btnInviaForm1.Size = new System.Drawing.Size(140, 59);
            this.btnInviaForm1.TabIndex = 4;
            this.btnInviaForm1.Text = "INVIA A FORM 1";
            this.btnInviaForm1.UseVisualStyleBackColor = true;
            this.btnInviaForm1.Click += new System.EventHandler(this.btnInviaForm1_Click);
            // 
            // lblForm2
            // 
            this.lblForm2.AutoSize = true;
            this.lblForm2.Location = new System.Drawing.Point(68, 269);
            this.lblForm2.Name = "lblForm2";
            this.lblForm2.Size = new System.Drawing.Size(144, 13);
            this.lblForm2.TabIndex = 5;
            this.lblForm2.Text = "MANDA TESTO AL FORM 1";
            // 
            // btnForm2ApriFiglia
            // 
            this.btnForm2ApriFiglia.Location = new System.Drawing.Point(71, 349);
            this.btnForm2ApriFiglia.Name = "btnForm2ApriFiglia";
            this.btnForm2ApriFiglia.Size = new System.Drawing.Size(122, 58);
            this.btnForm2ApriFiglia.TabIndex = 4;
            this.btnForm2ApriFiglia.Text = "APRI FORM FIGLIA";
            this.btnForm2ApriFiglia.UseVisualStyleBackColor = true;
            this.btnForm2ApriFiglia.Click += new System.EventHandler(this.btnForm2ApriFiglia_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnForm2ApriFiglia);
            this.Controls.Add(this.lblForm2);
            this.Controls.Add(this.btnInviaForm1);
            this.Controls.Add(this.txtF2);
            this.Controls.Add(this.BtnLeggiValoriDaTxt);
            this.Controls.Add(this.label2lblForm2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2lblForm2;
        private System.Windows.Forms.Button BtnLeggiValoriDaTxt;
        private System.Windows.Forms.TextBox txtF2;
        private System.Windows.Forms.Button btnInviaForm1;
        private System.Windows.Forms.Label lblForm2;
        private System.Windows.Forms.Button btnForm2ApriFiglia;
    }
}