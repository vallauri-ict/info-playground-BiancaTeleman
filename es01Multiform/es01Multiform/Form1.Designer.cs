namespace es01Multiform
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
            this.btnApriForm2 = new System.Windows.Forms.Button();
            this.btnForm2b = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnApriForm2
            // 
            this.btnApriForm2.Location = new System.Drawing.Point(12, 12);
            this.btnApriForm2.Name = "btnApriForm2";
            this.btnApriForm2.Size = new System.Drawing.Size(109, 34);
            this.btnApriForm2.TabIndex = 0;
            this.btnApriForm2.Text = "Apri form 2";
            this.btnApriForm2.UseVisualStyleBackColor = true;
            this.btnApriForm2.Click += new System.EventHandler(this.btnApriForm2_Click);
            // 
            // btnForm2b
            // 
            this.btnForm2b.Location = new System.Drawing.Point(147, 12);
            this.btnForm2b.Name = "btnForm2b";
            this.btnForm2b.Size = new System.Drawing.Size(109, 34);
            this.btnForm2b.TabIndex = 1;
            this.btnForm2b.Text = "Apri form 2b";
            this.btnForm2b.UseVisualStyleBackColor = true;
            this.btnForm2b.Click += new System.EventHandler(this.btnForm2b_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnForm2b);
            this.Controls.Add(this.btnApriForm2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnApriForm2;
        private System.Windows.Forms.Button btnForm2b;
    }
}

