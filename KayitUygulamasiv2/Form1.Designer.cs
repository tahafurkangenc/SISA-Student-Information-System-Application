namespace KayitUygulamasiv2
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
            this.OgrenciIDTextBox = new System.Windows.Forms.TextBox();
            this.AgnoTextBox = new System.Windows.Forms.TextBox();
            this.OgrencisoyisimTextBox = new System.Windows.Forms.TextBox();
            this.OgrenciisimTextBox = new System.Windows.Forms.TextBox();
            this.OgrencisifreTextBox = new System.Windows.Forms.TextBox();
            this.OCRverieklebutton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.OCRveriislebutton = new System.Windows.Forms.Button();
            this.OgrenciIDLabel = new System.Windows.Forms.Label();
            this.OgrenciSoyadLabel = new System.Windows.Forms.Label();
            this.OgrenciİsimLabel = new System.Windows.Forms.Label();
            this.OgrenciAgnoLabel = new System.Windows.Forms.Label();
            this.AlinanderskodlaririchTextBox = new System.Windows.Forms.RichTextBox();
            this.OCRverisilbutton = new System.Windows.Forms.Button();
            this.OgrenciEkleButton = new System.Windows.Forms.Button();
            this.OgrenciSifreLabel = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.OgrenciAldigiDerslerLabel = new System.Windows.Forms.Label();
            this.OgrenciilgiAlanlariLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OgrenciIDTextBox
            // 
            this.OgrenciIDTextBox.Location = new System.Drawing.Point(201, 12);
            this.OgrenciIDTextBox.Name = "OgrenciIDTextBox";
            this.OgrenciIDTextBox.Size = new System.Drawing.Size(227, 20);
            this.OgrenciIDTextBox.TabIndex = 0;
            // 
            // AgnoTextBox
            // 
            this.AgnoTextBox.Location = new System.Drawing.Point(201, 116);
            this.AgnoTextBox.Name = "AgnoTextBox";
            this.AgnoTextBox.Size = new System.Drawing.Size(227, 20);
            this.AgnoTextBox.TabIndex = 1;
            // 
            // OgrencisoyisimTextBox
            // 
            this.OgrencisoyisimTextBox.Location = new System.Drawing.Point(201, 64);
            this.OgrencisoyisimTextBox.Name = "OgrencisoyisimTextBox";
            this.OgrencisoyisimTextBox.Size = new System.Drawing.Size(227, 20);
            this.OgrencisoyisimTextBox.TabIndex = 2;
            // 
            // OgrenciisimTextBox
            // 
            this.OgrenciisimTextBox.Location = new System.Drawing.Point(201, 38);
            this.OgrenciisimTextBox.Name = "OgrenciisimTextBox";
            this.OgrenciisimTextBox.Size = new System.Drawing.Size(227, 20);
            this.OgrenciisimTextBox.TabIndex = 3;
            // 
            // OgrencisifreTextBox
            // 
            this.OgrencisifreTextBox.Location = new System.Drawing.Point(201, 90);
            this.OgrencisifreTextBox.Name = "OgrencisifreTextBox";
            this.OgrencisifreTextBox.Size = new System.Drawing.Size(227, 20);
            this.OgrencisifreTextBox.TabIndex = 4;
            // 
            // OCRverieklebutton
            // 
            this.OCRverieklebutton.Location = new System.Drawing.Point(201, 442);
            this.OCRverieklebutton.Name = "OCRverieklebutton";
            this.OCRverieklebutton.Size = new System.Drawing.Size(227, 29);
            this.OCRverieklebutton.TabIndex = 8;
            this.OCRverieklebutton.Text = "OCR\'a Veri Ekleyin";
            this.OCRverieklebutton.UseVisualStyleBackColor = true;
            this.OCRverieklebutton.Click += new System.EventHandler(this.OCRverieklebutton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // OCRveriislebutton
            // 
            this.OCRveriislebutton.Location = new System.Drawing.Point(201, 477);
            this.OCRveriislebutton.Name = "OCRveriislebutton";
            this.OCRveriislebutton.Size = new System.Drawing.Size(227, 29);
            this.OCRveriislebutton.TabIndex = 9;
            this.OCRveriislebutton.Text = "OCR Verilerini İşleyin";
            this.OCRveriislebutton.UseVisualStyleBackColor = true;
            this.OCRveriislebutton.Click += new System.EventHandler(this.OCRveriislebutton_Click);
            // 
            // OgrenciIDLabel
            // 
            this.OgrenciIDLabel.AutoSize = true;
            this.OgrenciIDLabel.Location = new System.Drawing.Point(134, 19);
            this.OgrenciIDLabel.Name = "OgrenciIDLabel";
            this.OgrenciIDLabel.Size = new System.Drawing.Size(61, 13);
            this.OgrenciIDLabel.TabIndex = 10;
            this.OgrenciIDLabel.Text = "Öğrenci ID:";
            // 
            // OgrenciSoyadLabel
            // 
            this.OgrenciSoyadLabel.AutoSize = true;
            this.OgrenciSoyadLabel.Location = new System.Drawing.Point(110, 71);
            this.OgrenciSoyadLabel.Name = "OgrenciSoyadLabel";
            this.OgrenciSoyadLabel.Size = new System.Drawing.Size(85, 13);
            this.OgrenciSoyadLabel.TabIndex = 11;
            this.OgrenciSoyadLabel.Text = "Öğrenci Soyisim:";
            // 
            // OgrenciİsimLabel
            // 
            this.OgrenciİsimLabel.AutoSize = true;
            this.OgrenciİsimLabel.Location = new System.Drawing.Point(127, 45);
            this.OgrenciİsimLabel.Name = "OgrenciİsimLabel";
            this.OgrenciİsimLabel.Size = new System.Drawing.Size(68, 13);
            this.OgrenciİsimLabel.TabIndex = 12;
            this.OgrenciİsimLabel.Text = "Öğrenci İsim:";
            // 
            // OgrenciAgnoLabel
            // 
            this.OgrenciAgnoLabel.AutoSize = true;
            this.OgrenciAgnoLabel.Location = new System.Drawing.Point(154, 123);
            this.OgrenciAgnoLabel.Name = "OgrenciAgnoLabel";
            this.OgrenciAgnoLabel.Size = new System.Drawing.Size(41, 13);
            this.OgrenciAgnoLabel.TabIndex = 13;
            this.OgrenciAgnoLabel.Text = "AGNO:";
            // 
            // AlinanderskodlaririchTextBox
            // 
            this.AlinanderskodlaririchTextBox.Location = new System.Drawing.Point(201, 142);
            this.AlinanderskodlaririchTextBox.Name = "AlinanderskodlaririchTextBox";
            this.AlinanderskodlaririchTextBox.Size = new System.Drawing.Size(227, 144);
            this.AlinanderskodlaririchTextBox.TabIndex = 14;
            this.AlinanderskodlaririchTextBox.Text = "";
            this.AlinanderskodlaririchTextBox.TextChanged += new System.EventHandler(this.AlinanderskodlaririchTextBox_TextChanged);
            // 
            // OCRverisilbutton
            // 
            this.OCRverisilbutton.Location = new System.Drawing.Point(201, 512);
            this.OCRverisilbutton.Name = "OCRverisilbutton";
            this.OCRverisilbutton.Size = new System.Drawing.Size(227, 29);
            this.OCRverisilbutton.TabIndex = 15;
            this.OCRverisilbutton.Text = "OCR Verilerini Sıfırlayın";
            this.OCRverisilbutton.UseVisualStyleBackColor = true;
            this.OCRverisilbutton.Click += new System.EventHandler(this.OCRverisilbutton_Click);
            // 
            // OgrenciEkleButton
            // 
            this.OgrenciEkleButton.Location = new System.Drawing.Point(201, 547);
            this.OgrenciEkleButton.Name = "OgrenciEkleButton";
            this.OgrenciEkleButton.Size = new System.Drawing.Size(227, 29);
            this.OgrenciEkleButton.TabIndex = 16;
            this.OgrenciEkleButton.Text = "Öğrenciyi Veri Tabanına Ekleyin";
            this.OgrenciEkleButton.UseVisualStyleBackColor = true;
            this.OgrenciEkleButton.Click += new System.EventHandler(this.OgrenciEkleButton_Click);
            // 
            // OgrenciSifreLabel
            // 
            this.OgrenciSifreLabel.AutoSize = true;
            this.OgrenciSifreLabel.Location = new System.Drawing.Point(121, 97);
            this.OgrenciSifreLabel.Name = "OgrenciSifreLabel";
            this.OgrenciSifreLabel.Size = new System.Drawing.Size(74, 13);
            this.OgrenciSifreLabel.TabIndex = 17;
            this.OgrenciSifreLabel.Text = "Öğrenci Şifre: ";
            this.OgrenciSifreLabel.Click += new System.EventHandler(this.OgrenciSifreLabel_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(201, 292);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(227, 144);
            this.richTextBox1.TabIndex = 18;
            this.richTextBox1.Text = "";
            // 
            // OgrenciAldigiDerslerLabel
            // 
            this.OgrenciAldigiDerslerLabel.AutoSize = true;
            this.OgrenciAldigiDerslerLabel.Location = new System.Drawing.Point(80, 145);
            this.OgrenciAldigiDerslerLabel.Name = "OgrenciAldigiDerslerLabel";
            this.OgrenciAldigiDerslerLabel.Size = new System.Drawing.Size(115, 13);
            this.OgrenciAldigiDerslerLabel.TabIndex = 19;
            this.OgrenciAldigiDerslerLabel.Text = "Öğrenci Alınan Dersler:";
            // 
            // OgrenciilgiAlanlariLabel
            // 
            this.OgrenciilgiAlanlariLabel.AutoSize = true;
            this.OgrenciilgiAlanlariLabel.Location = new System.Drawing.Point(95, 295);
            this.OgrenciilgiAlanlariLabel.Name = "OgrenciilgiAlanlariLabel";
            this.OgrenciilgiAlanlariLabel.Size = new System.Drawing.Size(100, 13);
            this.OgrenciilgiAlanlariLabel.TabIndex = 20;
            this.OgrenciilgiAlanlariLabel.Text = "Öğrenci İlgi Alanları:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 584);
            this.Controls.Add(this.OgrenciilgiAlanlariLabel);
            this.Controls.Add(this.OgrenciAldigiDerslerLabel);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.OgrenciSifreLabel);
            this.Controls.Add(this.OgrenciEkleButton);
            this.Controls.Add(this.OCRverisilbutton);
            this.Controls.Add(this.AlinanderskodlaririchTextBox);
            this.Controls.Add(this.OgrenciAgnoLabel);
            this.Controls.Add(this.OgrenciİsimLabel);
            this.Controls.Add(this.OgrenciSoyadLabel);
            this.Controls.Add(this.OgrenciIDLabel);
            this.Controls.Add(this.OCRveriislebutton);
            this.Controls.Add(this.OCRverieklebutton);
            this.Controls.Add(this.OgrencisifreTextBox);
            this.Controls.Add(this.OgrenciisimTextBox);
            this.Controls.Add(this.OgrencisoyisimTextBox);
            this.Controls.Add(this.AgnoTextBox);
            this.Controls.Add(this.OgrenciIDTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox OgrenciIDTextBox;
        private System.Windows.Forms.TextBox AgnoTextBox;
        private System.Windows.Forms.TextBox OgrencisoyisimTextBox;
        private System.Windows.Forms.TextBox OgrenciisimTextBox;
        private System.Windows.Forms.TextBox OgrencisifreTextBox;
        private System.Windows.Forms.Button OCRverieklebutton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button OCRveriislebutton;
        private System.Windows.Forms.Label OgrenciIDLabel;
        private System.Windows.Forms.Label OgrenciSoyadLabel;
        private System.Windows.Forms.Label OgrenciİsimLabel;
        private System.Windows.Forms.Label OgrenciAgnoLabel;
        private System.Windows.Forms.RichTextBox AlinanderskodlaririchTextBox;
        private System.Windows.Forms.Button OCRverisilbutton;
        private System.Windows.Forms.Button OgrenciEkleButton;
        private System.Windows.Forms.Label OgrenciSifreLabel;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label OgrenciAldigiDerslerLabel;
        private System.Windows.Forms.Label OgrenciilgiAlanlariLabel;
    }
}

