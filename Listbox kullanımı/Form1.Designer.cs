namespace Listbox_kullanımı
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.ekle = new System.Windows.Forms.Button();
            this.txt_girilen = new System.Windows.Forms.TextBox();
            this.sil = new System.Windows.Forms.Button();
            this.count_bul = new System.Windows.Forms.Button();
            this.temizle = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "eklemek istediğiniz ürün ismini giriniz";
            // 
            // ekle
            // 
            this.ekle.Location = new System.Drawing.Point(592, 26);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(75, 23);
            this.ekle.TabIndex = 1;
            this.ekle.Text = "ekle";
            this.ekle.UseVisualStyleBackColor = true;
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // txt_girilen
            // 
            this.txt_girilen.Location = new System.Drawing.Point(339, 26);
            this.txt_girilen.Name = "txt_girilen";
            this.txt_girilen.Size = new System.Drawing.Size(182, 22);
            this.txt_girilen.TabIndex = 2;
            // 
            // sil
            // 
            this.sil.Location = new System.Drawing.Point(592, 118);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(75, 23);
            this.sil.TabIndex = 1;
            this.sil.Text = "sil";
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // count_bul
            // 
            this.count_bul.Location = new System.Drawing.Point(592, 214);
            this.count_bul.Name = "count_bul";
            this.count_bul.Size = new System.Drawing.Size(75, 23);
            this.count_bul.TabIndex = 1;
            this.count_bul.Text = "count bul";
            this.count_bul.UseVisualStyleBackColor = true;
            this.count_bul.Click += new System.EventHandler(this.count_bul_Click);
            // 
            // temizle
            // 
            this.temizle.Location = new System.Drawing.Point(592, 313);
            this.temizle.Name = "temizle";
            this.temizle.Size = new System.Drawing.Size(75, 23);
            this.temizle.TabIndex = 1;
            this.temizle.Text = "temizle";
            this.temizle.UseVisualStyleBackColor = true;
            this.temizle.Click += new System.EventHandler(this.temizle_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(24, 70);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(530, 308);
            this.listBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txt_girilen);
            this.Controls.Add(this.temizle);
            this.Controls.Add(this.count_bul);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.ekle);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.TextBox txt_girilen;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Button count_bul;
        private System.Windows.Forms.Button temizle;
        private System.Windows.Forms.ListBox listBox1;
    }
}

