namespace es30_primoEsempioDelegate
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
            this.btnAddizione = new System.Windows.Forms.Button();
            this.btnSottrazione = new System.Windows.Forms.Button();
            this.btnProdotto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddizione
            // 
            this.btnAddizione.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddizione.Location = new System.Drawing.Point(12, 12);
            this.btnAddizione.Name = "btnAddizione";
            this.btnAddizione.Size = new System.Drawing.Size(75, 34);
            this.btnAddizione.TabIndex = 0;
            this.btnAddizione.Text = "+";
            this.btnAddizione.UseVisualStyleBackColor = true;
            this.btnAddizione.Click += new System.EventHandler(this.btnAddizione_Click);
            // 
            // btnSottrazione
            // 
            this.btnSottrazione.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSottrazione.Location = new System.Drawing.Point(174, 12);
            this.btnSottrazione.Name = "btnSottrazione";
            this.btnSottrazione.Size = new System.Drawing.Size(75, 34);
            this.btnSottrazione.TabIndex = 1;
            this.btnSottrazione.Text = "-";
            this.btnSottrazione.UseVisualStyleBackColor = true;
            // 
            // btnProdotto
            // 
            this.btnProdotto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdotto.Location = new System.Drawing.Point(93, 12);
            this.btnProdotto.Name = "btnProdotto";
            this.btnProdotto.Size = new System.Drawing.Size(75, 34);
            this.btnProdotto.TabIndex = 2;
            this.btnProdotto.Text = "*";
            this.btnProdotto.UseVisualStyleBackColor = true;
            this.btnProdotto.Click += new System.EventHandler(this.btnProdotto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 69);
            this.Controls.Add(this.btnProdotto);
            this.Controls.Add(this.btnSottrazione);
            this.Controls.Add(this.btnAddizione);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddizione;
        private System.Windows.Forms.Button btnSottrazione;
        private System.Windows.Forms.Button btnProdotto;
    }
}

