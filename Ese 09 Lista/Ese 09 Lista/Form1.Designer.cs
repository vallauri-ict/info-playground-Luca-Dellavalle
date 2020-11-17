namespace Ese_09_Lista
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitolo = new System.Windows.Forms.TextBox();
            this.txtAutore = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVisualizza = new System.Windows.Forms.Button();
            this.btnVisualizzaobj = new System.Windows.Forms.Button();
            this.btnAggiungiObj = new System.Windows.Forms.Button();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tnFindAll = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnVisDizionario = new System.Windows.Forms.Button();
            this.btnDizionario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(43, 173);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(148, 43);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "aggiungi";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Titolo";
            // 
            // txtTitolo
            // 
            this.txtTitolo.Location = new System.Drawing.Point(182, 30);
            this.txtTitolo.Name = "txtTitolo";
            this.txtTitolo.Size = new System.Drawing.Size(100, 22);
            this.txtTitolo.TabIndex = 2;
            // 
            // txtAutore
            // 
            this.txtAutore.Location = new System.Drawing.Point(182, 72);
            this.txtAutore.Name = "txtAutore";
            this.txtAutore.Size = new System.Drawing.Size(100, 22);
            this.txtAutore.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Autore";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(182, 114);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "ID";
            // 
            // btnVisualizza
            // 
            this.btnVisualizza.Location = new System.Drawing.Point(237, 173);
            this.btnVisualizza.Name = "btnVisualizza";
            this.btnVisualizza.Size = new System.Drawing.Size(148, 43);
            this.btnVisualizza.TabIndex = 7;
            this.btnVisualizza.Text = "visualizza";
            this.btnVisualizza.UseVisualStyleBackColor = true;
            this.btnVisualizza.Click += new System.EventHandler(this.btnVisualizza_Click);
            // 
            // btnVisualizzaobj
            // 
            this.btnVisualizzaobj.Location = new System.Drawing.Point(237, 231);
            this.btnVisualizzaobj.Name = "btnVisualizzaobj";
            this.btnVisualizzaobj.Size = new System.Drawing.Size(148, 41);
            this.btnVisualizzaobj.TabIndex = 10;
            this.btnVisualizzaobj.Text = "visualizza obj";
            this.btnVisualizzaobj.UseVisualStyleBackColor = true;
            this.btnVisualizzaobj.Click += new System.EventHandler(this.btnVisualizzaobj_Click);
            // 
            // btnAggiungiObj
            // 
            this.btnAggiungiObj.Location = new System.Drawing.Point(43, 231);
            this.btnAggiungiObj.Name = "btnAggiungiObj";
            this.btnAggiungiObj.Size = new System.Drawing.Size(148, 41);
            this.btnAggiungiObj.TabIndex = 9;
            this.btnAggiungiObj.Text = "aggiungi in obj";
            this.btnAggiungiObj.UseVisualStyleBackColor = true;
            this.btnAggiungiObj.Click += new System.EventHandler(this.btnAggiungiObj_Click);
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(237, 309);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(100, 22);
            this.txtFind.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Titolo / Autore";
            // 
            // tnFindAll
            // 
            this.tnFindAll.Location = new System.Drawing.Point(237, 367);
            this.tnFindAll.Name = "tnFindAll";
            this.tnFindAll.Size = new System.Drawing.Size(148, 41);
            this.tnFindAll.TabIndex = 14;
            this.tnFindAll.Text = "FindAll";
            this.tnFindAll.UseVisualStyleBackColor = true;
            this.tnFindAll.Click += new System.EventHandler(this.tnFindAll_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(43, 367);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(148, 41);
            this.btnFind.TabIndex = 13;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnVisDizionario
            // 
            this.btnVisDizionario.Location = new System.Drawing.Point(630, 367);
            this.btnVisDizionario.Name = "btnVisDizionario";
            this.btnVisDizionario.Size = new System.Drawing.Size(148, 41);
            this.btnVisDizionario.TabIndex = 16;
            this.btnVisDizionario.Text = "Visualizza dizionario";
            this.btnVisDizionario.UseVisualStyleBackColor = true;
            this.btnVisDizionario.Click += new System.EventHandler(this.btnVisDizionario_Click);
            // 
            // btnDizionario
            // 
            this.btnDizionario.Location = new System.Drawing.Point(436, 367);
            this.btnDizionario.Name = "btnDizionario";
            this.btnDizionario.Size = new System.Drawing.Size(148, 41);
            this.btnDizionario.TabIndex = 15;
            this.btnDizionario.Text = "Dictionary";
            this.btnDizionario.UseVisualStyleBackColor = true;
            this.btnDizionario.Click += new System.EventHandler(this.btnDizionario_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVisDizionario);
            this.Controls.Add(this.btnDizionario);
            this.Controls.Add(this.tnFindAll);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnVisualizzaobj);
            this.Controls.Add(this.btnAggiungiObj);
            this.Controls.Add(this.btnVisualizza);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAutore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitolo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitolo;
        private System.Windows.Forms.TextBox txtAutore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVisualizza;
        private System.Windows.Forms.Button btnVisualizzaobj;
        private System.Windows.Forms.Button btnAggiungiObj;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button tnFindAll;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnVisDizionario;
        private System.Windows.Forms.Button btnDizionario;
    }
}

