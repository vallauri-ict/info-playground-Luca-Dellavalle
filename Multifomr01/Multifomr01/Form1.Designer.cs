﻿namespace Multifomr01
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
            this.btnForm2 = new System.Windows.Forms.Button();
            this.btnApriForm2b = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnForm2
            // 
            this.btnForm2.Location = new System.Drawing.Point(41, 34);
            this.btnForm2.Name = "btnForm2";
            this.btnForm2.Size = new System.Drawing.Size(85, 29);
            this.btnForm2.TabIndex = 0;
            this.btnForm2.Text = "apri form 2";
            this.btnForm2.UseVisualStyleBackColor = true;
            this.btnForm2.Click += new System.EventHandler(this.btnForm2_Click);
            // 
            // btnApriForm2b
            // 
            this.btnApriForm2b.Location = new System.Drawing.Point(152, 34);
            this.btnApriForm2b.Name = "btnApriForm2b";
            this.btnApriForm2b.Size = new System.Drawing.Size(103, 29);
            this.btnApriForm2b.TabIndex = 1;
            this.btnApriForm2b.Text = "apri form 2b";
            this.btnApriForm2b.UseVisualStyleBackColor = true;
            this.btnApriForm2b.Click += new System.EventHandler(this.btnApriForm2b_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnApriForm2b);
            this.Controls.Add(this.btnForm2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnForm2;
        private System.Windows.Forms.Button btnApriForm2b;
    }
}

