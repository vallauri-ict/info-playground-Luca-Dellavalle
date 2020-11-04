namespace Ese_07_Classe_indexata
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
            this.btnCreaClasse = new System.Windows.Forms.Button();
            this.txtElementi = new System.Windows.Forms.TextBox();
            this.btnVisualizza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreaClasse
            // 
            this.btnCreaClasse.Location = new System.Drawing.Point(25, 67);
            this.btnCreaClasse.Name = "btnCreaClasse";
            this.btnCreaClasse.Size = new System.Drawing.Size(80, 35);
            this.btnCreaClasse.TabIndex = 0;
            this.btnCreaClasse.Text = "CREA";
            this.btnCreaClasse.UseVisualStyleBackColor = true;
            this.btnCreaClasse.Click += new System.EventHandler(this.btnCreaClasse_Click);
            // 
            // txtElementi
            // 
            this.txtElementi.Location = new System.Drawing.Point(25, 26);
            this.txtElementi.Name = "txtElementi";
            this.txtElementi.Size = new System.Drawing.Size(100, 22);
            this.txtElementi.TabIndex = 1;
            // 
            // btnVisualizza
            // 
            this.btnVisualizza.Location = new System.Drawing.Point(25, 123);
            this.btnVisualizza.Name = "btnVisualizza";
            this.btnVisualizza.Size = new System.Drawing.Size(109, 32);
            this.btnVisualizza.TabIndex = 2;
            this.btnVisualizza.Text = "VISUALIZZA";
            this.btnVisualizza.UseVisualStyleBackColor = true;
            this.btnVisualizza.Click += new System.EventHandler(this.btnVisualizza_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 266);
            this.Controls.Add(this.btnVisualizza);
            this.Controls.Add(this.txtElementi);
            this.Controls.Add(this.btnCreaClasse);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreaClasse;
        private System.Windows.Forms.TextBox txtElementi;
        private System.Windows.Forms.Button btnVisualizza;
    }
}

