namespace Ese_21_primo_esercizio_interfacce
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
            this.btnConnetti = new System.Windows.Forms.Button();
            this.btnDisconnetti = new System.Windows.Forms.Button();
            this.btnStato = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConnetti
            // 
            this.btnConnetti.Location = new System.Drawing.Point(91, 36);
            this.btnConnetti.Name = "btnConnetti";
            this.btnConnetti.Size = new System.Drawing.Size(106, 57);
            this.btnConnetti.TabIndex = 0;
            this.btnConnetti.Text = "CONNETTI";
            this.btnConnetti.UseVisualStyleBackColor = true;
            this.btnConnetti.Click += new System.EventHandler(this.btnConnetti_Click);
            // 
            // btnDisconnetti
            // 
            this.btnDisconnetti.Location = new System.Drawing.Point(262, 36);
            this.btnDisconnetti.Name = "btnDisconnetti";
            this.btnDisconnetti.Size = new System.Drawing.Size(119, 57);
            this.btnDisconnetti.TabIndex = 1;
            this.btnDisconnetti.Text = "DISCONNETTI";
            this.btnDisconnetti.UseVisualStyleBackColor = true;
            this.btnDisconnetti.Click += new System.EventHandler(this.btnDisconnetti_Click);
            // 
            // btnStato
            // 
            this.btnStato.Location = new System.Drawing.Point(453, 36);
            this.btnStato.Name = "btnStato";
            this.btnStato.Size = new System.Drawing.Size(119, 57);
            this.btnStato.TabIndex = 2;
            this.btnStato.Text = "STATO";
            this.btnStato.UseVisualStyleBackColor = true;
            this.btnStato.Click += new System.EventHandler(this.btnStato_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 149);
            this.Controls.Add(this.btnStato);
            this.Controls.Add(this.btnDisconnetti);
            this.Controls.Add(this.btnConnetti);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConnetti;
        private System.Windows.Forms.Button btnDisconnetti;
        private System.Windows.Forms.Button btnStato;
    }
}

