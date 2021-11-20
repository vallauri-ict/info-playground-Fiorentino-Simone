namespace Ese06_Operatore_IS_e_AS
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
            this.btnGeneraMostro = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnSecond = new System.Windows.Forms.Button();
            this.btnThird = new System.Windows.Forms.Button();
            this.lblFirst = new System.Windows.Forms.Label();
            this.lblSecond = new System.Windows.Forms.Label();
            this.lblThird = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGeneraMostro
            // 
            this.btnGeneraMostro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneraMostro.Location = new System.Drawing.Point(152, 23);
            this.btnGeneraMostro.Name = "btnGeneraMostro";
            this.btnGeneraMostro.Size = new System.Drawing.Size(138, 77);
            this.btnGeneraMostro.TabIndex = 0;
            this.btnGeneraMostro.Text = "GENERA MOSTRO";
            this.btnGeneraMostro.UseVisualStyleBackColor = true;
            this.btnGeneraMostro.Click += new System.EventHandler(this.btnGeneraMostro_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.Location = new System.Drawing.Point(30, 134);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(107, 61);
            this.btnFirst.TabIndex = 1;
            this.btnFirst.Text = "1^ BUTTON";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnOrLabel_Click);
            // 
            // btnSecond
            // 
            this.btnSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSecond.Location = new System.Drawing.Point(164, 134);
            this.btnSecond.Name = "btnSecond";
            this.btnSecond.Size = new System.Drawing.Size(107, 61);
            this.btnSecond.TabIndex = 2;
            this.btnSecond.Text = "2^ BUTTON";
            this.btnSecond.UseVisualStyleBackColor = true;
            this.btnSecond.Click += new System.EventHandler(this.btnOrLabel_Click);
            // 
            // btnThird
            // 
            this.btnThird.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThird.Location = new System.Drawing.Point(296, 134);
            this.btnThird.Name = "btnThird";
            this.btnThird.Size = new System.Drawing.Size(107, 61);
            this.btnThird.TabIndex = 3;
            this.btnThird.Text = "3^ BUTTON";
            this.btnThird.UseVisualStyleBackColor = true;
            this.btnThird.Click += new System.EventHandler(this.btnOrLabel_Click);
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Location = new System.Drawing.Point(65, 221);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(35, 13);
            this.lblFirst.TabIndex = 4;
            this.lblFirst.Text = "label1";
            this.lblFirst.Click += new System.EventHandler(this.btnOrLabel_Click);
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.Location = new System.Drawing.Point(204, 221);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(35, 13);
            this.lblSecond.TabIndex = 5;
            this.lblSecond.Text = "label2";
            this.lblSecond.Click += new System.EventHandler(this.btnOrLabel_Click);
            // 
            // lblThird
            // 
            this.lblThird.AutoSize = true;
            this.lblThird.Location = new System.Drawing.Point(338, 221);
            this.lblThird.Name = "lblThird";
            this.lblThird.Size = new System.Drawing.Size(35, 13);
            this.lblThird.TabIndex = 6;
            this.lblThird.Text = "label3";
            this.lblThird.Click += new System.EventHandler(this.btnOrLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 285);
            this.Controls.Add(this.lblThird);
            this.Controls.Add(this.lblSecond);
            this.Controls.Add(this.lblFirst);
            this.Controls.Add(this.btnThird);
            this.Controls.Add(this.btnSecond);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnGeneraMostro);
            this.Name = "Form1";
            this.Text = "CONTROLLO OPERATORI IS E AS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGeneraMostro;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnSecond;
        private System.Windows.Forms.Button btnThird;
        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label lblSecond;
        private System.Windows.Forms.Label lblThird;
    }
}

