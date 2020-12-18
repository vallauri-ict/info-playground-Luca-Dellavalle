namespace Ese_14_OOP_1_persone_studenti
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSesso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCaricaLista = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.txtVoto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnInserisciVoto = new System.Windows.Forms.Button();
            this.btnVisualizza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(172, 34);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 22);
            this.txtNome.TabIndex = 1;
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(172, 67);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(100, 22);
            this.txtCognome.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cognome";
            // 
            // txtSesso
            // 
            this.txtSesso.Location = new System.Drawing.Point(172, 136);
            this.txtSesso.Name = "txtSesso";
            this.txtSesso.Size = new System.Drawing.Size(100, 22);
            this.txtSesso.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sesso";
            // 
            // txtEta
            // 
            this.txtEta.Location = new System.Drawing.Point(172, 101);
            this.txtEta.Name = "txtEta";
            this.txtEta.Size = new System.Drawing.Size(100, 22);
            this.txtEta.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Età";
            // 
            // btnCaricaLista
            // 
            this.btnCaricaLista.Location = new System.Drawing.Point(325, 34);
            this.btnCaricaLista.Name = "btnCaricaLista";
            this.btnCaricaLista.Size = new System.Drawing.Size(109, 68);
            this.btnCaricaLista.TabIndex = 8;
            this.btnCaricaLista.Text = "CARICA";
            this.btnCaricaLista.UseVisualStyleBackColor = true;
            this.btnCaricaLista.Click += new System.EventHandler(this.btnCaricaLista_Click);
            // 
            // listView
            // 
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(455, 34);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(309, 394);
            this.listView.TabIndex = 9;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.List;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // txtVoto
            // 
            this.txtVoto.Location = new System.Drawing.Point(172, 211);
            this.txtVoto.Name = "txtVoto";
            this.txtVoto.Size = new System.Drawing.Size(100, 22);
            this.txtVoto.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Voto";
            // 
            // btnInserisciVoto
            // 
            this.btnInserisciVoto.Location = new System.Drawing.Point(325, 202);
            this.btnInserisciVoto.Name = "btnInserisciVoto";
            this.btnInserisciVoto.Size = new System.Drawing.Size(109, 68);
            this.btnInserisciVoto.TabIndex = 12;
            this.btnInserisciVoto.Text = "INSERISCI VOTO";
            this.btnInserisciVoto.UseVisualStyleBackColor = true;
            this.btnInserisciVoto.Click += new System.EventHandler(this.btnInserisciVoto_Click);
            // 
            // btnVisualizza
            // 
            this.btnVisualizza.Location = new System.Drawing.Point(325, 116);
            this.btnVisualizza.Name = "btnVisualizza";
            this.btnVisualizza.Size = new System.Drawing.Size(109, 68);
            this.btnVisualizza.TabIndex = 13;
            this.btnVisualizza.Text = "VISUALIZZA";
            this.btnVisualizza.UseVisualStyleBackColor = true;
            this.btnVisualizza.Click += new System.EventHandler(this.btnVisualizza_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVisualizza);
            this.Controls.Add(this.btnInserisciVoto);
            this.Controls.Add(this.txtVoto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.btnCaricaLista);
            this.Controls.Add(this.txtEta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSesso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCognome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSesso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCaricaLista;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.TextBox txtVoto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnInserisciVoto;
        private System.Windows.Forms.Button btnVisualizza;
    }
}

