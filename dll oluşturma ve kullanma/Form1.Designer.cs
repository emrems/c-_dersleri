namespace dll_oluşturma_ve_kullanma
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_iki = new System.Windows.Forms.TextBox();
            this.txt_ilk = new System.Windows.Forms.TextBox();
            this.btn_topla = new System.Windows.Forms.Button();
            this.sonuc = new System.Windows.Forms.Label();
            this.btn_cikar = new System.Windows.Forms.Button();
            this.btn_carp = new System.Windows.Forms.Button();
            this.btn_bol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ikinci sayıyı gir";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(155, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "ilk sayıyı gir";
            // 
            // txt_iki
            // 
            this.txt_iki.Location = new System.Drawing.Point(424, 106);
            this.txt_iki.Name = "txt_iki";
            this.txt_iki.Size = new System.Drawing.Size(100, 22);
            this.txt_iki.TabIndex = 1;
            // 
            // txt_ilk
            // 
            this.txt_ilk.Location = new System.Drawing.Point(424, 63);
            this.txt_ilk.Name = "txt_ilk";
            this.txt_ilk.Size = new System.Drawing.Size(100, 22);
            this.txt_ilk.TabIndex = 1;
            // 
            // btn_topla
            // 
            this.btn_topla.Location = new System.Drawing.Point(160, 231);
            this.btn_topla.Name = "btn_topla";
            this.btn_topla.Size = new System.Drawing.Size(50, 32);
            this.btn_topla.TabIndex = 2;
            this.btn_topla.Text = "+";
            this.btn_topla.UseVisualStyleBackColor = true;
            this.btn_topla.Click += new System.EventHandler(this.btn_topla_Click);
            // 
            // sonuc
            // 
            this.sonuc.AutoSize = true;
            this.sonuc.Location = new System.Drawing.Point(301, 164);
            this.sonuc.Name = "sonuc";
            this.sonuc.Size = new System.Drawing.Size(14, 16);
            this.sonuc.TabIndex = 3;
            this.sonuc.Text = "0";
            // 
            // btn_cikar
            // 
            this.btn_cikar.Location = new System.Drawing.Point(227, 231);
            this.btn_cikar.Name = "btn_cikar";
            this.btn_cikar.Size = new System.Drawing.Size(50, 32);
            this.btn_cikar.TabIndex = 2;
            this.btn_cikar.Text = "-";
            this.btn_cikar.UseVisualStyleBackColor = true;
            this.btn_cikar.Click += new System.EventHandler(this.btn_cikar_Click);
            // 
            // btn_carp
            // 
            this.btn_carp.Location = new System.Drawing.Point(293, 231);
            this.btn_carp.Name = "btn_carp";
            this.btn_carp.Size = new System.Drawing.Size(50, 32);
            this.btn_carp.TabIndex = 2;
            this.btn_carp.Text = "*";
            this.btn_carp.UseVisualStyleBackColor = true;
            this.btn_carp.Click += new System.EventHandler(this.btn_carp_Click);
            // 
            // btn_bol
            // 
            this.btn_bol.Location = new System.Drawing.Point(358, 231);
            this.btn_bol.Name = "btn_bol";
            this.btn_bol.Size = new System.Drawing.Size(50, 32);
            this.btn_bol.TabIndex = 2;
            this.btn_bol.Text = "/";
            this.btn_bol.UseVisualStyleBackColor = true;
            this.btn_bol.Click += new System.EventHandler(this.btn_bol_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sonuc);
            this.Controls.Add(this.btn_bol);
            this.Controls.Add(this.btn_carp);
            this.Controls.Add(this.btn_cikar);
            this.Controls.Add(this.btn_topla);
            this.Controls.Add(this.txt_ilk);
            this.Controls.Add(this.txt_iki);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_iki;
        private System.Windows.Forms.TextBox txt_ilk;
        private System.Windows.Forms.Button btn_topla;
        private System.Windows.Forms.Label sonuc;
        private System.Windows.Forms.Button btn_cikar;
        private System.Windows.Forms.Button btn_carp;
        private System.Windows.Forms.Button btn_bol;
    }
}

