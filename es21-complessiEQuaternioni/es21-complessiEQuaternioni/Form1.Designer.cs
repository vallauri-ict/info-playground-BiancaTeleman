namespace es21_complessiEQuaternioni
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
            this.btnQuaternione = new System.Windows.Forms.Button();
            this.btnComplesso = new System.Windows.Forms.Button();
            this.txtImmaginarioD = new System.Windows.Forms.TextBox();
            this.txtImmaginarioC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtImmaginario = new System.Windows.Forms.TextBox();
            this.txtReale = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnQuaternione
            // 
            this.btnQuaternione.Location = new System.Drawing.Point(171, 239);
            this.btnQuaternione.Name = "btnQuaternione";
            this.btnQuaternione.Size = new System.Drawing.Size(111, 31);
            this.btnQuaternione.TabIndex = 19;
            this.btnQuaternione.Text = "Quaternione";
            this.btnQuaternione.UseVisualStyleBackColor = true;
            this.btnQuaternione.Click += new System.EventHandler(this.btnQuaternione_Click);
            // 
            // btnComplesso
            // 
            this.btnComplesso.Location = new System.Drawing.Point(28, 239);
            this.btnComplesso.Name = "btnComplesso";
            this.btnComplesso.Size = new System.Drawing.Size(111, 33);
            this.btnComplesso.TabIndex = 18;
            this.btnComplesso.Text = "Complesso";
            this.btnComplesso.UseVisualStyleBackColor = true;
            this.btnComplesso.Click += new System.EventHandler(this.btnComplesso_Click);
            // 
            // txtImmaginarioD
            // 
            this.txtImmaginarioD.Location = new System.Drawing.Point(118, 171);
            this.txtImmaginarioD.Name = "txtImmaginarioD";
            this.txtImmaginarioD.Size = new System.Drawing.Size(100, 20);
            this.txtImmaginarioD.TabIndex = 17;
            // 
            // txtImmaginarioC
            // 
            this.txtImmaginarioC.Location = new System.Drawing.Point(118, 129);
            this.txtImmaginarioC.Name = "txtImmaginarioC";
            this.txtImmaginarioC.Size = new System.Drawing.Size(100, 20);
            this.txtImmaginarioC.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Immaginario D:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Immaginario C:";
            // 
            // txtImmaginario
            // 
            this.txtImmaginario.Location = new System.Drawing.Point(118, 85);
            this.txtImmaginario.Name = "txtImmaginario";
            this.txtImmaginario.Size = new System.Drawing.Size(100, 20);
            this.txtImmaginario.TabIndex = 13;
            // 
            // txtReale
            // 
            this.txtReale.Location = new System.Drawing.Point(118, 39);
            this.txtReale.Name = "txtReale";
            this.txtReale.Size = new System.Drawing.Size(100, 20);
            this.txtReale.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Immaginario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Reale:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 317);
            this.Controls.Add(this.btnQuaternione);
            this.Controls.Add(this.btnComplesso);
            this.Controls.Add(this.txtImmaginarioD);
            this.Controls.Add(this.txtImmaginarioC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtImmaginario);
            this.Controls.Add(this.txtReale);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuaternione;
        private System.Windows.Forms.Button btnComplesso;
        private System.Windows.Forms.TextBox txtImmaginarioD;
        private System.Windows.Forms.TextBox txtImmaginarioC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtImmaginario;
        private System.Windows.Forms.TextBox txtReale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

