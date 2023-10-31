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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ilgialanisil = new System.Windows.Forms.Button();
            this.ilgialanieklebutton = new System.Windows.Forms.Button();
            this.ilgialaniekleTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ogretmenVerilenDerslerGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // ogretmenVerilenDerslerGridView
            // 
            this.ogretmenVerilenDerslerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ogretmenVerilenDerslerGridView.Location = new System.Drawing.Point(357, 12);
            this.ogretmenVerilenDerslerGridView.Name = "ogretmenVerilenDerslerGridView";
            this.ogretmenVerilenDerslerGridView.Size = new System.Drawing.Size(397, 346);
            this.ogretmenVerilenDerslerGridView.TabIndex = 13;
            this.ogretmenVerilenDerslerGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ilgiAlanlariListBox
            // 
            this.ilgiAlanlariListBox.FormattingEnabled = true;
            this.ilgiAlanlariListBox.Location = new System.Drawing.Point(9, 146);
            this.ilgiAlanlariListBox.Name = "ilgiAlanlariListBox";
            this.ilgiAlanlariListBox.Size = new System.Drawing.Size(168, 212);
            this.ilgiAlanlariListBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "İlgi Alanları:";
            // 
            // kontenjanLabel
            // 
            this.kontenjanLabel.AutoSize = true;
            this.kontenjanLabel.Location = new System.Drawing.Point(10, 97);
            this.kontenjanLabel.Name = "kontenjanLabel";
            this.kontenjanLabel.Size = new System.Drawing.Size(64, 13);
            this.kontenjanLabel.TabIndex = 10;
            this.kontenjanLabel.Text = "Kontenjan =";
            // 
            // OgretmenİsimSoyisimLabel
            // 
            this.OgretmenİsimSoyisimLabel.AutoSize = true;
            this.OgretmenİsimSoyisimLabel.Location = new System.Drawing.Point(9, 38);
            this.OgretmenİsimSoyisimLabel.Name = "OgretmenİsimSoyisimLabel";
            this.OgretmenİsimSoyisimLabel.Size = new System.Drawing.Size(124, 13);
            this.OgretmenİsimSoyisimLabel.TabIndex = 9;
            this.OgretmenİsimSoyisimLabel.Text = "Öğretmen İsim-Soy isim =";
            // 
            // SicilNoLabel
            // 
            this.SicilNoLabel.AutoSize = true;
            this.SicilNoLabel.Location = new System.Drawing.Point(10, 68);
            this.SicilNoLabel.Name = "SicilNoLabel";
            this.SicilNoLabel.Size = new System.Drawing.Size(52, 13);
            this.SicilNoLabel.TabIndex = 8;
            this.SicilNoLabel.Text = "Sicil No =";
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
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(760, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(397, 346);
            this.dataGridView2.TabIndex = 14;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // ilgialanisil
            // 
            this.ilgialanisil.Location = new System.Drawing.Point(186, 331);
            this.ilgialanisil.Name = "ilgialanisil";
            this.ilgialanisil.Size = new System.Drawing.Size(154, 26);
            this.ilgialanisil.TabIndex = 15;
            this.ilgialanisil.Text = "İlgi Alanı Sil";
            this.ilgialanisil.UseVisualStyleBackColor = true;
            this.ilgialanisil.Click += new System.EventHandler(this.ilgialanisil_Click);
            // 
            // ilgialanieklebutton
            // 
            this.ilgialanieklebutton.Location = new System.Drawing.Point(186, 299);
            this.ilgialanieklebutton.Name = "ilgialanieklebutton";
            this.ilgialanieklebutton.Size = new System.Drawing.Size(154, 26);
            this.ilgialanieklebutton.TabIndex = 16;
            this.ilgialanieklebutton.Text = "İlgi Alanı Ekle";
            this.ilgialanieklebutton.UseVisualStyleBackColor = true;
            this.ilgialanieklebutton.Click += new System.EventHandler(this.ilgialanieklebutton_Click);
            // 
            // ilgialaniekleTextBox
            // 
            this.ilgialaniekleTextBox.Location = new System.Drawing.Point(186, 273);
            this.ilgialaniekleTextBox.Name = "ilgialaniekleTextBox";
            this.ilgialaniekleTextBox.Size = new System.Drawing.Size(154, 20);
            this.ilgialaniekleTextBox.TabIndex = 17;
            this.ilgialaniekleTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // OgretmenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 363);
            this.Controls.Add(this.ilgialaniekleTextBox);
            this.Controls.Add(this.ilgialanieklebutton);
            this.Controls.Add(this.ilgialanisil);
            this.Controls.Add(this.dataGridView2);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button ilgialanisil;
        private System.Windows.Forms.Button ilgialanieklebutton;
        private System.Windows.Forms.TextBox ilgialaniekleTextBox;
    }
}