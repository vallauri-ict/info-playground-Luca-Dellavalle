﻿namespace Ese_24_Primo_esempio_Delegate
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
            this.btnSomma = new System.Windows.Forms.Button();
            this.btnProdotto = new System.Windows.Forms.Button();
            this.btnSottrazione = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSomma
            // 
            this.btnSomma.Location = new System.Drawing.Point(37, 32);
            this.btnSomma.Name = "btnSomma";
            this.btnSomma.Size = new System.Drawing.Size(72, 66);
            this.btnSomma.TabIndex = 0;
            this.btnSomma.Text = "+";
            this.btnSomma.UseVisualStyleBackColor = true;
            this.btnSomma.Click += new System.EventHandler(this.btnSomma_Click);
            // 
            // btnProdotto
            // 
            this.btnProdotto.Location = new System.Drawing.Point(166, 32);
            this.btnProdotto.Name = "btnProdotto";
            this.btnProdotto.Size = new System.Drawing.Size(72, 66);
            this.btnProdotto.TabIndex = 1;
            this.btnProdotto.Text = "*";
            this.btnProdotto.UseVisualStyleBackColor = true;
            this.btnProdotto.Click += new System.EventHandler(this.btnProdotto_Click);
            // 
            // btnSottrazione
            // 
            this.btnSottrazione.Location = new System.Drawing.Point(295, 32);
            this.btnSottrazione.Name = "btnSottrazione";
            this.btnSottrazione.Size = new System.Drawing.Size(72, 66);
            this.btnSottrazione.TabIndex = 2;
            this.btnSottrazione.Text = "-";
            this.btnSottrazione.UseVisualStyleBackColor = true;
            this.btnSottrazione.Click += new System.EventHandler(this.btnSottrazione_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSottrazione);
            this.Controls.Add(this.btnProdotto);
            this.Controls.Add(this.btnSomma);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSomma;
        private System.Windows.Forms.Button btnProdotto;
        private System.Windows.Forms.Button btnSottrazione;
    }
}

