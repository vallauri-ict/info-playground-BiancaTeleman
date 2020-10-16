namespace es04_EsPreparazioneVerifica
{
    partial class formSecondaria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtEtaf2 = new System.Windows.Forms.TextBox();
            this.txtNomef2 = new System.Windows.Forms.TextBox();
            this.lblEta = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnAnnulla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEtaf2
            // 
            this.txtEtaf2.Location = new System.Drawing.Point(57, 56);
            this.txtEtaf2.Name = "txtEtaf2";
            this.txtEtaf2.Size = new System.Drawing.Size(100, 20);
            this.txtEtaf2.TabIndex = 10;
            // 
            // txtNomef2
            // 
            this.txtNomef2.Location = new System.Drawing.Point(57, 24);
            this.txtNomef2.Name = "txtNomef2";
            this.txtNomef2.Size = new System.Drawing.Size(100, 20);
            this.txtNomef2.TabIndex = 9;
            // 
            // lblEta
            // 
            this.lblEta.AutoSize = true;
            this.lblEta.Location = new System.Drawing.Point(16, 59);
            this.lblEta.Name = "lblEta";
            this.lblEta.Size = new System.Drawing.Size(23, 13);
            this.lblEta.TabIndex = 8;
            this.lblEta.Text = "Età";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(16, 27);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 7;
            this.lblNome.Text = "Nome";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(19, 98);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 11;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnAnnulla
            // 
            this.btnAnnulla.Location = new System.Drawing.Point(114, 98);
            this.btnAnnulla.Name = "btnAnnulla";
            this.btnAnnulla.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulla.TabIndex = 12;
            this.btnAnnulla.Text = "Annulla";
            this.btnAnnulla.UseVisualStyleBackColor = true;
            this.btnAnnulla.Click += new System.EventHandler(this.btnAnnulla_Click);
            // 
            // formSecondaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 322);
            this.Controls.Add(this.btnAnnulla);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtEtaf2);
            this.Controls.Add(this.txtNomef2);
            this.Controls.Add(this.lblEta);
            this.Controls.Add(this.lblNome);
            this.Name = "formSecondaria";
            this.Text = "formSecondaria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEtaf2;
        private System.Windows.Forms.TextBox txtNomef2;
        private System.Windows.Forms.Label lblEta;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnAnnulla;
    }
}