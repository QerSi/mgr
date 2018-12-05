namespace PracaMgr
{
    partial class OknoGlowne
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnWczytajPlik = new System.Windows.Forms.Button();
            this.txtSciezka = new System.Windows.Forms.TextBox();
            this.opfWczytaj = new System.Windows.Forms.OpenFileDialog();
            this.cbMiary = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOblicz = new System.Windows.Forms.Button();
            this.txtMiara = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnWczytajPlik
            // 
            this.btnWczytajPlik.Location = new System.Drawing.Point(274, 35);
            this.btnWczytajPlik.Name = "btnWczytajPlik";
            this.btnWczytajPlik.Size = new System.Drawing.Size(75, 23);
            this.btnWczytajPlik.TabIndex = 0;
            this.btnWczytajPlik.Text = "Wczytaj";
            this.btnWczytajPlik.UseVisualStyleBackColor = true;
            this.btnWczytajPlik.Click += new System.EventHandler(this.btnWczytajPlik_Click);
            // 
            // txtSciezka
            // 
            this.txtSciezka.Location = new System.Drawing.Point(12, 37);
            this.txtSciezka.Name = "txtSciezka";
            this.txtSciezka.Size = new System.Drawing.Size(256, 20);
            this.txtSciezka.TabIndex = 1;
            // 
            // opfWczytaj
            // 
            this.opfWczytaj.FileName = "openFileDialog1";
            // 
            // cbMiary
            // 
            this.cbMiary.FormattingEnabled = true;
            this.cbMiary.Location = new System.Drawing.Point(12, 88);
            this.cbMiary.Name = "cbMiary";
            this.cbMiary.Size = new System.Drawing.Size(121, 21);
            this.cbMiary.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Miara";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnOblicz
            // 
            this.btnOblicz.Location = new System.Drawing.Point(132, 155);
            this.btnOblicz.Name = "btnOblicz";
            this.btnOblicz.Size = new System.Drawing.Size(75, 23);
            this.btnOblicz.TabIndex = 4;
            this.btnOblicz.Text = "Oblicz";
            this.btnOblicz.UseVisualStyleBackColor = true;
            this.btnOblicz.Click += new System.EventHandler(this.btnOblicz_Click);
            // 
            // txtMiara
            // 
            this.txtMiara.Location = new System.Drawing.Point(208, 89);
            this.txtMiara.Name = "txtMiara";
            this.txtMiara.Size = new System.Drawing.Size(141, 20);
            this.txtMiara.TabIndex = 5;
            this.txtMiara.TextChanged += new System.EventHandler(this.txtMiara_TextChanged);
            this.txtMiara.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Granica";
            // 
            // OknoGlowne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 304);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMiara);
            this.Controls.Add(this.btnOblicz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbMiary);
            this.Controls.Add(this.txtSciezka);
            this.Controls.Add(this.btnWczytajPlik);
            this.Name = "OknoGlowne";
            this.Text = "Ocena Klasyfikacji";
            this.Load += new System.EventHandler(this.OknoGlowne_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWczytajPlik;
        private System.Windows.Forms.TextBox txtSciezka;
        private System.Windows.Forms.OpenFileDialog opfWczytaj;
        private System.Windows.Forms.ComboBox cbMiary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOblicz;
        private System.Windows.Forms.TextBox txtMiara;
        private System.Windows.Forms.Label label2;
    }
}

