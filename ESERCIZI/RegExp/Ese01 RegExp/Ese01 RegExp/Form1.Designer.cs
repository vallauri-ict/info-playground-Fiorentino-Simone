namespace Ese01_RegExp
{
    partial class Form1
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
            this.lblInserimento = new System.Windows.Forms.Label();
            this.txtStringa = new System.Windows.Forms.TextBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCar = new System.Windows.Forms.Label();
            this.btnMatch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInserimento
            // 
            this.lblInserimento.AutoSize = true;
            this.lblInserimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInserimento.Location = new System.Drawing.Point(22, 30);
            this.lblInserimento.Name = "lblInserimento";
            this.lblInserimento.Size = new System.Drawing.Size(311, 24);
            this.lblInserimento.TabIndex = 0;
            this.lblInserimento.Text = "Inserisci la stringa da controllare";
            // 
            // txtStringa
            // 
            this.txtStringa.Location = new System.Drawing.Point(339, 34);
            this.txtStringa.Name = "txtStringa";
            this.txtStringa.Size = new System.Drawing.Size(254, 20);
            this.txtStringa.TabIndex = 1;
            // 
            // btnTest
            // 
            this.btnTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest.Location = new System.Drawing.Point(253, 72);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(154, 61);
            this.btnTest.TabIndex = 2;
            this.btnTest.Text = "VERIFICA IL MATCH";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Uso di match nella stringa: ";
            // 
            // lblCar
            // 
            this.lblCar.AutoSize = true;
            this.lblCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCar.Location = new System.Drawing.Point(299, 160);
            this.lblCar.Name = "lblCar";
            this.lblCar.Size = new System.Drawing.Size(239, 24);
            this.lblCar.TabIndex = 4;
            this.lblCar.Text = "One car red car blue car";
            // 
            // btnMatch
            // 
            this.btnMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatch.Location = new System.Drawing.Point(253, 199);
            this.btnMatch.Name = "btnMatch";
            this.btnMatch.Size = new System.Drawing.Size(154, 61);
            this.btnMatch.TabIndex = 5;
            this.btnMatch.Text = "VERIFICA MATCH";
            this.btnMatch.UseVisualStyleBackColor = true;
            this.btnMatch.Click += new System.EventHandler(this.btnMatch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 339);
            this.Controls.Add(this.btnMatch);
            this.Controls.Add(this.lblCar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.txtStringa);
            this.Controls.Add(this.lblInserimento);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInserimento;
        private System.Windows.Forms.TextBox txtStringa;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCar;
        private System.Windows.Forms.Button btnMatch;
    }
}

