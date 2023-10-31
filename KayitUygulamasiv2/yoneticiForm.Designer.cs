namespace KayitUygulamasiv2
{
    partial class yoneticiForm
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
            this.yoneticiIDLabel = new System.Windows.Forms.Label();
            this.yoneticiSoyisimLabel = new System.Windows.Forms.Label();
            this.yoneticiİsimLabel = new System.Windows.Forms.Label();
            this.ogrencikayitbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // yoneticiIDLabel
            // 
            this.yoneticiIDLabel.AutoSize = true;
            this.yoneticiIDLabel.Location = new System.Drawing.Point(17, 17);
            this.yoneticiIDLabel.Name = "yoneticiIDLabel";
            this.yoneticiIDLabel.Size = new System.Drawing.Size(71, 13);
            this.yoneticiIDLabel.TabIndex = 0;
            this.yoneticiIDLabel.Text = "Yönetici ID = ";
            // 
            // yoneticiSoyisimLabel
            // 
            this.yoneticiSoyisimLabel.AutoSize = true;
            this.yoneticiSoyisimLabel.Location = new System.Drawing.Point(17, 67);
            this.yoneticiSoyisimLabel.Name = "yoneticiSoyisimLabel";
            this.yoneticiSoyisimLabel.Size = new System.Drawing.Size(99, 13);
            this.yoneticiSoyisimLabel.TabIndex = 1;
            this.yoneticiSoyisimLabel.Text = "Yönetici Soy İsim = ";
            // 
            // yoneticiİsimLabel
            // 
            this.yoneticiİsimLabel.AutoSize = true;
            this.yoneticiİsimLabel.Location = new System.Drawing.Point(17, 42);
            this.yoneticiİsimLabel.Name = "yoneticiİsimLabel";
            this.yoneticiİsimLabel.Size = new System.Drawing.Size(78, 13);
            this.yoneticiİsimLabel.TabIndex = 2;
            this.yoneticiİsimLabel.Text = "Yönetici İsim = ";
            // 
            // ogrencikayitbutton
            // 
            this.ogrencikayitbutton.Location = new System.Drawing.Point(20, 97);
            this.ogrencikayitbutton.Name = "ogrencikayitbutton";
            this.ogrencikayitbutton.Size = new System.Drawing.Size(91, 32);
            this.ogrencikayitbutton.TabIndex = 3;
            this.ogrencikayitbutton.Text = "Öğrenci Kayıt";
            this.ogrencikayitbutton.UseVisualStyleBackColor = true;
            this.ogrencikayitbutton.Click += new System.EventHandler(this.ogrencikayitbutton_Click);
            // 
            // yoneticiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ogrencikayitbutton);
            this.Controls.Add(this.yoneticiİsimLabel);
            this.Controls.Add(this.yoneticiSoyisimLabel);
            this.Controls.Add(this.yoneticiIDLabel);
            this.Name = "yoneticiForm";
            this.Text = "yoneticiForm";
            this.Load += new System.EventHandler(this.yoneticiForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label yoneticiIDLabel;
        private System.Windows.Forms.Label yoneticiSoyisimLabel;
        private System.Windows.Forms.Label yoneticiİsimLabel;
        private System.Windows.Forms.Button ogrencikayitbutton;
    }
}