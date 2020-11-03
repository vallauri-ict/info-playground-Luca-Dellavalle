namespace Ese_06_coda_di_stampa
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
            this.txtAutore = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitolo = new System.Windows.Forms.TextBox();
            this.btnCoda = new System.Windows.Forms.Button();
            this.btnStampa = new System.Windows.Forms.Button();
            this.dataGridStampa = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStampa)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAutore
            // 
            this.txtAutore.Location = new System.Drawing.Point(178, 43);
            this.txtAutore.Name = "txtAutore";
            this.txtAutore.Size = new System.Drawing.Size(100, 22);
            this.txtAutore.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Autore :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Titolo :";
            // 
            // txtTitolo
            // 
            this.txtTitolo.Location = new System.Drawing.Point(178, 101);
            this.txtTitolo.Name = "txtTitolo";
            this.txtTitolo.Size = new System.Drawing.Size(100, 22);
            this.txtTitolo.TabIndex = 2;
            // 
            // btnCoda
            // 
            this.btnCoda.Location = new System.Drawing.Point(94, 200);
            this.btnCoda.Name = "btnCoda";
            this.btnCoda.Size = new System.Drawing.Size(150, 45);
            this.btnCoda.TabIndex = 4;
            this.btnCoda.Text = "CODA";
            this.btnCoda.UseVisualStyleBackColor = true;
            this.btnCoda.Click += new System.EventHandler(this.btnCoda_Click);
            // 
            // btnStampa
            // 
            this.btnStampa.Location = new System.Drawing.Point(967, 12);
            this.btnStampa.Name = "btnStampa";
            this.btnStampa.Size = new System.Drawing.Size(223, 31);
            this.btnStampa.TabIndex = 5;
            this.btnStampa.Text = "stampa";
            this.btnStampa.UseVisualStyleBackColor = true;
            // 
            // dataGridStampa
            // 
            this.dataGridStampa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStampa.Location = new System.Drawing.Point(506, 75);
            this.dataGridStampa.Name = "dataGridStampa";
            this.dataGridStampa.RowHeadersWidth = 51;
            this.dataGridStampa.RowTemplate.Height = 24;
            this.dataGridStampa.Size = new System.Drawing.Size(684, 321);
            this.dataGridStampa.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 445);
            this.Controls.Add(this.dataGridStampa);
            this.Controls.Add(this.btnStampa);
            this.Controls.Add(this.btnCoda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitolo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAutore);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStampa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAutore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitolo;
        private System.Windows.Forms.Button btnCoda;
        private System.Windows.Forms.Button btnStampa;
        private System.Windows.Forms.DataGridView dataGridStampa;
    }
}

