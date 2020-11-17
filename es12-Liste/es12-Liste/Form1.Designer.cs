namespace es12_Liste
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
            this.txtTitolo = new System.Windows.Forms.TextBox();
            this.txtAutore = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.btnVisualizza = new System.Windows.Forms.Button();
            this.btnVisualizzaObj = new System.Windows.Forms.Button();
            this.btnAggiungiObj = new System.Windows.Forms.Button();
            this.txtAut = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFindAll = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titolo";
            // 
            // txtTitolo
            // 
            this.txtTitolo.Location = new System.Drawing.Point(65, 19);
            this.txtTitolo.Name = "txtTitolo";
            this.txtTitolo.Size = new System.Drawing.Size(100, 20);
            this.txtTitolo.TabIndex = 1;
            // 
            // txtAutore
            // 
            this.txtAutore.Location = new System.Drawing.Point(65, 44);
            this.txtAutore.Name = "txtAutore";
            this.txtAutore.Size = new System.Drawing.Size(100, 20);
            this.txtAutore.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Autore";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(65, 74);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ID";
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.Location = new System.Drawing.Point(42, 112);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(75, 23);
            this.btnAggiungi.TabIndex = 6;
            this.btnAggiungi.Text = "Aggiungi";
            this.btnAggiungi.UseVisualStyleBackColor = true;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // btnVisualizza
            // 
            this.btnVisualizza.Location = new System.Drawing.Point(146, 112);
            this.btnVisualizza.Name = "btnVisualizza";
            this.btnVisualizza.Size = new System.Drawing.Size(75, 23);
            this.btnVisualizza.TabIndex = 7;
            this.btnVisualizza.Text = "Visualizza";
            this.btnVisualizza.UseVisualStyleBackColor = true;
            this.btnVisualizza.Click += new System.EventHandler(this.btnVisualizza_Click);
            // 
            // btnVisualizzaObj
            // 
            this.btnVisualizzaObj.Location = new System.Drawing.Point(146, 141);
            this.btnVisualizzaObj.Name = "btnVisualizzaObj";
            this.btnVisualizzaObj.Size = new System.Drawing.Size(99, 23);
            this.btnVisualizzaObj.TabIndex = 9;
            this.btnVisualizzaObj.Text = "Visualizza in obj";
            this.btnVisualizzaObj.UseVisualStyleBackColor = true;
            this.btnVisualizzaObj.Click += new System.EventHandler(this.btnVisualizzaObj_Click);
            // 
            // btnAggiungiObj
            // 
            this.btnAggiungiObj.Location = new System.Drawing.Point(29, 141);
            this.btnAggiungiObj.Name = "btnAggiungiObj";
            this.btnAggiungiObj.Size = new System.Drawing.Size(88, 23);
            this.btnAggiungiObj.TabIndex = 8;
            this.btnAggiungiObj.Text = "Aggiungi in obj";
            this.btnAggiungiObj.UseVisualStyleBackColor = true;
            this.btnAggiungiObj.Click += new System.EventHandler(this.btnAggiungiObj_Click);
            // 
            // txtAut
            // 
            this.txtAut.Location = new System.Drawing.Point(99, 182);
            this.txtAut.Name = "txtAut";
            this.txtAut.Size = new System.Drawing.Size(100, 20);
            this.txtAut.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Autore";
            // 
            // btnFindAll
            // 
            this.btnFindAll.Location = new System.Drawing.Point(146, 210);
            this.btnFindAll.Name = "btnFindAll";
            this.btnFindAll.Size = new System.Drawing.Size(75, 23);
            this.btnFindAll.TabIndex = 13;
            this.btnFindAll.Text = "Find all";
            this.btnFindAll.UseVisualStyleBackColor = true;
            this.btnFindAll.Click += new System.EventHandler(this.btnFindAll_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(42, 210);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 12;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 242);
            this.Controls.Add(this.btnFindAll);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtAut);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnVisualizzaObj);
            this.Controls.Add(this.btnAggiungiObj);
            this.Controls.Add(this.btnVisualizza);
            this.Controls.Add(this.btnAggiungi);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAutore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitolo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitolo;
        private System.Windows.Forms.TextBox txtAutore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.Button btnVisualizza;
        private System.Windows.Forms.Button btnVisualizzaObj;
        private System.Windows.Forms.Button btnAggiungiObj;
        private System.Windows.Forms.TextBox txtAut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFindAll;
        private System.Windows.Forms.Button btnFind;
    }
}

