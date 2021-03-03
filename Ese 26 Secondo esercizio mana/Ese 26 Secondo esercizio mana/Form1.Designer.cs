namespace Ese_26_Secondo_esercizio_mana
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
            this.txtMaxValue = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnIncrementare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMaxValue
            // 
            this.txtMaxValue.Location = new System.Drawing.Point(27, 22);
            this.txtMaxValue.Name = "txtMaxValue";
            this.txtMaxValue.Size = new System.Drawing.Size(100, 22);
            this.txtMaxValue.TabIndex = 0;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(27, 72);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(100, 36);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnIncrementare
            // 
            this.btnIncrementare.Location = new System.Drawing.Point(27, 124);
            this.btnIncrementare.Name = "btnIncrementare";
            this.btnIncrementare.Size = new System.Drawing.Size(100, 37);
            this.btnIncrementare.TabIndex = 2;
            this.btnIncrementare.Text = "Increment";
            this.btnIncrementare.UseVisualStyleBackColor = true;
            this.btnIncrementare.Click += new System.EventHandler(this.btnIncrementare_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIncrementare);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtMaxValue);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaxValue;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnIncrementare;
    }
}

