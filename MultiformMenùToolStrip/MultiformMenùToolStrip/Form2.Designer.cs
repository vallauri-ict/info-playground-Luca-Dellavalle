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
            this.components = new System.ComponentModel.Container();
            this.btnLeggiValore = new System.Windows.Forms.Button();
            this.btnInviaF1 = new System.Windows.Forms.Button();
            this.btnFormFiglia = new System.Windows.Forms.Button();
            this.txtForm2 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menùToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apriFormFigliaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inviaTxtForm1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.leggiValoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
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
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menùToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(369, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menùToolStripMenuItem
            // 
            this.menùToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.apriFormFigliaToolStripMenuItem,
            this.inviaTxtForm1ToolStripMenuItem,
            this.leggiValoreToolStripMenuItem});
            this.menùToolStripMenuItem.Name = "menùToolStripMenuItem";
            this.menùToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menùToolStripMenuItem.Text = "Menù";
            // 
            // apriFormFigliaToolStripMenuItem
            // 
            this.apriFormFigliaToolStripMenuItem.Name = "apriFormFigliaToolStripMenuItem";
            this.apriFormFigliaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.apriFormFigliaToolStripMenuItem.Text = "apri form figlia";
            this.apriFormFigliaToolStripMenuItem.Click += new System.EventHandler(this.apriFormFigliaToolStripMenuItem_Click);
            // 
            // inviaTxtForm1ToolStripMenuItem
            // 
            this.inviaTxtForm1ToolStripMenuItem.Name = "inviaTxtForm1ToolStripMenuItem";
            this.inviaTxtForm1ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.inviaTxtForm1ToolStripMenuItem.Text = "invia txt form 1";
            this.inviaTxtForm1ToolStripMenuItem.Click += new System.EventHandler(this.inviaTxtForm1ToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // leggiValoreToolStripMenuItem
            // 
            this.leggiValoreToolStripMenuItem.Name = "leggiValoreToolStripMenuItem";
            this.leggiValoreToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.leggiValoreToolStripMenuItem.Text = "leggi valore";
            this.leggiValoreToolStripMenuItem.Click += new System.EventHandler(this.leggiValoreToolStripMenuItem_Click);
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
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLeggiValore;
        private System.Windows.Forms.Button btnInviaF1;
        private System.Windows.Forms.Button btnFormFiglia;
        private System.Windows.Forms.TextBox txtForm2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menùToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apriFormFigliaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inviaTxtForm1ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem leggiValoreToolStripMenuItem;
    }
}