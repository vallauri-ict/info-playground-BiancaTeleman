﻿namespace es25_mondoAnimale
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
            this.btnAnimali = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAnimali
            // 
            this.btnAnimali.Location = new System.Drawing.Point(55, 44);
            this.btnAnimali.Name = "btnAnimali";
            this.btnAnimali.Size = new System.Drawing.Size(106, 53);
            this.btnAnimali.TabIndex = 0;
            this.btnAnimali.Text = "Animali";
            this.btnAnimali.UseVisualStyleBackColor = true;
            this.btnAnimali.Click += new System.EventHandler(this.btnAnimali_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 156);
            this.Controls.Add(this.btnAnimali);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAnimali;
    }
}

