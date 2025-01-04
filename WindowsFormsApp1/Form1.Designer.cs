namespace WindowsFormsApp1
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
            this.txt_ilknot = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ikincinot = new System.Windows.Forms.TextBox();
            this.hesapla = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_sonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 133);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ilk notunu gir";
            // 
            // txt_ilknot
            // 
            this.txt_ilknot.Location = new System.Drawing.Point(476, 134);
            this.txt_ilknot.Name = "txt_ilknot";
            this.txt_ilknot.Size = new System.Drawing.Size(157, 28);
            this.txt_ilknot.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 210);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "ikinci notunu gir";
            // 
            // txt_ikincinot
            // 
            this.txt_ikincinot.Location = new System.Drawing.Point(476, 210);
            this.txt_ikincinot.Name = "txt_ikincinot";
            this.txt_ikincinot.Size = new System.Drawing.Size(157, 28);
            this.txt_ikincinot.TabIndex = 1;
            this.txt_ikincinot.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // hesapla
            // 
            this.hesapla.Location = new System.Drawing.Point(250, 276);
            this.hesapla.Name = "hesapla";
            this.hesapla.Size = new System.Drawing.Size(186, 35);
            this.hesapla.TabIndex = 2;
            this.hesapla.Text = "ortlamayı hesapla\r\n";
            this.hesapla.UseVisualStyleBackColor = true;
            this.hesapla.Click += new System.EventHandler(this.hesapla_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(485, 282);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "ortalama:";
            // 
            // lbl_sonuc
            // 
            this.lbl_sonuc.AutoSize = true;
            this.lbl_sonuc.Location = new System.Drawing.Point(579, 282);
            this.lbl_sonuc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_sonuc.Name = "lbl_sonuc";
            this.lbl_sonuc.Size = new System.Drawing.Size(20, 24);
            this.lbl_sonuc.TabIndex = 4;
            this.lbl_sonuc.Text = "0";
            this.lbl_sonuc.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1814, 795);
            this.Controls.Add(this.lbl_sonuc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hesapla);
            this.Controls.Add(this.txt_ikincinot);
            this.Controls.Add(this.txt_ilknot);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ilknot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ikincinot;
        private System.Windows.Forms.Button hesapla;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_sonuc;
    }
}

