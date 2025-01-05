namespace Radio_button_kullanımı
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
            this.erkek = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.surname = new System.Windows.Forms.TextBox();
            this.isim = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.kadın = new System.Windows.Forms.RadioButton();
            this.btn_goster = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // erkek
            // 
            this.erkek.AutoSize = true;
            this.erkek.Location = new System.Drawing.Point(221, 153);
            this.erkek.Name = "erkek";
            this.erkek.Size = new System.Drawing.Size(62, 20);
            this.erkek.TabIndex = 0;
            this.erkek.TabStop = true;
            this.erkek.Text = "erkek";
            this.erkek.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "soyisim";
            // 
            // surname
            // 
            this.surname.Location = new System.Drawing.Point(302, 88);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(100, 22);
            this.surname.TabIndex = 2;
            // 
            // isim
            // 
            this.isim.AutoSize = true;
            this.isim.Location = new System.Drawing.Point(218, 35);
            this.isim.Name = "isim";
            this.isim.Size = new System.Drawing.Size(31, 16);
            this.isim.TabIndex = 1;
            this.isim.Text = "isim";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(302, 35);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 22);
            this.name.TabIndex = 2;
            // 
            // kadın
            // 
            this.kadın.AutoSize = true;
            this.kadın.Location = new System.Drawing.Point(344, 153);
            this.kadın.Name = "kadın";
            this.kadın.Size = new System.Drawing.Size(61, 20);
            this.kadın.TabIndex = 0;
            this.kadın.TabStop = true;
            this.kadın.Text = "kadın";
            this.kadın.UseVisualStyleBackColor = true;
            // 
            // btn_goster
            // 
            this.btn_goster.Location = new System.Drawing.Point(270, 220);
            this.btn_goster.Name = "btn_goster";
            this.btn_goster.Size = new System.Drawing.Size(103, 39);
            this.btn_goster.TabIndex = 3;
            this.btn_goster.Text = "bilgileri göster";
            this.btn_goster.UseVisualStyleBackColor = true;
            this.btn_goster.Click += new System.EventHandler(this.btn_goster_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 404);
            this.Controls.Add(this.btn_goster);
            this.Controls.Add(this.name);
            this.Controls.Add(this.isim);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kadın);
            this.Controls.Add(this.erkek);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton erkek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.Label isim;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.RadioButton kadın;
        private System.Windows.Forms.Button btn_goster;
    }
}

