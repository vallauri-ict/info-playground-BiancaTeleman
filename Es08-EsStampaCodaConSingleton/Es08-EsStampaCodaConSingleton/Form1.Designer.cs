namespace Es08_EsStampaCodaConSingleton
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
            this.txtCoda = new System.Windows.Forms.TextBox();
            this.btnAggiungiCoda = new System.Windows.Forms.Button();
            this.btnStampaCoda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCoda
            // 
            this.txtCoda.Location = new System.Drawing.Point(78, 43);
            this.txtCoda.Name = "txtCoda";
            this.txtCoda.Size = new System.Drawing.Size(91, 20);
            this.txtCoda.TabIndex = 0;
            // 
            // btnAggiungiCoda
            // 
            this.btnAggiungiCoda.Location = new System.Drawing.Point(38, 80);
            this.btnAggiungiCoda.Name = "btnAggiungiCoda";
            this.btnAggiungiCoda.Size = new System.Drawing.Size(75, 39);
            this.btnAggiungiCoda.TabIndex = 1;
            this.btnAggiungiCoda.Text = "AGGIUNGI IN CODA";
            this.btnAggiungiCoda.UseVisualStyleBackColor = true;
            this.btnAggiungiCoda.Click += new System.EventHandler(this.btnAggiungiCoda_Click);
            // 
            // btnStampaCoda
            // 
            this.btnStampaCoda.Location = new System.Drawing.Point(147, 80);
            this.btnStampaCoda.Name = "btnStampaCoda";
            this.btnStampaCoda.Size = new System.Drawing.Size(75, 39);
            this.btnStampaCoda.TabIndex = 2;
            this.btnStampaCoda.Text = "STAMPA CODA";
            this.btnStampaCoda.UseVisualStyleBackColor = true;
            this.btnStampaCoda.Click += new System.EventHandler(this.btnStampaCoda_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 147);
            this.Controls.Add(this.btnStampaCoda);
            this.Controls.Add(this.btnAggiungiCoda);
            this.Controls.Add(this.txtCoda);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCoda;
        private System.Windows.Forms.Button btnAggiungiCoda;
        private System.Windows.Forms.Button btnStampaCoda;
    }
}

