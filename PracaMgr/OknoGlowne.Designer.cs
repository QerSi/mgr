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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OknoGlowne));
            this.btnWczytajPlik = new System.Windows.Forms.Button();
            this.txtSciezka = new System.Windows.Forms.TextBox();
            this.opfWczytaj = new System.Windows.Forms.OpenFileDialog();
            this.btnOblicz = new System.Windows.Forms.Button();
            this.txtDecyzje = new System.Windows.Forms.TextBox();
            this.btDecyzje = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnWczytajPlik
            // 
            this.btnWczytajPlik.Location = new System.Drawing.Point(288, 199);
            this.btnWczytajPlik.Name = "btnWczytajPlik";
            this.btnWczytajPlik.Size = new System.Drawing.Size(75, 23);
            this.btnWczytajPlik.TabIndex = 0;
            this.btnWczytajPlik.Text = "Wczytaj";
            this.btnWczytajPlik.UseVisualStyleBackColor = true;
            this.btnWczytajPlik.Click += new System.EventHandler(this.btnWczytajPlik_Click);
            // 
            // txtSciezka
            // 
            this.txtSciezka.Enabled = false;
            this.txtSciezka.Location = new System.Drawing.Point(12, 201);
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
            this.btnOblicz.Location = new System.Drawing.Point(12, 15);
            this.btnOblicz.Name = "btnOblicz";
            this.btnOblicz.Size = new System.Drawing.Size(362, 23);
            this.btnOblicz.TabIndex = 4;
            this.btnOblicz.Text = "Oblicz";
            this.btnOblicz.UseVisualStyleBackColor = true;
            this.btnOblicz.Click += new System.EventHandler(this.btnOblicz_Click);
            // 
            // txtDecyzje
            // 
            this.txtDecyzje.Enabled = false;
            this.txtDecyzje.Location = new System.Drawing.Point(12, 120);
            this.txtDecyzje.Name = "txtDecyzje";
            this.txtDecyzje.Size = new System.Drawing.Size(255, 20);
            this.txtDecyzje.TabIndex = 5;
            // 
            // btDecyzje
            // 
            this.btDecyzje.Location = new System.Drawing.Point(288, 118);
            this.btDecyzje.Name = "btDecyzje";
            this.btDecyzje.Size = new System.Drawing.Size(75, 23);
            this.btDecyzje.TabIndex = 6;
            this.btDecyzje.Text = "Wczytaj";
            this.btDecyzje.UseVisualStyleBackColor = true;
            this.btDecyzje.Click += new System.EventHandler(this.btDecyzje_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bodoni MT Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Miary zawierania";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bodoni MT Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Decyzje";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(91)))), ((int)(((byte)(123)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 87);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(91)))), ((int)(((byte)(123)))));
            this.label3.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(132, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 78);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ocena\r\nKlasyfikacji";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(92)))), ((int)(((byte)(125)))));
            this.panel2.Location = new System.Drawing.Point(0, 160);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(385, 2);
            this.panel2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(91)))), ((int)(((byte)(123)))));
            this.panel3.Controls.Add(this.btnOblicz);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 266);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(386, 50);
            this.panel3.TabIndex = 11;
            // 
            // OknoGlowne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(386, 316);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnWczytajPlik);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btDecyzje);
            this.Controls.Add(this.txtSciezka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtDecyzje);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(401, 39);
            this.Name = "OknoGlowne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ocena Klasyfikacji";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWczytajPlik;
        private System.Windows.Forms.TextBox txtSciezka;
        private System.Windows.Forms.OpenFileDialog opfWczytaj;
        private System.Windows.Forms.Button btnOblicz;
        private System.Windows.Forms.TextBox txtDecyzje;
        private System.Windows.Forms.Button btDecyzje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}

