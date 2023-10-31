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
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciDersdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // OgrenciIDlabel
            // 
            this.OgrenciIDlabel.AutoSize = true;
            this.OgrenciIDlabel.Location = new System.Drawing.Point(13, 9);
            this.OgrenciIDlabel.Name = "OgrenciIDlabel";
            this.OgrenciIDlabel.Size = new System.Drawing.Size(67, 13);
            this.OgrenciIDlabel.TabIndex = 0;
            this.OgrenciIDlabel.Text = "Ögrenci ID =";
            // 
            // AGNOLabel
            // 
            this.AGNOLabel.AutoSize = true;
            this.AGNOLabel.Location = new System.Drawing.Point(13, 68);
            this.AGNOLabel.Name = "AGNOLabel";
            this.AGNOLabel.Size = new System.Drawing.Size(47, 13);
            this.AGNOLabel.TabIndex = 1;
            this.AGNOLabel.Text = "AGNO =";
            // 
            // OgrenciİsimSoyisimLabel
            // 
            this.OgrenciİsimSoyisimLabel.AutoSize = true;
            this.OgrenciİsimSoyisimLabel.Location = new System.Drawing.Point(12, 38);
            this.OgrenciİsimSoyisimLabel.Name = "OgrenciİsimSoyisimLabel";
            this.OgrenciİsimSoyisimLabel.Size = new System.Drawing.Size(115, 13);
            this.OgrenciİsimSoyisimLabel.TabIndex = 2;
            this.OgrenciİsimSoyisimLabel.Text = "Öğrenci İsim-Soy isim =";
            this.OgrenciİsimSoyisimLabel.Click += new System.EventHandler(this.OgrenciİsimSoyisimLabel_Click);
            // 
            // talepsayisiLabel
            // 
            this.talepsayisiLabel.AutoSize = true;
            this.talepsayisiLabel.Location = new System.Drawing.Point(13, 97);
            this.talepsayisiLabel.Name = "talepsayisiLabel";
            this.talepsayisiLabel.Size = new System.Drawing.Size(73, 13);
            this.talepsayisiLabel.TabIndex = 3;
            this.talepsayisiLabel.Text = "Talep Sayısı =";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "İlgi Alanları:";
            // 
            // ilgiAlanlariListBox
            // 
            this.ilgiAlanlariListBox.FormattingEnabled = true;
            this.ilgiAlanlariListBox.Location = new System.Drawing.Point(12, 146);
            this.ilgiAlanlariListBox.Name = "ilgiAlanlariListBox";
            this.ilgiAlanlariListBox.Size = new System.Drawing.Size(284, 212);
            this.ilgiAlanlariListBox.TabIndex = 5;
            // 
            // ogrenciDersdataGridView
            // 
            this.ogrenciDersdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ogrenciDersdataGridView.Location = new System.Drawing.Point(302, 12);
            this.ogrenciDersdataGridView.Name = "ogrenciDersdataGridView";
            this.ogrenciDersdataGridView.Size = new System.Drawing.Size(789, 346);
            this.ogrenciDersdataGridView.TabIndex = 6;
            // 
            // OgrenciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 370);
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
    }
}