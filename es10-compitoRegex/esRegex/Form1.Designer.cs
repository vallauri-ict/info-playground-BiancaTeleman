namespace esRegex
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
            this.txtTarga = new System.Windows.Forms.TextBox();
            this.btnInserisciTarga = new System.Windows.Forms.Button();
            this.btnPassword = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtTarga
            // 
            this.txtTarga.Location = new System.Drawing.Point(27, 40);
            this.txtTarga.Name = "txtTarga";
            this.txtTarga.Size = new System.Drawing.Size(100, 20);
            this.txtTarga.TabIndex = 0;
            // 
            // btnInserisciTarga
            // 
            this.btnInserisciTarga.Location = new System.Drawing.Point(37, 66);
            this.btnInserisciTarga.Name = "btnInserisciTarga";
            this.btnInserisciTarga.Size = new System.Drawing.Size(75, 23);
            this.btnInserisciTarga.TabIndex = 1;
            this.btnInserisciTarga.Text = "Targa";
            this.btnInserisciTarga.UseVisualStyleBackColor = true;
            this.btnInserisciTarga.Click += new System.EventHandler(this.btnInserisciTarga_Click);
            // 
            // btnPassword
            // 
            this.btnPassword.Location = new System.Drawing.Point(208, 66);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.Size = new System.Drawing.Size(75, 23);
            this.btnPassword.TabIndex = 3;
            this.btnPassword.Text = "Password";
            this.btnPassword.UseVisualStyleBackColor = true;
            this.btnPassword.Click += new System.EventHandler(this.btnPassword_Click);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(198, 40);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(100, 20);
            this.txtPass.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 249);
            this.Controls.Add(this.btnPassword);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.btnInserisciTarga);
            this.Controls.Add(this.txtTarga);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTarga;
        private System.Windows.Forms.Button btnInserisciTarga;
        private System.Windows.Forms.Button btnPassword;
        private System.Windows.Forms.TextBox txtPass;
    }
}

