namespace Ese02_Funzionamento_Dizionari
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
            this.lblTitolo = new System.Windows.Forms.Label();
            this.txtTitolo = new System.Windows.Forms.TextBox();
            this.txtAutore = new System.Windows.Forms.TextBox();
            this.lblAutore = new System.Windows.Forms.Label();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnVisDict = new System.Windows.Forms.Button();
            this.nupIndiceLibro = new System.Windows.Forms.NumericUpDown();
            this.lblIndice = new System.Windows.Forms.Label();
            this.btnLibroIndice = new System.Windows.Forms.Button();
            this.btnInCoda = new System.Windows.Forms.Button();
            this.btnInPila = new System.Windows.Forms.Button();
            this.btnEstraiDallaCoda = new System.Windows.Forms.Button();
            this.btnEstraiDallaPila = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nupIndiceLibro)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitolo
            // 
            this.lblTitolo.AutoSize = true;
            this.lblTitolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitolo.Location = new System.Drawing.Point(92, 39);
            this.lblTitolo.Name = "lblTitolo";
            this.lblTitolo.Size = new System.Drawing.Size(81, 20);
            this.lblTitolo.TabIndex = 0;
            this.lblTitolo.Text = "TITOLO: ";
            // 
            // txtTitolo
            // 
            this.txtTitolo.Location = new System.Drawing.Point(304, 39);
            this.txtTitolo.Name = "txtTitolo";
            this.txtTitolo.Size = new System.Drawing.Size(100, 20);
            this.txtTitolo.TabIndex = 1;
            // 
            // txtAutore
            // 
            this.txtAutore.Location = new System.Drawing.Point(304, 78);
            this.txtAutore.Name = "txtAutore";
            this.txtAutore.Size = new System.Drawing.Size(100, 20);
            this.txtAutore.TabIndex = 3;
            // 
            // lblAutore
            // 
            this.lblAutore.AutoSize = true;
            this.lblAutore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutore.Location = new System.Drawing.Point(92, 76);
            this.lblAutore.Name = "lblAutore";
            this.lblAutore.Size = new System.Drawing.Size(92, 20);
            this.lblAutore.TabIndex = 2;
            this.lblAutore.Text = "AUTORE: ";
            // 
            // btnAddBook
            // 
            this.btnAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBook.Location = new System.Drawing.Point(70, 172);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(160, 76);
            this.btnAddBook.TabIndex = 4;
            this.btnAddBook.Text = "AGGIUNGI LIBRO";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnVisDict
            // 
            this.btnVisDict.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisDict.Location = new System.Drawing.Point(282, 172);
            this.btnVisDict.Name = "btnVisDict";
            this.btnVisDict.Size = new System.Drawing.Size(160, 76);
            this.btnVisDict.TabIndex = 5;
            this.btnVisDict.Text = "VISUALIZZA DICTIONARY";
            this.btnVisDict.UseVisualStyleBackColor = true;
            this.btnVisDict.Click += new System.EventHandler(this.btnVisDict_Click);
            // 
            // nupIndiceLibro
            // 
            this.nupIndiceLibro.Location = new System.Drawing.Point(304, 122);
            this.nupIndiceLibro.Name = "nupIndiceLibro";
            this.nupIndiceLibro.Size = new System.Drawing.Size(100, 20);
            this.nupIndiceLibro.TabIndex = 6;
            // 
            // lblIndice
            // 
            this.lblIndice.AutoSize = true;
            this.lblIndice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndice.Location = new System.Drawing.Point(92, 122);
            this.lblIndice.Name = "lblIndice";
            this.lblIndice.Size = new System.Drawing.Size(75, 20);
            this.lblIndice.TabIndex = 7;
            this.lblIndice.Text = "INDICE:";
            // 
            // btnLibroIndice
            // 
            this.btnLibroIndice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibroIndice.Location = new System.Drawing.Point(183, 254);
            this.btnLibroIndice.Name = "btnLibroIndice";
            this.btnLibroIndice.Size = new System.Drawing.Size(160, 76);
            this.btnLibroIndice.TabIndex = 8;
            this.btnLibroIndice.Text = "VISUALIZZA LIBRO CON INDICE";
            this.btnLibroIndice.UseVisualStyleBackColor = true;
            this.btnLibroIndice.Click += new System.EventHandler(this.btnLibroIndice_Click);
            // 
            // btnInCoda
            // 
            this.btnInCoda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInCoda.Location = new System.Drawing.Point(70, 358);
            this.btnInCoda.Name = "btnInCoda";
            this.btnInCoda.Size = new System.Drawing.Size(160, 76);
            this.btnInCoda.TabIndex = 9;
            this.btnInCoda.Text = "AGGIUNGI IN CODA";
            this.btnInCoda.UseVisualStyleBackColor = true;
            this.btnInCoda.Click += new System.EventHandler(this.btnInCoda_Click);
            // 
            // btnInPila
            // 
            this.btnInPila.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInPila.Location = new System.Drawing.Point(70, 440);
            this.btnInPila.Name = "btnInPila";
            this.btnInPila.Size = new System.Drawing.Size(160, 76);
            this.btnInPila.TabIndex = 10;
            this.btnInPila.Text = "AGGIUNGI IN PILA";
            this.btnInPila.UseVisualStyleBackColor = true;
            this.btnInPila.Click += new System.EventHandler(this.btnInPila_Click);
            // 
            // btnEstraiDallaCoda
            // 
            this.btnEstraiDallaCoda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstraiDallaCoda.Location = new System.Drawing.Point(282, 358);
            this.btnEstraiDallaCoda.Name = "btnEstraiDallaCoda";
            this.btnEstraiDallaCoda.Size = new System.Drawing.Size(160, 76);
            this.btnEstraiDallaCoda.TabIndex = 11;
            this.btnEstraiDallaCoda.Text = "ESTRAI DALLA CODA";
            this.btnEstraiDallaCoda.UseVisualStyleBackColor = true;
            this.btnEstraiDallaCoda.Click += new System.EventHandler(this.btnEstraiDallaCoda_Click);
            // 
            // btnEstraiDallaPila
            // 
            this.btnEstraiDallaPila.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstraiDallaPila.Location = new System.Drawing.Point(282, 440);
            this.btnEstraiDallaPila.Name = "btnEstraiDallaPila";
            this.btnEstraiDallaPila.Size = new System.Drawing.Size(160, 76);
            this.btnEstraiDallaPila.TabIndex = 12;
            this.btnEstraiDallaPila.Text = "ESTRAI DALLA PILA";
            this.btnEstraiDallaPila.UseVisualStyleBackColor = true;
            this.btnEstraiDallaPila.Click += new System.EventHandler(this.btnEstraiDallaPila_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 581);
            this.Controls.Add(this.btnEstraiDallaPila);
            this.Controls.Add(this.btnEstraiDallaCoda);
            this.Controls.Add(this.btnInPila);
            this.Controls.Add(this.btnInCoda);
            this.Controls.Add(this.btnLibroIndice);
            this.Controls.Add(this.lblIndice);
            this.Controls.Add(this.nupIndiceLibro);
            this.Controls.Add(this.btnVisDict);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.txtAutore);
            this.Controls.Add(this.lblAutore);
            this.Controls.Add(this.txtTitolo);
            this.Controls.Add(this.lblTitolo);
            this.Name = "frmMain";
            this.Text = "DICTIONARY";
            ((System.ComponentModel.ISupportInitialize)(this.nupIndiceLibro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitolo;
        private System.Windows.Forms.TextBox txtTitolo;
        private System.Windows.Forms.TextBox txtAutore;
        private System.Windows.Forms.Label lblAutore;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnVisDict;
        private System.Windows.Forms.NumericUpDown nupIndiceLibro;
        private System.Windows.Forms.Label lblIndice;
        private System.Windows.Forms.Button btnLibroIndice;
        private System.Windows.Forms.Button btnInCoda;
        private System.Windows.Forms.Button btnInPila;
        private System.Windows.Forms.Button btnEstraiDallaCoda;
        private System.Windows.Forms.Button btnEstraiDallaPila;
    }
}

