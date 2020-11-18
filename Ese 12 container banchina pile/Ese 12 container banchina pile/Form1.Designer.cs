namespace Ese_12_container_banchina_pile
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
            this.lblContainer = new System.Windows.Forms.Label();
            this.btnDaScaricare = new System.Windows.Forms.Button();
            this.btnCarica = new System.Windows.Forms.Button();
            this.txtTara = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtCodice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblContainer
            // 
            this.lblContainer.AutoSize = true;
            this.lblContainer.Location = new System.Drawing.Point(179, 294);
            this.lblContainer.Name = "lblContainer";
            this.lblContainer.Size = new System.Drawing.Size(44, 17);
            this.lblContainer.TabIndex = 18;
            this.lblContainer.Text = ".........";
            // 
            // btnDaScaricare
            // 
            this.btnDaScaricare.Location = new System.Drawing.Point(40, 283);
            this.btnDaScaricare.Name = "btnDaScaricare";
            this.btnDaScaricare.Size = new System.Drawing.Size(109, 39);
            this.btnDaScaricare.TabIndex = 17;
            this.btnDaScaricare.Text = "scaricamento";
            this.btnDaScaricare.UseVisualStyleBackColor = true;
            this.btnDaScaricare.Click += new System.EventHandler(this.btnDaScaricare_Click);
            // 
            // btnCarica
            // 
            this.btnCarica.Location = new System.Drawing.Point(40, 212);
            this.btnCarica.Name = "btnCarica";
            this.btnCarica.Size = new System.Drawing.Size(94, 39);
            this.btnCarica.TabIndex = 16;
            this.btnCarica.Text = "Carica";
            this.btnCarica.UseVisualStyleBackColor = true;
            this.btnCarica.Click += new System.EventHandler(this.btnCarica_Click);
            // 
            // txtTara
            // 
            this.txtTara.Location = new System.Drawing.Point(155, 127);
            this.txtTara.Name = "txtTara";
            this.txtTara.Size = new System.Drawing.Size(100, 22);
            this.txtTara.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tara";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(155, 74);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 22);
            this.txtPeso.TabIndex = 13;
            // 
            // txtCodice
            // 
            this.txtCodice.Location = new System.Drawing.Point(155, 19);
            this.txtCodice.Name = "txtCodice";
            this.txtCodice.Size = new System.Drawing.Size(100, 22);
            this.txtCodice.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Peso";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Codice";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 347);
            this.Controls.Add(this.lblContainer);
            this.Controls.Add(this.btnDaScaricare);
            this.Controls.Add(this.btnCarica);
            this.Controls.Add(this.txtTara);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtCodice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblContainer;
        private System.Windows.Forms.Button btnDaScaricare;
        private System.Windows.Forms.Button btnCarica;
        private System.Windows.Forms.TextBox txtTara;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtCodice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

