namespace es14_dictionaryEsercizio
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
            this.txtChiave = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnInserisci = new System.Windows.Forms.Button();
            this.btnVisualizza = new System.Windows.Forms.Button();
            this.btnCerca = new System.Windows.Forms.Button();
            this.lblNInserimenti = new System.Windows.Forms.Label();
            this.lblArticolo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chiave";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // txtChiave
            // 
            this.txtChiave.Location = new System.Drawing.Point(58, 30);
            this.txtChiave.Name = "txtChiave";
            this.txtChiave.Size = new System.Drawing.Size(100, 20);
            this.txtChiave.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(58, 56);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 3;
            // 
            // btnInserisci
            // 
            this.btnInserisci.Location = new System.Drawing.Point(12, 93);
            this.btnInserisci.Name = "btnInserisci";
            this.btnInserisci.Size = new System.Drawing.Size(75, 23);
            this.btnInserisci.TabIndex = 4;
            this.btnInserisci.Text = "Inserisci";
            this.btnInserisci.UseVisualStyleBackColor = true;
            this.btnInserisci.Click += new System.EventHandler(this.btnInserisci_Click);
            // 
            // btnVisualizza
            // 
            this.btnVisualizza.Location = new System.Drawing.Point(108, 93);
            this.btnVisualizza.Name = "btnVisualizza";
            this.btnVisualizza.Size = new System.Drawing.Size(103, 40);
            this.btnVisualizza.TabIndex = 5;
            this.btnVisualizza.Text = "Visualizza n inserimenti";
            this.btnVisualizza.UseVisualStyleBackColor = true;
            this.btnVisualizza.Click += new System.EventHandler(this.btnVisualizza_Click);
            // 
            // btnCerca
            // 
            this.btnCerca.Location = new System.Drawing.Point(12, 122);
            this.btnCerca.Name = "btnCerca";
            this.btnCerca.Size = new System.Drawing.Size(75, 23);
            this.btnCerca.TabIndex = 6;
            this.btnCerca.Text = "Cerca";
            this.btnCerca.UseVisualStyleBackColor = true;
            this.btnCerca.Click += new System.EventHandler(this.btnCerca_Click);
            // 
            // lblNInserimenti
            // 
            this.lblNInserimenti.AutoSize = true;
            this.lblNInserimenti.Location = new System.Drawing.Point(17, 159);
            this.lblNInserimenti.Name = "lblNInserimenti";
            this.lblNInserimenti.Size = new System.Drawing.Size(133, 13);
            this.lblNInserimenti.TabIndex = 7;
            this.lblNInserimenti.Text = "numero di elementi inseriti: ";
            // 
            // lblArticolo
            // 
            this.lblArticolo.AutoSize = true;
            this.lblArticolo.Location = new System.Drawing.Point(17, 182);
            this.lblArticolo.Name = "lblArticolo";
            this.lblArticolo.Size = new System.Drawing.Size(87, 13);
            this.lblArticolo.TabIndex = 8;
            this.lblArticolo.Text = "Articolo cercato: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 215);
            this.Controls.Add(this.lblArticolo);
            this.Controls.Add(this.lblNInserimenti);
            this.Controls.Add(this.btnCerca);
            this.Controls.Add(this.btnVisualizza);
            this.Controls.Add(this.btnInserisci);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtChiave);
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
        private System.Windows.Forms.TextBox txtChiave;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnInserisci;
        private System.Windows.Forms.Button btnVisualizza;
        private System.Windows.Forms.Button btnCerca;
        private System.Windows.Forms.Label lblNInserimenti;
        private System.Windows.Forms.Label lblArticolo;
    }
}

