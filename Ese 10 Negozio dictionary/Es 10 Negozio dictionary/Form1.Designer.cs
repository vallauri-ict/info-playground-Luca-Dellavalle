namespace Es_10_Negozio_dictionary
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
            this.txtKey = new System.Windows.Forms.TextBox();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.txtRicerca = new System.Windows.Forms.TextBox();
            this.btnInserisci = new System.Windows.Forms.Button();
            this.btnVisualizza = new System.Windows.Forms.Button();
            this.btnRicerca = new System.Windows.Forms.Button();
            this.lblVisualizzaRicerca = new System.Windows.Forms.Label();
            this.lblVisualizza = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Key:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome articolo:  ";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(181, 41);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(100, 22);
            this.txtKey.TabIndex = 2;
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(181, 89);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(100, 22);
            this.txtValue.TabIndex = 3;
            // 
            // txtRicerca
            // 
            this.txtRicerca.Location = new System.Drawing.Point(181, 251);
            this.txtRicerca.Name = "txtRicerca";
            this.txtRicerca.Size = new System.Drawing.Size(100, 22);
            this.txtRicerca.TabIndex = 4;
            // 
            // btnInserisci
            // 
            this.btnInserisci.Location = new System.Drawing.Point(43, 146);
            this.btnInserisci.Name = "btnInserisci";
            this.btnInserisci.Size = new System.Drawing.Size(100, 36);
            this.btnInserisci.TabIndex = 5;
            this.btnInserisci.Text = "Inserisci";
            this.btnInserisci.UseVisualStyleBackColor = true;
            this.btnInserisci.Click += new System.EventHandler(this.btnInserisci_Click);
            // 
            // btnVisualizza
            // 
            this.btnVisualizza.Location = new System.Drawing.Point(181, 146);
            this.btnVisualizza.Name = "btnVisualizza";
            this.btnVisualizza.Size = new System.Drawing.Size(100, 36);
            this.btnVisualizza.TabIndex = 6;
            this.btnVisualizza.Text = "Visualizza";
            this.btnVisualizza.UseVisualStyleBackColor = true;
            this.btnVisualizza.Click += new System.EventHandler(this.btnVisualizza_Click);
            // 
            // btnRicerca
            // 
            this.btnRicerca.Location = new System.Drawing.Point(43, 237);
            this.btnRicerca.Name = "btnRicerca";
            this.btnRicerca.Size = new System.Drawing.Size(100, 36);
            this.btnRicerca.TabIndex = 7;
            this.btnRicerca.Text = "Ricerca";
            this.btnRicerca.UseVisualStyleBackColor = true;
            this.btnRicerca.Click += new System.EventHandler(this.btnRicerca_Click);
            // 
            // lblVisualizzaRicerca
            // 
            this.lblVisualizzaRicerca.AutoSize = true;
            this.lblVisualizzaRicerca.Location = new System.Drawing.Point(336, 256);
            this.lblVisualizzaRicerca.Name = "lblVisualizzaRicerca";
            this.lblVisualizzaRicerca.Size = new System.Drawing.Size(88, 17);
            this.lblVisualizzaRicerca.TabIndex = 8;
            this.lblVisualizzaRicerca.Text = "....................";
            // 
            // lblVisualizza
            // 
            this.lblVisualizza.AutoSize = true;
            this.lblVisualizza.Location = new System.Drawing.Point(336, 165);
            this.lblVisualizza.Name = "lblVisualizza";
            this.lblVisualizza.Size = new System.Drawing.Size(88, 17);
            this.lblVisualizza.TabIndex = 9;
            this.lblVisualizza.Text = "....................";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 307);
            this.Controls.Add(this.lblVisualizza);
            this.Controls.Add(this.lblVisualizzaRicerca);
            this.Controls.Add(this.btnRicerca);
            this.Controls.Add(this.btnVisualizza);
            this.Controls.Add(this.btnInserisci);
            this.Controls.Add(this.txtRicerca);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.TextBox txtRicerca;
        private System.Windows.Forms.Button btnInserisci;
        private System.Windows.Forms.Button btnVisualizza;
        private System.Windows.Forms.Button btnRicerca;
        private System.Windows.Forms.Label lblVisualizzaRicerca;
        private System.Windows.Forms.Label lblVisualizza;
    }
}

