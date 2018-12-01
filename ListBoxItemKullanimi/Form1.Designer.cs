namespace ListBoxItemKullanimi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSecileniSilSag = new System.Windows.Forms.Button();
            this.btnSecileniSilSol = new System.Windows.Forms.Button();
            this.btnHepsiniSolaTasi = new System.Windows.Forms.Button();
            this.btnHepsiniSagaTasi = new System.Windows.Forms.Button();
            this.btnSecileniSolaTasi = new System.Windows.Forms.Button();
            this.btnSecileniSagaTasi = new System.Windows.Forms.Button();
            this.txtSag = new System.Windows.Forms.TextBox();
            this.btnSagEkle = new System.Windows.Forms.Button();
            this.lstSag = new System.Windows.Forms.ListBox();
            this.txtSol = new System.Windows.Forms.TextBox();
            this.btnSolEkle = new System.Windows.Forms.Button();
            this.lstSol = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnSecileniSilSag
            // 
            this.btnSecileniSilSag.Location = new System.Drawing.Point(411, 353);
            this.btnSecileniSilSag.Margin = new System.Windows.Forms.Padding(4);
            this.btnSecileniSilSag.Name = "btnSecileniSilSag";
            this.btnSecileniSilSag.Size = new System.Drawing.Size(180, 28);
            this.btnSecileniSilSag.TabIndex = 35;
            this.btnSecileniSilSag.Text = "Seçileni Sil";
            this.btnSecileniSilSag.UseVisualStyleBackColor = true;
            this.btnSecileniSilSag.Click += new System.EventHandler(this.btnSecileniSilSag_Click);
            // 
            // btnSecileniSilSol
            // 
            this.btnSecileniSilSol.Location = new System.Drawing.Point(32, 353);
            this.btnSecileniSilSol.Margin = new System.Windows.Forms.Padding(4);
            this.btnSecileniSilSol.Name = "btnSecileniSilSol";
            this.btnSecileniSilSol.Size = new System.Drawing.Size(180, 28);
            this.btnSecileniSilSol.TabIndex = 34;
            this.btnSecileniSilSol.Text = "Seçileni sil";
            this.btnSecileniSilSol.UseVisualStyleBackColor = true;
            this.btnSecileniSilSol.Click += new System.EventHandler(this.btnSecileniSilSol_Click);
            // 
            // btnHepsiniSolaTasi
            // 
            this.btnHepsiniSolaTasi.Location = new System.Drawing.Point(220, 259);
            this.btnHepsiniSolaTasi.Margin = new System.Windows.Forms.Padding(4);
            this.btnHepsiniSolaTasi.Name = "btnHepsiniSolaTasi";
            this.btnHepsiniSolaTasi.Size = new System.Drawing.Size(180, 28);
            this.btnHepsiniSolaTasi.TabIndex = 33;
            this.btnHepsiniSolaTasi.Text = "Hepsini Sola Taşı";
            this.btnHepsiniSolaTasi.UseVisualStyleBackColor = true;
            this.btnHepsiniSolaTasi.Click += new System.EventHandler(this.btnHepsiniSolaTasi_Click);
            // 
            // btnHepsiniSagaTasi
            // 
            this.btnHepsiniSagaTasi.Location = new System.Drawing.Point(220, 224);
            this.btnHepsiniSagaTasi.Margin = new System.Windows.Forms.Padding(4);
            this.btnHepsiniSagaTasi.Name = "btnHepsiniSagaTasi";
            this.btnHepsiniSagaTasi.Size = new System.Drawing.Size(180, 28);
            this.btnHepsiniSagaTasi.TabIndex = 32;
            this.btnHepsiniSagaTasi.Text = "Hepsini Sağa Taşı";
            this.btnHepsiniSagaTasi.UseVisualStyleBackColor = true;
            this.btnHepsiniSagaTasi.Click += new System.EventHandler(this.btnHepsiniSagaTasi_Click);
            // 
            // btnSecileniSolaTasi
            // 
            this.btnSecileniSolaTasi.Location = new System.Drawing.Point(220, 152);
            this.btnSecileniSolaTasi.Margin = new System.Windows.Forms.Padding(4);
            this.btnSecileniSolaTasi.Name = "btnSecileniSolaTasi";
            this.btnSecileniSolaTasi.Size = new System.Drawing.Size(180, 28);
            this.btnSecileniSolaTasi.TabIndex = 31;
            this.btnSecileniSolaTasi.Text = "Seçileni Sola Taşı";
            this.btnSecileniSolaTasi.UseVisualStyleBackColor = true;
            this.btnSecileniSolaTasi.Click += new System.EventHandler(this.btnSecileniSolaTasi_Click);
            // 
            // btnSecileniSagaTasi
            // 
            this.btnSecileniSagaTasi.Location = new System.Drawing.Point(220, 116);
            this.btnSecileniSagaTasi.Margin = new System.Windows.Forms.Padding(4);
            this.btnSecileniSagaTasi.Name = "btnSecileniSagaTasi";
            this.btnSecileniSagaTasi.Size = new System.Drawing.Size(180, 28);
            this.btnSecileniSagaTasi.TabIndex = 30;
            this.btnSecileniSagaTasi.Text = "Seçileni Sağa Taşı";
            this.btnSecileniSagaTasi.UseVisualStyleBackColor = true;
            this.btnSecileniSagaTasi.Click += new System.EventHandler(this.btnSecileniSagaTasi_Click);
            // 
            // txtSag
            // 
            this.txtSag.Location = new System.Drawing.Point(411, 33);
            this.txtSag.Margin = new System.Windows.Forms.Padding(4);
            this.txtSag.Name = "txtSag";
            this.txtSag.Size = new System.Drawing.Size(179, 22);
            this.txtSag.TabIndex = 29;
            // 
            // btnSagEkle
            // 
            this.btnSagEkle.Location = new System.Drawing.Point(411, 65);
            this.btnSagEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnSagEkle.Name = "btnSagEkle";
            this.btnSagEkle.Size = new System.Drawing.Size(180, 28);
            this.btnSagEkle.TabIndex = 28;
            this.btnSagEkle.Text = "Ekle";
            this.btnSagEkle.UseVisualStyleBackColor = true;
            this.btnSagEkle.Click += new System.EventHandler(this.btnSagEkle_Click);
            // 
            // lstSag
            // 
            this.lstSag.FormattingEnabled = true;
            this.lstSag.ItemHeight = 16;
            this.lstSag.Location = new System.Drawing.Point(411, 100);
            this.lstSag.Margin = new System.Windows.Forms.Padding(4);
            this.lstSag.MultiColumn = true;
            this.lstSag.Name = "lstSag";
            this.lstSag.Size = new System.Drawing.Size(179, 244);
            this.lstSag.TabIndex = 27;
            // 
            // txtSol
            // 
            this.txtSol.Location = new System.Drawing.Point(32, 33);
            this.txtSol.Margin = new System.Windows.Forms.Padding(4);
            this.txtSol.Name = "txtSol";
            this.txtSol.Size = new System.Drawing.Size(179, 22);
            this.txtSol.TabIndex = 26;
            // 
            // btnSolEkle
            // 
            this.btnSolEkle.Location = new System.Drawing.Point(32, 65);
            this.btnSolEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnSolEkle.Name = "btnSolEkle";
            this.btnSolEkle.Size = new System.Drawing.Size(180, 28);
            this.btnSolEkle.TabIndex = 25;
            this.btnSolEkle.Text = "Ekle";
            this.btnSolEkle.UseVisualStyleBackColor = true;
            this.btnSolEkle.Click += new System.EventHandler(this.btnSolEkle_Click);
            // 
            // lstSol
            // 
            this.lstSol.FormattingEnabled = true;
            this.lstSol.ItemHeight = 16;
            this.lstSol.Location = new System.Drawing.Point(32, 100);
            this.lstSol.Margin = new System.Windows.Forms.Padding(4);
            this.lstSol.MultiColumn = true;
            this.lstSol.Name = "lstSol";
            this.lstSol.Size = new System.Drawing.Size(179, 244);
            this.lstSol.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 415);
            this.Controls.Add(this.btnSecileniSilSag);
            this.Controls.Add(this.btnSecileniSilSol);
            this.Controls.Add(this.btnHepsiniSolaTasi);
            this.Controls.Add(this.btnHepsiniSagaTasi);
            this.Controls.Add(this.btnSecileniSolaTasi);
            this.Controls.Add(this.btnSecileniSagaTasi);
            this.Controls.Add(this.txtSag);
            this.Controls.Add(this.btnSagEkle);
            this.Controls.Add(this.lstSag);
            this.Controls.Add(this.txtSol);
            this.Controls.Add(this.btnSolEkle);
            this.Controls.Add(this.lstSol);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSecileniSilSag;
        private System.Windows.Forms.Button btnSecileniSilSol;
        private System.Windows.Forms.Button btnHepsiniSolaTasi;
        private System.Windows.Forms.Button btnHepsiniSagaTasi;
        private System.Windows.Forms.Button btnSecileniSolaTasi;
        private System.Windows.Forms.Button btnSecileniSagaTasi;
        private System.Windows.Forms.TextBox txtSag;
        private System.Windows.Forms.Button btnSagEkle;
        private System.Windows.Forms.ListBox lstSag;
        private System.Windows.Forms.TextBox txtSol;
        private System.Windows.Forms.Button btnSolEkle;
        private System.Windows.Forms.ListBox lstSol;
    }
}

