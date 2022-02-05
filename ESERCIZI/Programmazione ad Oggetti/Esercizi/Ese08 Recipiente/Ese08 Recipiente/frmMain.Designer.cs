namespace Ese08_Recipiente
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
            this.btnClassicContainer = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCreaEditRecipiente = new System.Windows.Forms.Button();
            this.btnVisualizzaLaCapacità = new System.Windows.Forms.Button();
            this.btnEditCapacità = new System.Windows.Forms.Button();
            this.btnAggiungiContenuto = new System.Windows.Forms.Button();
            this.btnTogliContenuto = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEditCapacitàBicchiere = new System.Windows.Forms.Button();
            this.btnShowCapacità = new System.Windows.Forms.Button();
            this.btnEditBicchiere = new System.Windows.Forms.Button();
            this.btnCreaBicchiere = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClassicContainer
            // 
            this.btnClassicContainer.Location = new System.Drawing.Point(6, 30);
            this.btnClassicContainer.Name = "btnClassicContainer";
            this.btnClassicContainer.Size = new System.Drawing.Size(158, 59);
            this.btnClassicContainer.TabIndex = 0;
            this.btnClassicContainer.Text = "CREA UN RECIPIENTE DA 1000ml";
            this.btnClassicContainer.UseVisualStyleBackColor = true;
            this.btnClassicContainer.Click += new System.EventHandler(this.btnClassicContainer_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTogliContenuto);
            this.groupBox1.Controls.Add(this.btnAggiungiContenuto);
            this.groupBox1.Controls.Add(this.btnEditCapacità);
            this.groupBox1.Controls.Add(this.btnVisualizzaLaCapacità);
            this.groupBox1.Controls.Add(this.btnCreaEditRecipiente);
            this.groupBox1.Controls.Add(this.btnClassicContainer);
            this.groupBox1.Location = new System.Drawing.Point(36, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(734, 170);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RECIPIENTE";
            // 
            // btnCreaEditRecipiente
            // 
            this.btnCreaEditRecipiente.Location = new System.Drawing.Point(194, 30);
            this.btnCreaEditRecipiente.Name = "btnCreaEditRecipiente";
            this.btnCreaEditRecipiente.Size = new System.Drawing.Size(158, 59);
            this.btnCreaEditRecipiente.TabIndex = 1;
            this.btnCreaEditRecipiente.Text = "CREA UN RECIPIENTE DA QUANTO VUOI TU";
            this.btnCreaEditRecipiente.UseVisualStyleBackColor = true;
            this.btnCreaEditRecipiente.Click += new System.EventHandler(this.btnCreaEditRecipiente_Click);
            // 
            // btnVisualizzaLaCapacità
            // 
            this.btnVisualizzaLaCapacità.Location = new System.Drawing.Point(371, 30);
            this.btnVisualizzaLaCapacità.Name = "btnVisualizzaLaCapacità";
            this.btnVisualizzaLaCapacità.Size = new System.Drawing.Size(158, 59);
            this.btnVisualizzaLaCapacità.TabIndex = 2;
            this.btnVisualizzaLaCapacità.Text = "SCOPRI QUANTA CAPACITA\' C\'E\'";
            this.btnVisualizzaLaCapacità.UseVisualStyleBackColor = true;
            this.btnVisualizzaLaCapacità.Click += new System.EventHandler(this.btnVisualizzaLaCapacità_Click);
            // 
            // btnEditCapacità
            // 
            this.btnEditCapacità.Location = new System.Drawing.Point(552, 30);
            this.btnEditCapacità.Name = "btnEditCapacità";
            this.btnEditCapacità.Size = new System.Drawing.Size(158, 59);
            this.btnEditCapacità.TabIndex = 3;
            this.btnEditCapacità.Text = "MODIFICA LA CAPACITA\'";
            this.btnEditCapacità.UseVisualStyleBackColor = true;
            this.btnEditCapacità.Click += new System.EventHandler(this.btnEditCapacità_Click);
            // 
            // btnAggiungiContenuto
            // 
            this.btnAggiungiContenuto.Location = new System.Drawing.Point(194, 95);
            this.btnAggiungiContenuto.Name = "btnAggiungiContenuto";
            this.btnAggiungiContenuto.Size = new System.Drawing.Size(158, 59);
            this.btnAggiungiContenuto.TabIndex = 4;
            this.btnAggiungiContenuto.Text = "AGGIUNGI CONTENUTO";
            this.btnAggiungiContenuto.UseVisualStyleBackColor = true;
            this.btnAggiungiContenuto.Click += new System.EventHandler(this.btnAggiungiContenuto_Click);
            // 
            // btnTogliContenuto
            // 
            this.btnTogliContenuto.Location = new System.Drawing.Point(371, 95);
            this.btnTogliContenuto.Name = "btnTogliContenuto";
            this.btnTogliContenuto.Size = new System.Drawing.Size(158, 59);
            this.btnTogliContenuto.TabIndex = 5;
            this.btnTogliContenuto.Text = "TOGLI CONTENUTO";
            this.btnTogliContenuto.UseVisualStyleBackColor = true;
            this.btnTogliContenuto.Click += new System.EventHandler(this.btnTogliContenuto_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEditCapacitàBicchiere);
            this.groupBox2.Controls.Add(this.btnShowCapacità);
            this.groupBox2.Controls.Add(this.btnEditBicchiere);
            this.groupBox2.Controls.Add(this.btnCreaBicchiere);
            this.groupBox2.Location = new System.Drawing.Point(208, 198);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 170);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BICCHIERE";
            // 
            // btnEditCapacitàBicchiere
            // 
            this.btnEditCapacitàBicchiere.Location = new System.Drawing.Point(199, 95);
            this.btnEditCapacitàBicchiere.Name = "btnEditCapacitàBicchiere";
            this.btnEditCapacitàBicchiere.Size = new System.Drawing.Size(158, 59);
            this.btnEditCapacitàBicchiere.TabIndex = 3;
            this.btnEditCapacitàBicchiere.Text = "MODIFICA LA CAPACITA\'";
            this.btnEditCapacitàBicchiere.UseVisualStyleBackColor = true;
            this.btnEditCapacitàBicchiere.Click += new System.EventHandler(this.btnEditCapacitàBicchiere_Click);
            // 
            // btnShowCapacità
            // 
            this.btnShowCapacità.Location = new System.Drawing.Point(22, 95);
            this.btnShowCapacità.Name = "btnShowCapacità";
            this.btnShowCapacità.Size = new System.Drawing.Size(158, 59);
            this.btnShowCapacità.TabIndex = 2;
            this.btnShowCapacità.Text = "SCOPRI QUANTA CAPACITA\' C\'E\'";
            this.btnShowCapacità.UseVisualStyleBackColor = true;
            this.btnShowCapacità.Click += new System.EventHandler(this.btnShowCapacità_Click);
            // 
            // btnEditBicchiere
            // 
            this.btnEditBicchiere.Location = new System.Drawing.Point(198, 30);
            this.btnEditBicchiere.Name = "btnEditBicchiere";
            this.btnEditBicchiere.Size = new System.Drawing.Size(158, 59);
            this.btnEditBicchiere.TabIndex = 1;
            this.btnEditBicchiere.Text = "CREA UN BICCHIERE DA QUANTO VUOI TU";
            this.btnEditBicchiere.UseVisualStyleBackColor = true;
            this.btnEditBicchiere.Click += new System.EventHandler(this.btnEditBicchiere_Click);
            // 
            // btnCreaBicchiere
            // 
            this.btnCreaBicchiere.Location = new System.Drawing.Point(22, 30);
            this.btnCreaBicchiere.Name = "btnCreaBicchiere";
            this.btnCreaBicchiere.Size = new System.Drawing.Size(158, 59);
            this.btnCreaBicchiere.TabIndex = 0;
            this.btnCreaBicchiere.Text = "CREA UN BICCHIERE DA 100ml";
            this.btnCreaBicchiere.UseVisualStyleBackColor = true;
            this.btnCreaBicchiere.Click += new System.EventHandler(this.btnCreaBicchiere_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.Text = "RECIPIENTE";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClassicContainer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCreaEditRecipiente;
        private System.Windows.Forms.Button btnEditCapacità;
        private System.Windows.Forms.Button btnVisualizzaLaCapacità;
        private System.Windows.Forms.Button btnAggiungiContenuto;
        private System.Windows.Forms.Button btnTogliContenuto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEditCapacitàBicchiere;
        private System.Windows.Forms.Button btnShowCapacità;
        private System.Windows.Forms.Button btnEditBicchiere;
        private System.Windows.Forms.Button btnCreaBicchiere;
    }
}

