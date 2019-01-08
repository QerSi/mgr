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
            this.btnOblicz = new System.Windows.Forms.Button();
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
            // OknoGlowne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 304);
            this.Controls.Add(this.btnOblicz);
            this.Controls.Add(this.txtSciezka);
            this.Controls.Add(this.btnWczytajPlik);
            this.Name = "OknoGlowne";
            this.Text = "Ocena Klasyfikacji";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWczytajPlik;
        private System.Windows.Forms.TextBox txtSciezka;
        private System.Windows.Forms.OpenFileDialog opfWczytaj;
        private System.Windows.Forms.Button btnOblicz;
    }
}

