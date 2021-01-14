namespace Ese_15_OOP_2_complessi_e_quaternoni
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
            this.txtReale = new System.Windows.Forms.TextBox();
            this.txtImmaginario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtImmaginarioD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtImmaginarioC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnModuloComplesso = new System.Windows.Forms.Button();
            this.btnModuloQuaternione = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reale";
            // 
            // txtReale
            // 
            this.txtReale.Location = new System.Drawing.Point(177, 49);
            this.txtReale.Name = "txtReale";
            this.txtReale.Size = new System.Drawing.Size(100, 22);
            this.txtReale.TabIndex = 1;
            // 
            // txtImmaginario
            // 
            this.txtImmaginario.Location = new System.Drawing.Point(177, 93);
            this.txtImmaginario.Name = "txtImmaginario";
            this.txtImmaginario.Size = new System.Drawing.Size(100, 22);
            this.txtImmaginario.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Immaginario";
            // 
            // txtImmaginarioD
            // 
            this.txtImmaginarioD.Location = new System.Drawing.Point(177, 203);
            this.txtImmaginarioD.Name = "txtImmaginarioD";
            this.txtImmaginarioD.Size = new System.Drawing.Size(100, 22);
            this.txtImmaginarioD.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Immaginario D";
            // 
            // txtImmaginarioC
            // 
            this.txtImmaginarioC.Location = new System.Drawing.Point(177, 159);
            this.txtImmaginarioC.Name = "txtImmaginarioC";
            this.txtImmaginarioC.Size = new System.Drawing.Size(100, 22);
            this.txtImmaginarioC.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Immaginario C";
            // 
            // btnModuloComplesso
            // 
            this.btnModuloComplesso.Location = new System.Drawing.Point(78, 293);
            this.btnModuloComplesso.Name = "btnModuloComplesso";
            this.btnModuloComplesso.Size = new System.Drawing.Size(155, 80);
            this.btnModuloComplesso.TabIndex = 12;
            this.btnModuloComplesso.Text = "Modulo complesso";
            this.btnModuloComplesso.UseVisualStyleBackColor = true;
            this.btnModuloComplesso.Click += new System.EventHandler(this.btnModuloComplesso_Click);
            // 
            // btnModuloQuaternione
            // 
            this.btnModuloQuaternione.Location = new System.Drawing.Point(343, 293);
            this.btnModuloQuaternione.Name = "btnModuloQuaternione";
            this.btnModuloQuaternione.Size = new System.Drawing.Size(155, 80);
            this.btnModuloQuaternione.TabIndex = 13;
            this.btnModuloQuaternione.Text = "Modulo Quaternione";
            this.btnModuloQuaternione.UseVisualStyleBackColor = true;
            this.btnModuloQuaternione.Click += new System.EventHandler(this.btnModuloQuaternione_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnModuloQuaternione);
            this.Controls.Add(this.btnModuloComplesso);
            this.Controls.Add(this.txtImmaginarioD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtImmaginarioC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtImmaginario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtReale);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtReale;
        private System.Windows.Forms.TextBox txtImmaginario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtImmaginarioD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtImmaginarioC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnModuloComplesso;
        private System.Windows.Forms.Button btnModuloQuaternione;
    }
}

