namespace Multifomr01
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
            this.btnFigliadiChi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFigliadiChi
            // 
            this.btnFigliadiChi.Location = new System.Drawing.Point(101, 34);
            this.btnFigliadiChi.Name = "btnFigliadiChi";
            this.btnFigliadiChi.Size = new System.Drawing.Size(143, 62);
            this.btnFigliadiChi.TabIndex = 0;
            this.btnFigliadiChi.Text = "di chi sono figlia?";
            this.btnFigliadiChi.UseVisualStyleBackColor = true;
            this.btnFigliadiChi.Click += new System.EventHandler(this.btnFigliadiChi_Click);
            // 
            // FormFiglia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 370);
            this.Controls.Add(this.btnFigliadiChi);
            this.Name = "FormFiglia";
            this.Text = "FormFiglia";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFigliadiChi;
    }
}