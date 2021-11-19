
namespace Ese05_Pila_Container
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
            this.btnEstraiPila = new System.Windows.Forms.Button();
            this.btnInserisciContainer = new System.Windows.Forms.Button();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtCodice = new System.Windows.Forms.TextBox();
            this.lblCodice = new System.Windows.Forms.Label();
            this.txtTara = new System.Windows.Forms.TextBox();
            this.lblTara = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEstraiPila
            // 
            this.btnEstraiPila.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstraiPila.Location = new System.Drawing.Point(262, 179);
            this.btnEstraiPila.Name = "btnEstraiPila";
            this.btnEstraiPila.Size = new System.Drawing.Size(128, 61);
            this.btnEstraiPila.TabIndex = 20;
            this.btnEstraiPila.Text = "ESTRAI DALLA PILA";
            this.btnEstraiPila.UseVisualStyleBackColor = true;
            this.btnEstraiPila.Click += new System.EventHandler(this.btnEstraiPila_Click);
            // 
            // btnInserisciContainer
            // 
            this.btnInserisciContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserisciContainer.Location = new System.Drawing.Point(63, 179);
            this.btnInserisciContainer.Name = "btnInserisciContainer";
            this.btnInserisciContainer.Size = new System.Drawing.Size(128, 61);
            this.btnInserisciContainer.TabIndex = 19;
            this.btnInserisciContainer.Text = "INSERISCI CONTAINER";
            this.btnInserisciContainer.UseVisualStyleBackColor = true;
            this.btnInserisciContainer.Click += new System.EventHandler(this.btnInserisciContainer_Click);
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(209, 93);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 20);
            this.txtPeso.TabIndex = 18;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblPeso.Location = new System.Drawing.Point(93, 93);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(62, 20);
            this.lblPeso.TabIndex = 17;
            this.lblPeso.Text = "PESO:";
            // 
            // txtCodice
            // 
            this.txtCodice.Location = new System.Drawing.Point(209, 63);
            this.txtCodice.Name = "txtCodice";
            this.txtCodice.Size = new System.Drawing.Size(100, 20);
            this.txtCodice.TabIndex = 16;
            // 
            // lblCodice
            // 
            this.lblCodice.AutoSize = true;
            this.lblCodice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblCodice.Location = new System.Drawing.Point(93, 63);
            this.lblCodice.Name = "lblCodice";
            this.lblCodice.Size = new System.Drawing.Size(82, 20);
            this.lblCodice.TabIndex = 15;
            this.lblCodice.Text = "CODICE:";
            // 
            // txtTara
            // 
            this.txtTara.Location = new System.Drawing.Point(209, 125);
            this.txtTara.Name = "txtTara";
            this.txtTara.Size = new System.Drawing.Size(100, 20);
            this.txtTara.TabIndex = 23;
            // 
            // lblTara
            // 
            this.lblTara.AutoSize = true;
            this.lblTara.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTara.Location = new System.Drawing.Point(93, 125);
            this.lblTara.Name = "lblTara";
            this.lblTara.Size = new System.Drawing.Size(61, 20);
            this.lblTara.TabIndex = 22;
            this.lblTara.Text = "TARA:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 276);
            this.Controls.Add(this.txtTara);
            this.Controls.Add(this.lblTara);
            this.Controls.Add(this.btnEstraiPila);
            this.Controls.Add(this.btnInserisciContainer);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.txtCodice);
            this.Controls.Add(this.lblCodice);
            this.Name = "frmMain";
            this.Text = "CONTAINER";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEstraiPila;
        private System.Windows.Forms.Button btnInserisciContainer;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txtCodice;
        private System.Windows.Forms.Label lblCodice;
        private System.Windows.Forms.TextBox txtTara;
        private System.Windows.Forms.Label lblTara;
    }
}

