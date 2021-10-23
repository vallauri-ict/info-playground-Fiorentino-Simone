namespace Verifica_FIORENTINO_SIMONE
{
    partial class FrmApri1
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
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbCabinato = new System.Windows.Forms.RadioButton();
            this.rbNonCambinato = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // cmbMarca
            // 
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Items.AddRange(new object[] {
            "Fiat",
            "Panda",
            "Same",
            "Ferrari",
            "Ford"});
            this.cmbMarca.Location = new System.Drawing.Point(164, 54);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(121, 21);
            this.cmbMarca.TabIndex = 0;
            this.cmbMarca.SelectedIndexChanged += new System.EventHandler(this.cmbMarca_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "SELEZIONA UNA MARCA:";
            // 
            // rbCabinato
            // 
            this.rbCabinato.AutoSize = true;
            this.rbCabinato.Location = new System.Drawing.Point(122, 101);
            this.rbCabinato.Name = "rbCabinato";
            this.rbCabinato.Size = new System.Drawing.Size(79, 17);
            this.rbCabinato.TabIndex = 2;
            this.rbCabinato.TabStop = true;
            this.rbCabinato.Text = "CABINATO";
            this.rbCabinato.UseVisualStyleBackColor = true;
            this.rbCabinato.CheckedChanged += new System.EventHandler(this.rbCabinato_CheckedChanged);
            // 
            // rbNonCambinato
            // 
            this.rbNonCambinato.AutoSize = true;
            this.rbNonCambinato.Location = new System.Drawing.Point(122, 139);
            this.rbNonCambinato.Name = "rbNonCambinato";
            this.rbNonCambinato.Size = new System.Drawing.Size(106, 17);
            this.rbNonCambinato.TabIndex = 3;
            this.rbNonCambinato.TabStop = true;
            this.rbNonCambinato.Text = "NON CABINATO";
            this.rbNonCambinato.UseVisualStyleBackColor = true;
            this.rbNonCambinato.CheckedChanged += new System.EventHandler(this.rbNonCambinato_CheckedChanged);
            // 
            // FrmApri1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 249);
            this.Controls.Add(this.rbNonCambinato);
            this.Controls.Add(this.rbCabinato);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMarca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmApri1";
            this.Text = "FrmApri1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbCabinato;
        private System.Windows.Forms.RadioButton rbNonCambinato;
    }
}