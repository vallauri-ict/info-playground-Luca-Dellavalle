namespace MultiformMenùToolStrip
{
    partial class Form2
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
            this.btnLeggiValore = new System.Windows.Forms.Button();
            this.btnInviaF1 = new System.Windows.Forms.Button();
            this.btnFormFiglia = new System.Windows.Forms.Button();
            this.txtForm2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLeggiValore
            // 
            this.btnLeggiValore.Location = new System.Drawing.Point(37, 28);
            this.btnLeggiValore.Name = "btnLeggiValore";
            this.btnLeggiValore.Size = new System.Drawing.Size(131, 50);
            this.btnLeggiValore.TabIndex = 0;
            this.btnLeggiValore.Text = "Leggi valore";
            this.btnLeggiValore.UseVisualStyleBackColor = true;
            this.btnLeggiValore.Click += new System.EventHandler(this.btnLeggiValore_Click_1);
            // 
            // btnInviaF1
            // 
            this.btnInviaF1.Location = new System.Drawing.Point(212, 99);
            this.btnInviaF1.Name = "btnInviaF1";
            this.btnInviaF1.Size = new System.Drawing.Size(131, 50);
            this.btnInviaF1.TabIndex = 1;
            this.btnInviaF1.Text = "invia form 1";
            this.btnInviaF1.UseVisualStyleBackColor = true;
            this.btnInviaF1.Click += new System.EventHandler(this.btnInviaF1_Click_1);
            // 
            // btnFormFiglia
            // 
            this.btnFormFiglia.Location = new System.Drawing.Point(37, 169);
            this.btnFormFiglia.Name = "btnFormFiglia";
            this.btnFormFiglia.Size = new System.Drawing.Size(131, 50);
            this.btnFormFiglia.TabIndex = 2;
            this.btnFormFiglia.Text = "apri form figlia";
            this.btnFormFiglia.UseVisualStyleBackColor = true;
            this.btnFormFiglia.Click += new System.EventHandler(this.btnFormFiglia_Click_1);
            // 
            // txtForm2
            // 
            this.txtForm2.Location = new System.Drawing.Point(37, 113);
            this.txtForm2.Name = "txtForm2";
            this.txtForm2.Size = new System.Drawing.Size(131, 22);
            this.txtForm2.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 255);
            this.Controls.Add(this.txtForm2);
            this.Controls.Add(this.btnFormFiglia);
            this.Controls.Add(this.btnInviaF1);
            this.Controls.Add(this.btnLeggiValore);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLeggiValore;
        private System.Windows.Forms.Button btnInviaF1;
        private System.Windows.Forms.Button btnFormFiglia;
        private System.Windows.Forms.TextBox txtForm2;
    }
}