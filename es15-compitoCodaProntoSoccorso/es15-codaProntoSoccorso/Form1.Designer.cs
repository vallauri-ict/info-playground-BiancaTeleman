namespace es15_codaProntoSoccorso
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEta = new System.Windows.Forms.TextBox();
            this.txtColore = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.btnMedicoLibero = new System.Windows.Forms.Button();
            this.lblColore = new System.Windows.Forms.Label();
            this.lblEta = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.btnTemperature = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Età";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(56, 24);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 2;
            // 
            // txtEta
            // 
            this.txtEta.Location = new System.Drawing.Point(56, 50);
            this.txtEta.Name = "txtEta";
            this.txtEta.Size = new System.Drawing.Size(100, 20);
            this.txtEta.TabIndex = 3;
            // 
            // txtColore
            // 
            this.txtColore.Location = new System.Drawing.Point(56, 76);
            this.txtColore.Name = "txtColore";
            this.txtColore.Size = new System.Drawing.Size(100, 20);
            this.txtColore.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Colore";
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.Location = new System.Drawing.Point(18, 118);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(75, 23);
            this.btnAggiungi.TabIndex = 6;
            this.btnAggiungi.Text = "Aggiungi";
            this.btnAggiungi.UseVisualStyleBackColor = true;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // btnMedicoLibero
            // 
            this.btnMedicoLibero.Location = new System.Drawing.Point(121, 118);
            this.btnMedicoLibero.Name = "btnMedicoLibero";
            this.btnMedicoLibero.Size = new System.Drawing.Size(75, 34);
            this.btnMedicoLibero.TabIndex = 7;
            this.btnMedicoLibero.Text = "Medico libero";
            this.btnMedicoLibero.UseVisualStyleBackColor = true;
            this.btnMedicoLibero.Click += new System.EventHandler(this.btnMedicoLibero_Click);
            // 
            // lblColore
            // 
            this.lblColore.AutoSize = true;
            this.lblColore.Location = new System.Drawing.Point(220, 79);
            this.lblColore.Name = "lblColore";
            this.lblColore.Size = new System.Drawing.Size(37, 13);
            this.lblColore.TabIndex = 10;
            this.lblColore.Text = "Colore";
            // 
            // lblEta
            // 
            this.lblEta.AutoSize = true;
            this.lblEta.Location = new System.Drawing.Point(220, 53);
            this.lblEta.Name = "lblEta";
            this.lblEta.Size = new System.Drawing.Size(23, 13);
            this.lblEta.TabIndex = 9;
            this.lblEta.Text = "Età";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(220, 27);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 8;
            this.lblNome.Text = "Nome";
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Location = new System.Drawing.Point(218, 102);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(67, 13);
            this.lblTemp.TabIndex = 11;
            this.lblTemp.Text = "Temperatura";
            // 
            // btnTemperature
            // 
            this.btnTemperature.Location = new System.Drawing.Point(18, 147);
            this.btnTemperature.Name = "btnTemperature";
            this.btnTemperature.Size = new System.Drawing.Size(75, 34);
            this.btnTemperature.TabIndex = 12;
            this.btnTemperature.Text = "max e min Temperature";
            this.btnTemperature.UseVisualStyleBackColor = true;
            this.btnTemperature.Click += new System.EventHandler(this.btnTemperature_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 228);
            this.Controls.Add(this.btnTemperature);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.lblColore);
            this.Controls.Add(this.lblEta);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnMedicoLibero);
            this.Controls.Add(this.btnAggiungi);
            this.Controls.Add(this.txtColore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEta);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEta;
        private System.Windows.Forms.TextBox txtColore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.Button btnMedicoLibero;
        private System.Windows.Forms.Label lblColore;
        private System.Windows.Forms.Label lblEta;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Button btnTemperature;
    }
}

