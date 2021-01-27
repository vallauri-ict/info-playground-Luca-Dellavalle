namespace Ese_20_Stagisti
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.lblCognome = new System.Windows.Forms.Label();
            this.txtCittà = new System.Windows.Forms.TextBox();
            this.lblCittà = new System.Windows.Forms.Label();
            this.lblClasse = new System.Windows.Forms.Label();
            this.cmbClasse = new System.Windows.Forms.ComboBox();
            this.cmbAzienda = new System.Windows.Forms.ComboBox();
            this.lblAziende = new System.Windows.Forms.Label();
            this.cmbSezione = new System.Windows.Forms.ComboBox();
            this.lblSezione = new System.Windows.Forms.Label();
            this.cmbSpec = new System.Windows.Forms.ComboBox();
            this.lblSpecializzazione = new System.Windows.Forms.Label();
            this.txtOreStage = new System.Windows.Forms.TextBox();
            this.lblOre = new System.Windows.Forms.Label();
            this.btnInserisci = new System.Windows.Forms.Button();
            this.btnRicerca = new System.Windows.Forms.Button();
            this.dgvStagisti = new System.Windows.Forms.DataGridView();
            this.btnElimina = new System.Windows.Forms.Button();
            this.txtElimina = new System.Windows.Forms.TextBox();
            this.lblPosizione = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStagisti)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(29, 22);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(45, 17);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(123, 22);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(126, 22);
            this.txtNome.TabIndex = 1;
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(123, 57);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(126, 22);
            this.txtCognome.TabIndex = 3;
            // 
            // lblCognome
            // 
            this.lblCognome.AutoSize = true;
            this.lblCognome.Location = new System.Drawing.Point(29, 57);
            this.lblCognome.Name = "lblCognome";
            this.lblCognome.Size = new System.Drawing.Size(68, 17);
            this.lblCognome.TabIndex = 2;
            this.lblCognome.Text = "Cognome";
            // 
            // txtCittà
            // 
            this.txtCittà.Location = new System.Drawing.Point(123, 96);
            this.txtCittà.Name = "txtCittà";
            this.txtCittà.Size = new System.Drawing.Size(126, 22);
            this.txtCittà.TabIndex = 5;
            // 
            // lblCittà
            // 
            this.lblCittà.AutoSize = true;
            this.lblCittà.Location = new System.Drawing.Point(29, 96);
            this.lblCittà.Name = "lblCittà";
            this.lblCittà.Size = new System.Drawing.Size(36, 17);
            this.lblCittà.TabIndex = 4;
            this.lblCittà.Text = "Città";
            // 
            // lblClasse
            // 
            this.lblClasse.AutoSize = true;
            this.lblClasse.Location = new System.Drawing.Point(29, 134);
            this.lblClasse.Name = "lblClasse";
            this.lblClasse.Size = new System.Drawing.Size(50, 17);
            this.lblClasse.TabIndex = 6;
            this.lblClasse.Text = "Classe";
            // 
            // cmbClasse
            // 
            this.cmbClasse.FormattingEnabled = true;
            this.cmbClasse.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbClasse.Location = new System.Drawing.Point(123, 131);
            this.cmbClasse.Name = "cmbClasse";
            this.cmbClasse.Size = new System.Drawing.Size(159, 24);
            this.cmbClasse.TabIndex = 7;
            // 
            // cmbAzienda
            // 
            this.cmbAzienda.FormattingEnabled = true;
            this.cmbAzienda.Items.AddRange(new object[] {
            "Azienda 1",
            "Azienda 2",
            "Azienda 3"});
            this.cmbAzienda.Location = new System.Drawing.Point(544, 96);
            this.cmbAzienda.Name = "cmbAzienda";
            this.cmbAzienda.Size = new System.Drawing.Size(159, 24);
            this.cmbAzienda.TabIndex = 9;
            // 
            // lblAziende
            // 
            this.lblAziende.AutoSize = true;
            this.lblAziende.Location = new System.Drawing.Point(450, 99);
            this.lblAziende.Name = "lblAziende";
            this.lblAziende.Size = new System.Drawing.Size(59, 17);
            this.lblAziende.TabIndex = 8;
            this.lblAziende.Text = "Azienda";
            // 
            // cmbSezione
            // 
            this.cmbSezione.FormattingEnabled = true;
            this.cmbSezione.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cmbSezione.Location = new System.Drawing.Point(544, 19);
            this.cmbSezione.Name = "cmbSezione";
            this.cmbSezione.Size = new System.Drawing.Size(159, 24);
            this.cmbSezione.TabIndex = 11;
            // 
            // lblSezione
            // 
            this.lblSezione.AutoSize = true;
            this.lblSezione.Location = new System.Drawing.Point(450, 22);
            this.lblSezione.Name = "lblSezione";
            this.lblSezione.Size = new System.Drawing.Size(59, 17);
            this.lblSezione.TabIndex = 10;
            this.lblSezione.Text = "Sezione";
            // 
            // cmbSpec
            // 
            this.cmbSpec.FormattingEnabled = true;
            this.cmbSpec.Items.AddRange(new object[] {
            "INF",
            "MEC",
            "ELT"});
            this.cmbSpec.Location = new System.Drawing.Point(544, 54);
            this.cmbSpec.Name = "cmbSpec";
            this.cmbSpec.Size = new System.Drawing.Size(159, 24);
            this.cmbSpec.TabIndex = 13;
            // 
            // lblSpecializzazione
            // 
            this.lblSpecializzazione.AutoSize = true;
            this.lblSpecializzazione.Location = new System.Drawing.Point(450, 57);
            this.lblSpecializzazione.Name = "lblSpecializzazione";
            this.lblSpecializzazione.Size = new System.Drawing.Size(40, 17);
            this.lblSpecializzazione.TabIndex = 12;
            this.lblSpecializzazione.Text = "Spec";
            // 
            // txtOreStage
            // 
            this.txtOreStage.Location = new System.Drawing.Point(544, 134);
            this.txtOreStage.Name = "txtOreStage";
            this.txtOreStage.Size = new System.Drawing.Size(126, 22);
            this.txtOreStage.TabIndex = 15;
            // 
            // lblOre
            // 
            this.lblOre.AutoSize = true;
            this.lblOre.Location = new System.Drawing.Point(450, 134);
            this.lblOre.Name = "lblOre";
            this.lblOre.Size = new System.Drawing.Size(32, 17);
            this.lblOre.TabIndex = 14;
            this.lblOre.Text = "Ore";
            // 
            // btnInserisci
            // 
            this.btnInserisci.Location = new System.Drawing.Point(32, 185);
            this.btnInserisci.Name = "btnInserisci";
            this.btnInserisci.Size = new System.Drawing.Size(145, 43);
            this.btnInserisci.TabIndex = 16;
            this.btnInserisci.Text = "INSERISCI";
            this.btnInserisci.UseVisualStyleBackColor = true;
            // 
            // btnRicerca
            // 
            this.btnRicerca.Location = new System.Drawing.Point(534, 185);
            this.btnRicerca.Name = "btnRicerca";
            this.btnRicerca.Size = new System.Drawing.Size(145, 43);
            this.btnRicerca.TabIndex = 17;
            this.btnRicerca.Text = "RICERCA";
            this.btnRicerca.UseVisualStyleBackColor = true;
            // 
            // dgvStagisti
            // 
            this.dgvStagisti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStagisti.Location = new System.Drawing.Point(32, 262);
            this.dgvStagisti.Name = "dgvStagisti";
            this.dgvStagisti.RowHeadersWidth = 51;
            this.dgvStagisti.RowTemplate.Height = 24;
            this.dgvStagisti.Size = new System.Drawing.Size(705, 251);
            this.dgvStagisti.TabIndex = 18;
            // 
            // btnElimina
            // 
            this.btnElimina.Location = new System.Drawing.Point(32, 529);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(145, 43);
            this.btnElimina.TabIndex = 19;
            this.btnElimina.Text = "ELIMINA";
            this.btnElimina.UseVisualStyleBackColor = true;
            // 
            // txtElimina
            // 
            this.txtElimina.Location = new System.Drawing.Point(383, 539);
            this.txtElimina.Name = "txtElimina";
            this.txtElimina.Size = new System.Drawing.Size(126, 22);
            this.txtElimina.TabIndex = 21;
            // 
            // lblPosizione
            // 
            this.lblPosizione.AutoSize = true;
            this.lblPosizione.Location = new System.Drawing.Point(289, 539);
            this.lblPosizione.Name = "lblPosizione";
            this.lblPosizione.Size = new System.Drawing.Size(69, 17);
            this.lblPosizione.TabIndex = 20;
            this.lblPosizione.Text = "Posizione";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 584);
            this.Controls.Add(this.txtElimina);
            this.Controls.Add(this.lblPosizione);
            this.Controls.Add(this.btnElimina);
            this.Controls.Add(this.dgvStagisti);
            this.Controls.Add(this.btnRicerca);
            this.Controls.Add(this.btnInserisci);
            this.Controls.Add(this.txtOreStage);
            this.Controls.Add(this.lblOre);
            this.Controls.Add(this.cmbSpec);
            this.Controls.Add(this.lblSpecializzazione);
            this.Controls.Add(this.cmbSezione);
            this.Controls.Add(this.lblSezione);
            this.Controls.Add(this.cmbAzienda);
            this.Controls.Add(this.lblAziende);
            this.Controls.Add(this.cmbClasse);
            this.Controls.Add(this.lblClasse);
            this.Controls.Add(this.txtCittà);
            this.Controls.Add(this.lblCittà);
            this.Controls.Add(this.txtCognome);
            this.Controls.Add(this.lblCognome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStagisti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.Label lblCognome;
        private System.Windows.Forms.TextBox txtCittà;
        private System.Windows.Forms.Label lblCittà;
        private System.Windows.Forms.Label lblClasse;
        private System.Windows.Forms.ComboBox cmbClasse;
        private System.Windows.Forms.ComboBox cmbAzienda;
        private System.Windows.Forms.Label lblAziende;
        private System.Windows.Forms.ComboBox cmbSezione;
        private System.Windows.Forms.Label lblSezione;
        private System.Windows.Forms.ComboBox cmbSpec;
        private System.Windows.Forms.Label lblSpecializzazione;
        private System.Windows.Forms.TextBox txtOreStage;
        private System.Windows.Forms.Label lblOre;
        private System.Windows.Forms.Button btnInserisci;
        private System.Windows.Forms.Button btnRicerca;
        private System.Windows.Forms.DataGridView dgvStagisti;
        private System.Windows.Forms.Button btnElimina;
        private System.Windows.Forms.TextBox txtElimina;
        private System.Windows.Forms.Label lblPosizione;
    }
}

