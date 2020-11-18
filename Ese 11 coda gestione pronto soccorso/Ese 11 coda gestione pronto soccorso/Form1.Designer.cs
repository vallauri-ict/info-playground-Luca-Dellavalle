namespace Ese_11_coda_gestione_pronto_soccorso
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEtà = new System.Windows.Forms.TextBox();
            this.txtCodice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRegistra = new System.Windows.Forms.Button();
            this.btnDaVisitare = new System.Windows.Forms.Button();
            this.lblPaziente = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Età";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(157, 40);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 22);
            this.txtNome.TabIndex = 2;
            // 
            // txtEtà
            // 
            this.txtEtà.Location = new System.Drawing.Point(157, 95);
            this.txtEtà.Name = "txtEtà";
            this.txtEtà.Size = new System.Drawing.Size(100, 22);
            this.txtEtà.TabIndex = 3;
            // 
            // txtCodice
            // 
            this.txtCodice.Location = new System.Drawing.Point(157, 148);
            this.txtCodice.Name = "txtCodice";
            this.txtCodice.Size = new System.Drawing.Size(100, 22);
            this.txtCodice.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Codice";
            // 
            // btnRegistra
            // 
            this.btnRegistra.Location = new System.Drawing.Point(42, 233);
            this.btnRegistra.Name = "btnRegistra";
            this.btnRegistra.Size = new System.Drawing.Size(94, 39);
            this.btnRegistra.TabIndex = 6;
            this.btnRegistra.Text = "Registra";
            this.btnRegistra.UseVisualStyleBackColor = true;
            this.btnRegistra.Click += new System.EventHandler(this.btnRegistra_Click);
            // 
            // btnDaVisitare
            // 
            this.btnDaVisitare.Location = new System.Drawing.Point(42, 304);
            this.btnDaVisitare.Name = "btnDaVisitare";
            this.btnDaVisitare.Size = new System.Drawing.Size(94, 39);
            this.btnDaVisitare.TabIndex = 7;
            this.btnDaVisitare.Text = "Da visitare";
            this.btnDaVisitare.UseVisualStyleBackColor = true;
            this.btnDaVisitare.Click += new System.EventHandler(this.btnDaVisitare_Click);
            // 
            // lblPaziente
            // 
            this.lblPaziente.AutoSize = true;
            this.lblPaziente.Location = new System.Drawing.Point(181, 315);
            this.lblPaziente.Name = "lblPaziente";
            this.lblPaziente.Size = new System.Drawing.Size(44, 17);
            this.lblPaziente.TabIndex = 9;
            this.lblPaziente.Text = ".........";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPaziente);
            this.Controls.Add(this.btnDaVisitare);
            this.Controls.Add(this.btnRegistra);
            this.Controls.Add(this.txtCodice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEtà);
            this.Controls.Add(this.txtNome);
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
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEtà;
        private System.Windows.Forms.TextBox txtCodice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRegistra;
        private System.Windows.Forms.Button btnDaVisitare;
        private System.Windows.Forms.Label lblPaziente;
    }
}

