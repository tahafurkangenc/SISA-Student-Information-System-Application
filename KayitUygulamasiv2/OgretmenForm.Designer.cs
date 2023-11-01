namespace KayitUygulamasiv2
{
    partial class OgretmenForm
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
            this.ogretmenVerilenDerslerGridView = new System.Windows.Forms.DataGridView();
            this.ilgiAlanlariListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.kontenjanLabel = new System.Windows.Forms.Label();
            this.OgretmenİsimSoyisimLabel = new System.Windows.Forms.Label();
            this.SicilNoLabel = new System.Windows.Forms.Label();
            this.OgretmenIDlabel = new System.Windows.Forms.Label();
            this.dersalabilecekogrencilerGridView = new System.Windows.Forms.DataGridView();
            this.ilgialanisil = new System.Windows.Forms.Button();
            this.ilgialanieklebutton = new System.Windows.Forms.Button();
            this.ilgialaniekleTextBox = new System.Windows.Forms.TextBox();
            this.dersfiltresiTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sıralaButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.kritikdersekleTextBox = new System.Windows.Forms.TextBox();
            this.kritikderseklebutton = new System.Windows.Forms.Button();
            this.kritikderssilbutton = new System.Windows.Forms.Button();
            this.kritikDerslerListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ogretmenVerilenDerslerGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dersalabilecekogrencilerGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ogretmenVerilenDerslerGridView
            // 
            this.ogretmenVerilenDerslerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ogretmenVerilenDerslerGridView.Location = new System.Drawing.Point(357, 12);
            this.ogretmenVerilenDerslerGridView.Name = "ogretmenVerilenDerslerGridView";
            this.ogretmenVerilenDerslerGridView.Size = new System.Drawing.Size(246, 346);
            this.ogretmenVerilenDerslerGridView.TabIndex = 13;
            this.ogretmenVerilenDerslerGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ilgiAlanlariListBox
            // 
            this.ilgiAlanlariListBox.FormattingEnabled = true;
            this.ilgiAlanlariListBox.Location = new System.Drawing.Point(12, 87);
            this.ilgiAlanlariListBox.Name = "ilgiAlanlariListBox";
            this.ilgiAlanlariListBox.Size = new System.Drawing.Size(154, 212);
            this.ilgiAlanlariListBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "İlgi Alanları:";
            // 
            // kontenjanLabel
            // 
            this.kontenjanLabel.AutoSize = true;
            this.kontenjanLabel.Location = new System.Drawing.Point(12, 48);
            this.kontenjanLabel.Name = "kontenjanLabel";
            this.kontenjanLabel.Size = new System.Drawing.Size(64, 13);
            this.kontenjanLabel.TabIndex = 10;
            this.kontenjanLabel.Text = "Kontenjan =";
            // 
            // OgretmenİsimSoyisimLabel
            // 
            this.OgretmenİsimSoyisimLabel.AutoSize = true;
            this.OgretmenİsimSoyisimLabel.Location = new System.Drawing.Point(10, 22);
            this.OgretmenİsimSoyisimLabel.Name = "OgretmenİsimSoyisimLabel";
            this.OgretmenİsimSoyisimLabel.Size = new System.Drawing.Size(124, 13);
            this.OgretmenİsimSoyisimLabel.TabIndex = 9;
            this.OgretmenİsimSoyisimLabel.Text = "Öğretmen İsim-Soy isim =";
            // 
            // SicilNoLabel
            // 
            this.SicilNoLabel.AutoSize = true;
            this.SicilNoLabel.Location = new System.Drawing.Point(10, 35);
            this.SicilNoLabel.Name = "SicilNoLabel";
            this.SicilNoLabel.Size = new System.Drawing.Size(52, 13);
            this.SicilNoLabel.TabIndex = 8;
            this.SicilNoLabel.Text = "Sicil No =";
            this.SicilNoLabel.Click += new System.EventHandler(this.SicilNoLabel_Click);
            // 
            // OgretmenIDlabel
            // 
            this.OgretmenIDlabel.AutoSize = true;
            this.OgretmenIDlabel.Location = new System.Drawing.Point(10, 9);
            this.OgretmenIDlabel.Name = "OgretmenIDlabel";
            this.OgretmenIDlabel.Size = new System.Drawing.Size(76, 13);
            this.OgretmenIDlabel.TabIndex = 7;
            this.OgretmenIDlabel.Text = "Ögretmen ID =";
            // 
            // dersalabilecekogrencilerGridView
            // 
            this.dersalabilecekogrencilerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dersalabilecekogrencilerGridView.Location = new System.Drawing.Point(609, 12);
            this.dersalabilecekogrencilerGridView.Name = "dersalabilecekogrencilerGridView";
            this.dersalabilecekogrencilerGridView.Size = new System.Drawing.Size(572, 346);
            this.dersalabilecekogrencilerGridView.TabIndex = 14;
            this.dersalabilecekogrencilerGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // ilgialanisil
            // 
            this.ilgialanisil.Location = new System.Drawing.Point(12, 363);
            this.ilgialanisil.Name = "ilgialanisil";
            this.ilgialanisil.Size = new System.Drawing.Size(154, 26);
            this.ilgialanisil.TabIndex = 15;
            this.ilgialanisil.Text = "İlgi Alanı Sil";
            this.ilgialanisil.UseVisualStyleBackColor = true;
            this.ilgialanisil.Click += new System.EventHandler(this.ilgialanisil_Click);
            // 
            // ilgialanieklebutton
            // 
            this.ilgialanieklebutton.Location = new System.Drawing.Point(12, 331);
            this.ilgialanieklebutton.Name = "ilgialanieklebutton";
            this.ilgialanieklebutton.Size = new System.Drawing.Size(154, 26);
            this.ilgialanieklebutton.TabIndex = 16;
            this.ilgialanieklebutton.Text = "İlgi Alanı Ekle";
            this.ilgialanieklebutton.UseVisualStyleBackColor = true;
            this.ilgialanieklebutton.Click += new System.EventHandler(this.ilgialanieklebutton_Click);
            // 
            // ilgialaniekleTextBox
            // 
            this.ilgialaniekleTextBox.Location = new System.Drawing.Point(12, 305);
            this.ilgialaniekleTextBox.Name = "ilgialaniekleTextBox";
            this.ilgialaniekleTextBox.Size = new System.Drawing.Size(154, 20);
            this.ilgialaniekleTextBox.TabIndex = 17;
            this.ilgialaniekleTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dersfiltresiTextBox
            // 
            this.dersfiltresiTextBox.Location = new System.Drawing.Point(1187, 38);
            this.dersfiltresiTextBox.Name = "dersfiltresiTextBox";
            this.dersfiltresiTextBox.Size = new System.Drawing.Size(144, 20);
            this.dersfiltresiTextBox.TabIndex = 18;
            this.dersfiltresiTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1190, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Ders Filtresi:";
            // 
            // sıralaButton
            // 
            this.sıralaButton.Location = new System.Drawing.Point(1187, 68);
            this.sıralaButton.Name = "sıralaButton";
            this.sıralaButton.Size = new System.Drawing.Size(144, 23);
            this.sıralaButton.TabIndex = 20;
            this.sıralaButton.Text = "Ders Filtresi Uygula";
            this.sıralaButton.UseVisualStyleBackColor = true;
            this.sıralaButton.Click += new System.EventHandler(this.sıralaButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1187, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 46);
            this.button1.TabIndex = 21;
            this.button1.Text = "İlgi Alanlarına Göre Filtre Uygula";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kritikdersekleTextBox
            // 
            this.kritikdersekleTextBox.Location = new System.Drawing.Point(172, 305);
            this.kritikdersekleTextBox.Name = "kritikdersekleTextBox";
            this.kritikdersekleTextBox.Size = new System.Drawing.Size(154, 20);
            this.kritikdersekleTextBox.TabIndex = 26;
            // 
            // kritikderseklebutton
            // 
            this.kritikderseklebutton.Location = new System.Drawing.Point(172, 331);
            this.kritikderseklebutton.Name = "kritikderseklebutton";
            this.kritikderseklebutton.Size = new System.Drawing.Size(154, 26);
            this.kritikderseklebutton.TabIndex = 25;
            this.kritikderseklebutton.Text = "Kritik Ders Ekle";
            this.kritikderseklebutton.UseVisualStyleBackColor = true;
            this.kritikderseklebutton.Click += new System.EventHandler(this.kritikderseklebutton_Click);
            // 
            // kritikderssilbutton
            // 
            this.kritikderssilbutton.Location = new System.Drawing.Point(172, 363);
            this.kritikderssilbutton.Name = "kritikderssilbutton";
            this.kritikderssilbutton.Size = new System.Drawing.Size(154, 26);
            this.kritikderssilbutton.TabIndex = 24;
            this.kritikderssilbutton.Text = "Kritik Ders Sil";
            this.kritikderssilbutton.UseVisualStyleBackColor = true;
            this.kritikderssilbutton.Click += new System.EventHandler(this.kritikderssilbutton_Click);
            // 
            // kritikDerslerListBox
            // 
            this.kritikDerslerListBox.FormattingEnabled = true;
            this.kritikDerslerListBox.Location = new System.Drawing.Point(172, 87);
            this.kritikDerslerListBox.Name = "kritikDerslerListBox";
            this.kritikDerslerListBox.Size = new System.Drawing.Size(154, 212);
            this.kritikDerslerListBox.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Kritik Dersler";
            // 
            // OgretmenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 640);
            this.Controls.Add(this.kritikdersekleTextBox);
            this.Controls.Add(this.kritikderseklebutton);
            this.Controls.Add(this.kritikderssilbutton);
            this.Controls.Add(this.kritikDerslerListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sıralaButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dersfiltresiTextBox);
            this.Controls.Add(this.ilgialaniekleTextBox);
            this.Controls.Add(this.ilgialanieklebutton);
            this.Controls.Add(this.ilgialanisil);
            this.Controls.Add(this.dersalabilecekogrencilerGridView);
            this.Controls.Add(this.ogretmenVerilenDerslerGridView);
            this.Controls.Add(this.ilgiAlanlariListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kontenjanLabel);
            this.Controls.Add(this.OgretmenİsimSoyisimLabel);
            this.Controls.Add(this.SicilNoLabel);
            this.Controls.Add(this.OgretmenIDlabel);
            this.Name = "OgretmenForm";
            this.Text = "OgretmenForm";
            this.Load += new System.EventHandler(this.OgretmenForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ogretmenVerilenDerslerGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dersalabilecekogrencilerGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ogretmenVerilenDerslerGridView;
        private System.Windows.Forms.ListBox ilgiAlanlariListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label kontenjanLabel;
        private System.Windows.Forms.Label OgretmenİsimSoyisimLabel;
        private System.Windows.Forms.Label SicilNoLabel;
        private System.Windows.Forms.Label OgretmenIDlabel;
        private System.Windows.Forms.DataGridView dersalabilecekogrencilerGridView;
        private System.Windows.Forms.Button ilgialanisil;
        private System.Windows.Forms.Button ilgialanieklebutton;
        private System.Windows.Forms.TextBox ilgialaniekleTextBox;
        private System.Windows.Forms.TextBox dersfiltresiTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button sıralaButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox kritikdersekleTextBox;
        private System.Windows.Forms.Button kritikderseklebutton;
        private System.Windows.Forms.Button kritikderssilbutton;
        private System.Windows.Forms.ListBox kritikDerslerListBox;
        private System.Windows.Forms.Label label3;
    }
}