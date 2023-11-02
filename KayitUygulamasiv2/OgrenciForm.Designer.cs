namespace KayitUygulamasiv2
{
    partial class OgrenciForm
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
            this.OgrenciIDlabel = new System.Windows.Forms.Label();
            this.AGNOLabel = new System.Windows.Forms.Label();
            this.OgrenciİsimSoyisimLabel = new System.Windows.Forms.Label();
            this.talepsayisiLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ilgiAlanlariListBox = new System.Windows.Forms.ListBox();
            this.ogrenciDersdataGridView = new System.Windows.Forms.DataGridView();
            this.ogrencitalepgondermedataGridView = new System.Windows.Forms.DataGridView();
            this.filtreBox = new System.Windows.Forms.TextBox();
            this.ilgialanifiltreButton = new System.Windows.Forms.Button();
            this.dersadifltreButton = new System.Windows.Forms.Button();
            this.talepgondertabloyenilebutton = new System.Windows.Forms.Button();
            this.talepgonderButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciDersdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrencitalepgondermedataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // OgrenciIDlabel
            // 
            this.OgrenciIDlabel.AutoSize = true;
            this.OgrenciIDlabel.Location = new System.Drawing.Point(9, 9);
            this.OgrenciIDlabel.Name = "OgrenciIDlabel";
            this.OgrenciIDlabel.Size = new System.Drawing.Size(67, 13);
            this.OgrenciIDlabel.TabIndex = 0;
            this.OgrenciIDlabel.Text = "Ögrenci ID =";
            // 
            // AGNOLabel
            // 
            this.AGNOLabel.AutoSize = true;
            this.AGNOLabel.Location = new System.Drawing.Point(9, 35);
            this.AGNOLabel.Name = "AGNOLabel";
            this.AGNOLabel.Size = new System.Drawing.Size(47, 13);
            this.AGNOLabel.TabIndex = 1;
            this.AGNOLabel.Text = "AGNO =";
            // 
            // OgrenciİsimSoyisimLabel
            // 
            this.OgrenciİsimSoyisimLabel.AutoSize = true;
            this.OgrenciİsimSoyisimLabel.Location = new System.Drawing.Point(9, 22);
            this.OgrenciİsimSoyisimLabel.Name = "OgrenciİsimSoyisimLabel";
            this.OgrenciİsimSoyisimLabel.Size = new System.Drawing.Size(115, 13);
            this.OgrenciİsimSoyisimLabel.TabIndex = 2;
            this.OgrenciİsimSoyisimLabel.Text = "Öğrenci İsim-Soy isim =";
            this.OgrenciİsimSoyisimLabel.Click += new System.EventHandler(this.OgrenciİsimSoyisimLabel_Click);
            // 
            // talepsayisiLabel
            // 
            this.talepsayisiLabel.AutoSize = true;
            this.talepsayisiLabel.Location = new System.Drawing.Point(9, 48);
            this.talepsayisiLabel.Name = "talepsayisiLabel";
            this.talepsayisiLabel.Size = new System.Drawing.Size(73, 13);
            this.talepsayisiLabel.TabIndex = 3;
            this.talepsayisiLabel.Text = "Talep Sayısı =";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "İlgi Alanları:";
            // 
            // ilgiAlanlariListBox
            // 
            this.ilgiAlanlariListBox.FormattingEnabled = true;
            this.ilgiAlanlariListBox.Location = new System.Drawing.Point(12, 83);
            this.ilgiAlanlariListBox.Name = "ilgiAlanlariListBox";
            this.ilgiAlanlariListBox.Size = new System.Drawing.Size(195, 277);
            this.ilgiAlanlariListBox.TabIndex = 5;
            // 
            // ogrenciDersdataGridView
            // 
            this.ogrenciDersdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ogrenciDersdataGridView.Location = new System.Drawing.Point(279, 12);
            this.ogrenciDersdataGridView.Name = "ogrenciDersdataGridView";
            this.ogrenciDersdataGridView.Size = new System.Drawing.Size(464, 346);
            this.ogrenciDersdataGridView.TabIndex = 6;
            // 
            // ogrencitalepgondermedataGridView
            // 
            this.ogrencitalepgondermedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ogrencitalepgondermedataGridView.Location = new System.Drawing.Point(749, 12);
            this.ogrencitalepgondermedataGridView.Name = "ogrencitalepgondermedataGridView";
            this.ogrencitalepgondermedataGridView.Size = new System.Drawing.Size(586, 346);
            this.ogrencitalepgondermedataGridView.TabIndex = 7;
            // 
            // filtreBox
            // 
            this.filtreBox.Location = new System.Drawing.Point(971, 364);
            this.filtreBox.Name = "filtreBox";
            this.filtreBox.Size = new System.Drawing.Size(100, 20);
            this.filtreBox.TabIndex = 8;
            // 
            // ilgialanifiltreButton
            // 
            this.ilgialanifiltreButton.Location = new System.Drawing.Point(1077, 364);
            this.ilgialanifiltreButton.Name = "ilgialanifiltreButton";
            this.ilgialanifiltreButton.Size = new System.Drawing.Size(125, 23);
            this.ilgialanifiltreButton.TabIndex = 9;
            this.ilgialanifiltreButton.Text = "İlgi Alanına Göre Filtrele";
            this.ilgialanifiltreButton.UseVisualStyleBackColor = true;
            this.ilgialanifiltreButton.Click += new System.EventHandler(this.ilgialanifiltreButton_Click);
            // 
            // dersadifltreButton
            // 
            this.dersadifltreButton.Location = new System.Drawing.Point(1208, 364);
            this.dersadifltreButton.Name = "dersadifltreButton";
            this.dersadifltreButton.Size = new System.Drawing.Size(127, 23);
            this.dersadifltreButton.TabIndex = 10;
            this.dersadifltreButton.Text = "Ders Adına Göre Filtrele";
            this.dersadifltreButton.UseVisualStyleBackColor = true;
            this.dersadifltreButton.Click += new System.EventHandler(this.dersadifltreButton_Click);
            // 
            // talepgondertabloyenilebutton
            // 
            this.talepgondertabloyenilebutton.Location = new System.Drawing.Point(835, 364);
            this.talepgondertabloyenilebutton.Name = "talepgondertabloyenilebutton";
            this.talepgondertabloyenilebutton.Size = new System.Drawing.Size(130, 23);
            this.talepgondertabloyenilebutton.TabIndex = 11;
            this.talepgondertabloyenilebutton.Text = "Talep Tablosunu Yenile";
            this.talepgondertabloyenilebutton.UseVisualStyleBackColor = true;
            this.talepgondertabloyenilebutton.Click += new System.EventHandler(this.talepgondertabloyenilebutton_Click);
            // 
            // talepgonderButton
            // 
            this.talepgonderButton.Location = new System.Drawing.Point(749, 364);
            this.talepgonderButton.Name = "talepgonderButton";
            this.talepgonderButton.Size = new System.Drawing.Size(80, 23);
            this.talepgonderButton.TabIndex = 12;
            this.talepgonderButton.Text = "Talep Gönder";
            this.talepgonderButton.UseVisualStyleBackColor = true;
            this.talepgonderButton.Click += new System.EventHandler(this.talepgonderButton_Click);
            // 
            // OgrenciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 627);
            this.Controls.Add(this.talepgonderButton);
            this.Controls.Add(this.talepgondertabloyenilebutton);
            this.Controls.Add(this.dersadifltreButton);
            this.Controls.Add(this.ilgialanifiltreButton);
            this.Controls.Add(this.filtreBox);
            this.Controls.Add(this.ogrencitalepgondermedataGridView);
            this.Controls.Add(this.ogrenciDersdataGridView);
            this.Controls.Add(this.ilgiAlanlariListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.talepsayisiLabel);
            this.Controls.Add(this.OgrenciİsimSoyisimLabel);
            this.Controls.Add(this.AGNOLabel);
            this.Controls.Add(this.OgrenciIDlabel);
            this.Name = "OgrenciForm";
            this.Text = "OgrenciForm";
            this.Load += new System.EventHandler(this.OgrenciForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciDersdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrencitalepgondermedataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OgrenciIDlabel;
        private System.Windows.Forms.Label AGNOLabel;
        private System.Windows.Forms.Label OgrenciİsimSoyisimLabel;
        private System.Windows.Forms.Label talepsayisiLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ilgiAlanlariListBox;
        private System.Windows.Forms.DataGridView ogrenciDersdataGridView;
        private System.Windows.Forms.DataGridView ogrencitalepgondermedataGridView;
        private System.Windows.Forms.TextBox filtreBox;
        private System.Windows.Forms.Button ilgialanifiltreButton;
        private System.Windows.Forms.Button dersadifltreButton;
        private System.Windows.Forms.Button talepgondertabloyenilebutton;
        private System.Windows.Forms.Button talepgonderButton;
    }
}