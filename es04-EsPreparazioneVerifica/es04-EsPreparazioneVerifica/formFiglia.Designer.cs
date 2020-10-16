namespace es04_EsPreparazioneVerifica
{
    partial class formFiglia
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
            this.txtModificaFfiglia = new System.Windows.Forms.TextBox();
            this.btnModifica2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtModificaFfiglia
            // 
            this.txtModificaFfiglia.Location = new System.Drawing.Point(137, 84);
            this.txtModificaFfiglia.Name = "txtModificaFfiglia";
            this.txtModificaFfiglia.Size = new System.Drawing.Size(100, 20);
            this.txtModificaFfiglia.TabIndex = 0;
            // 
            // btnModifica2
            // 
            this.btnModifica2.Location = new System.Drawing.Point(137, 110);
            this.btnModifica2.Name = "btnModifica2";
            this.btnModifica2.Size = new System.Drawing.Size(100, 40);
            this.btnModifica2.TabIndex = 1;
            this.btnModifica2.Text = "Mostra form priincipale";
            this.btnModifica2.UseVisualStyleBackColor = true;
            this.btnModifica2.Click += new System.EventHandler(this.btnModifica2_Click);
            // 
            // formFiglia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 410);
            this.Controls.Add(this.btnModifica2);
            this.Controls.Add(this.txtModificaFfiglia);
            this.Name = "formFiglia";
            this.Text = "formFiglia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtModificaFfiglia;
        private System.Windows.Forms.Button btnModifica2;
    }
}