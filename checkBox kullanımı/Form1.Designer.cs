namespace checkBox_kullanımı
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
            this.checkbox_cay = new System.Windows.Forms.CheckBox();
            this.checkbox_su = new System.Windows.Forms.CheckBox();
            this.checkbox_gazoz = new System.Windows.Forms.CheckBox();
            this.checkbox_kahve = new System.Windows.Forms.CheckBox();
            this.btn_hesapla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_sonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkbox_cay
            // 
            this.checkbox_cay.AutoSize = true;
            this.checkbox_cay.Location = new System.Drawing.Point(203, 39);
            this.checkbox_cay.Name = "checkbox_cay";
            this.checkbox_cay.Size = new System.Drawing.Size(67, 20);
            this.checkbox_cay.TabIndex = 0;
            this.checkbox_cay.Text = "çay 2tl";
            this.checkbox_cay.UseVisualStyleBackColor = true;
            // 
            // checkbox_su
            // 
            this.checkbox_su.AutoSize = true;
            this.checkbox_su.Location = new System.Drawing.Point(203, 65);
            this.checkbox_su.Name = "checkbox_su";
            this.checkbox_su.Size = new System.Drawing.Size(59, 20);
            this.checkbox_su.TabIndex = 0;
            this.checkbox_su.Text = "su 3tl";
            this.checkbox_su.UseVisualStyleBackColor = true;
            // 
            // checkbox_gazoz
            // 
            this.checkbox_gazoz.AutoSize = true;
            this.checkbox_gazoz.Location = new System.Drawing.Point(203, 91);
            this.checkbox_gazoz.Name = "checkbox_gazoz";
            this.checkbox_gazoz.Size = new System.Drawing.Size(81, 20);
            this.checkbox_gazoz.TabIndex = 0;
            this.checkbox_gazoz.Text = "gazoz 4tl";
            this.checkbox_gazoz.UseVisualStyleBackColor = true;
            // 
            // checkbox_kahve
            // 
            this.checkbox_kahve.AutoSize = true;
            this.checkbox_kahve.Location = new System.Drawing.Point(203, 117);
            this.checkbox_kahve.Name = "checkbox_kahve";
            this.checkbox_kahve.Size = new System.Drawing.Size(92, 20);
            this.checkbox_kahve.TabIndex = 0;
            this.checkbox_kahve.Text = "kahve 10 tl";
            this.checkbox_kahve.UseVisualStyleBackColor = true;
            // 
            // btn_hesapla
            // 
            this.btn_hesapla.Location = new System.Drawing.Point(203, 195);
            this.btn_hesapla.Name = "btn_hesapla";
            this.btn_hesapla.Size = new System.Drawing.Size(92, 28);
            this.btn_hesapla.TabIndex = 1;
            this.btn_hesapla.Text = "hesapla";
            this.btn_hesapla.UseVisualStyleBackColor = true;
            this.btn_hesapla.Click += new System.EventHandler(this.btn_hesapla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "toplam tutar: ";
            // 
            // label_sonuc
            // 
            this.label_sonuc.AutoSize = true;
            this.label_sonuc.Location = new System.Drawing.Point(440, 51);
            this.label_sonuc.Name = "label_sonuc";
            this.label_sonuc.Size = new System.Drawing.Size(14, 16);
            this.label_sonuc.TabIndex = 2;
            this.label_sonuc.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_sonuc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_hesapla);
            this.Controls.Add(this.checkbox_kahve);
            this.Controls.Add(this.checkbox_gazoz);
            this.Controls.Add(this.checkbox_su);
            this.Controls.Add(this.checkbox_cay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkbox_cay;
        private System.Windows.Forms.CheckBox checkbox_su;
        private System.Windows.Forms.CheckBox checkbox_gazoz;
        private System.Windows.Forms.CheckBox checkbox_kahve;
        private System.Windows.Forms.Button btn_hesapla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_sonuc;
    }
}

