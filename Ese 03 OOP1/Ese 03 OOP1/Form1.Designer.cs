﻿namespace Ese_03_OOP1
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
            this.txtBase = new System.Windows.Forms.TextBox();
            this.txtAltezza = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCreaRettangolo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Base";
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(91, 22);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(100, 22);
            this.txtBase.TabIndex = 2;
            // 
            // txtAltezza
            // 
            this.txtAltezza.Location = new System.Drawing.Point(91, 57);
            this.txtAltezza.Name = "txtAltezza";
            this.txtAltezza.Size = new System.Drawing.Size(100, 22);
            this.txtAltezza.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Altezza";
            // 
            // btnCreaRettangolo
            // 
            this.btnCreaRettangolo.Location = new System.Drawing.Point(36, 99);
            this.btnCreaRettangolo.Name = "btnCreaRettangolo";
            this.btnCreaRettangolo.Size = new System.Drawing.Size(92, 41);
            this.btnCreaRettangolo.TabIndex = 5;
            this.btnCreaRettangolo.Text = "Crea";
            this.btnCreaRettangolo.UseVisualStyleBackColor = true;
            this.btnCreaRettangolo.Click += new System.EventHandler(this.btnCreaRettangolo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 187);
            this.Controls.Add(this.btnCreaRettangolo);
            this.Controls.Add(this.txtAltezza);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.TextBox txtAltezza;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCreaRettangolo;
    }
}

