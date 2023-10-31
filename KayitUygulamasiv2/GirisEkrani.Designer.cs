namespace KayitUygulamasiv2
{
    partial class GirisEkrani
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
            this.girisIDlabel = new System.Windows.Forms.Label();
            this.girisIDtextBox = new System.Windows.Forms.TextBox();
            this.girisSifreTextBox = new System.Windows.Forms.TextBox();
            this.girisSifrelabel = new System.Windows.Forms.Label();
            this.ogrenciGirisButton = new System.Windows.Forms.Button();
            this.ogretmenGirisButton = new System.Windows.Forms.Button();
            this.yoneticiGirisButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // girisIDlabel
            // 
            this.girisIDlabel.AutoSize = true;
            this.girisIDlabel.Location = new System.Drawing.Point(12, 15);
            this.girisIDlabel.Name = "girisIDlabel";
            this.girisIDlabel.Size = new System.Drawing.Size(53, 13);
            this.girisIDlabel.TabIndex = 0;
            this.girisIDlabel.Text = "ID giriniz :";
            // 
            // girisIDtextBox
            // 
            this.girisIDtextBox.Location = new System.Drawing.Point(71, 12);
            this.girisIDtextBox.Name = "girisIDtextBox";
            this.girisIDtextBox.Size = new System.Drawing.Size(166, 20);
            this.girisIDtextBox.TabIndex = 1;
            // 
            // girisSifreTextBox
            // 
            this.girisSifreTextBox.Location = new System.Drawing.Point(71, 38);
            this.girisSifreTextBox.Name = "girisSifreTextBox";
            this.girisSifreTextBox.Size = new System.Drawing.Size(166, 20);
            this.girisSifreTextBox.TabIndex = 3;
            // 
            // girisSifrelabel
            // 
            this.girisSifrelabel.AutoSize = true;
            this.girisSifrelabel.Location = new System.Drawing.Point(12, 41);
            this.girisSifrelabel.Name = "girisSifrelabel";
            this.girisSifrelabel.Size = new System.Drawing.Size(62, 13);
            this.girisSifrelabel.TabIndex = 2;
            this.girisSifrelabel.Text = "Şifre Giriniz:";
            // 
            // ogrenciGirisButton
            // 
            this.ogrenciGirisButton.Location = new System.Drawing.Point(15, 64);
            this.ogrenciGirisButton.Name = "ogrenciGirisButton";
            this.ogrenciGirisButton.Size = new System.Drawing.Size(222, 25);
            this.ogrenciGirisButton.TabIndex = 4;
            this.ogrenciGirisButton.Text = "Öğrenci Girişi İçin Tıklayınız";
            this.ogrenciGirisButton.UseVisualStyleBackColor = true;
            this.ogrenciGirisButton.Click += new System.EventHandler(this.ogrenciGirisButton_Click);
            // 
            // ogretmenGirisButton
            // 
            this.ogretmenGirisButton.Location = new System.Drawing.Point(15, 95);
            this.ogretmenGirisButton.Name = "ogretmenGirisButton";
            this.ogretmenGirisButton.Size = new System.Drawing.Size(222, 25);
            this.ogretmenGirisButton.TabIndex = 5;
            this.ogretmenGirisButton.Text = "Öğretmen Girişi İçin Tıklayınız";
            this.ogretmenGirisButton.UseVisualStyleBackColor = true;
            this.ogretmenGirisButton.Click += new System.EventHandler(this.ogretmenGirisButton_Click);
            // 
            // yoneticiGirisButton
            // 
            this.yoneticiGirisButton.Location = new System.Drawing.Point(15, 126);
            this.yoneticiGirisButton.Name = "yoneticiGirisButton";
            this.yoneticiGirisButton.Size = new System.Drawing.Size(222, 25);
            this.yoneticiGirisButton.TabIndex = 6;
            this.yoneticiGirisButton.Text = "Yönetici Girişi İçin Tıklayınız";
            this.yoneticiGirisButton.UseVisualStyleBackColor = true;
            this.yoneticiGirisButton.Click += new System.EventHandler(this.yoneticiGirisButton_Click);
            // 
            // GirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 163);
            this.Controls.Add(this.yoneticiGirisButton);
            this.Controls.Add(this.ogretmenGirisButton);
            this.Controls.Add(this.ogrenciGirisButton);
            this.Controls.Add(this.girisSifreTextBox);
            this.Controls.Add(this.girisSifrelabel);
            this.Controls.Add(this.girisIDtextBox);
            this.Controls.Add(this.girisIDlabel);
            this.Name = "GirisEkrani";
            this.Text = "GirisEkrani";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label girisIDlabel;
        private System.Windows.Forms.TextBox girisIDtextBox;
        private System.Windows.Forms.TextBox girisSifreTextBox;
        private System.Windows.Forms.Label girisSifrelabel;
        private System.Windows.Forms.Button ogrenciGirisButton;
        private System.Windows.Forms.Button ogretmenGirisButton;
        private System.Windows.Forms.Button yoneticiGirisButton;
    }
}