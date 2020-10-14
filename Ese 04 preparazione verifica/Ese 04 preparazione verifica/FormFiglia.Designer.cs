namespace Ese_04_preparazione_verifica
{
    partial class FormFiglia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFigliaModifica = new System.Windows.Forms.Button();
            this.txtCampo = new System.Windows.Forms.TextBox();
            this.lblFigliaModifica = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFigliaModifica
            // 
            this.btnFigliaModifica.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnFigliaModifica.Location = new System.Drawing.Point(105, 196);
            this.btnFigliaModifica.Name = "btnFigliaModifica";
            this.btnFigliaModifica.Size = new System.Drawing.Size(143, 67);
            this.btnFigliaModifica.TabIndex = 0;
            this.btnFigliaModifica.Text = "Modifica";
            this.btnFigliaModifica.UseVisualStyleBackColor = true;
            this.btnFigliaModifica.Click += new System.EventHandler(this.btnFigliaModifica_Click);
            // 
            // txtCampo
            // 
            this.txtCampo.Location = new System.Drawing.Point(125, 129);
            this.txtCampo.Name = "txtCampo";
            this.txtCampo.Size = new System.Drawing.Size(100, 22);
            this.txtCampo.TabIndex = 1;
            // 
            // lblFigliaModifica
            // 
            this.lblFigliaModifica.AutoSize = true;
            this.lblFigliaModifica.Location = new System.Drawing.Point(79, 82);
            this.lblFigliaModifica.Name = "lblFigliaModifica";
            this.lblFigliaModifica.Size = new System.Drawing.Size(201, 17);
            this.lblFigliaModifica.TabIndex = 2;
            this.lblFigliaModifica.Text = "Inserire il testo da modificare : ";
            // 
            // FormFiglia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 349);
            this.Controls.Add(this.lblFigliaModifica);
            this.Controls.Add(this.txtCampo);
            this.Controls.Add(this.btnFigliaModifica);
            this.Name = "FormFiglia";
            this.Text = "FormFiglia";
            this.Load += new System.EventHandler(this.FormFiglia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFigliaModifica;
        private System.Windows.Forms.TextBox txtCampo;
        private System.Windows.Forms.Label lblFigliaModifica;
    }
}