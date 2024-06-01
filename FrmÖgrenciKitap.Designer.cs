namespace Kütüphane_Takip_Sistemi
{
    partial class FrmÖgrenciKitap
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmÖgrenciKitap));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtÖgradsoyad = new System.Windows.Forms.TextBox();
            this.txtokulno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbboxKitaplar = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.maskVeriliştarihi = new System.Windows.Forms.MaskedTextBox();
            this.maskalınıştarih = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnKayıt = new System.Windows.Forms.Button();
            this.btnGüncel = new System.Windows.Forms.Button();
            this.Btnsilme = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSorgutxt = new System.Windows.Forms.Label();
            this.listboxSorgu = new System.Windows.Forms.ListBox();
            this.txtSorgu = new System.Windows.Forms.TextBox();
            this.checkbxSorgu = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtKitabAd = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.listBoxKayıtlıKitaplar = new System.Windows.Forms.ListBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeight = 25;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Location = new System.Drawing.Point(1, 224);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 50;
            this.dataGridView1.Size = new System.Drawing.Size(1275, 299);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ögrenci Ad-Soyad:";
            // 
            // txtÖgradsoyad
            // 
            this.txtÖgradsoyad.Location = new System.Drawing.Point(152, 41);
            this.txtÖgradsoyad.MaxLength = 45;
            this.txtÖgradsoyad.Name = "txtÖgradsoyad";
            this.txtÖgradsoyad.Size = new System.Drawing.Size(155, 27);
            this.txtÖgradsoyad.TabIndex = 2;
            // 
            // txtokulno
            // 
            this.txtokulno.Location = new System.Drawing.Point(152, 87);
            this.txtokulno.MaxLength = 5;
            this.txtokulno.Name = "txtokulno";
            this.txtokulno.Size = new System.Drawing.Size(155, 27);
            this.txtokulno.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Okul Numarası:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(337, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kitap Adı:";
            // 
            // cmbboxKitaplar
            // 
            this.cmbboxKitaplar.FormattingEnabled = true;
            this.cmbboxKitaplar.Location = new System.Drawing.Point(418, 40);
            this.cmbboxKitaplar.Name = "cmbboxKitaplar";
            this.cmbboxKitaplar.Size = new System.Drawing.Size(155, 28);
            this.cmbboxKitaplar.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Veriliş Tarihi:";
            // 
            // maskVeriliştarihi
            // 
            this.maskVeriliştarihi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskVeriliştarihi.Location = new System.Drawing.Point(418, 85);
            this.maskVeriliştarihi.Mask = "00/00/0000";
            this.maskVeriliştarihi.Name = "maskVeriliştarihi";
            this.maskVeriliştarihi.Size = new System.Drawing.Size(155, 29);
            this.maskVeriliştarihi.TabIndex = 8;
            this.maskVeriliştarihi.ValidatingType = typeof(System.DateTime);
            // 
            // maskalınıştarih
            // 
            this.maskalınıştarih.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskalınıştarih.Location = new System.Drawing.Point(418, 134);
            this.maskalınıştarih.Mask = "00000000";
            this.maskalınıştarih.Name = "maskalınıştarih";
            this.maskalınıştarih.Size = new System.Drawing.Size(155, 29);
            this.maskalınıştarih.TabIndex = 10;
            this.maskalınıştarih.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(320, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Alınış Tarihi:";
            // 
            // btnKayıt
            // 
            this.btnKayıt.Location = new System.Drawing.Point(589, 37);
            this.btnKayıt.Name = "btnKayıt";
            this.btnKayıt.Size = new System.Drawing.Size(120, 27);
            this.btnKayıt.TabIndex = 11;
            this.btnKayıt.Text = "Kayıt Yap";
            this.btnKayıt.UseVisualStyleBackColor = true;
            this.btnKayıt.Click += new System.EventHandler(this.btnKayıt_Click);
            // 
            // btnGüncel
            // 
            this.btnGüncel.Location = new System.Drawing.Point(589, 81);
            this.btnGüncel.Name = "btnGüncel";
            this.btnGüncel.Size = new System.Drawing.Size(120, 27);
            this.btnGüncel.TabIndex = 12;
            this.btnGüncel.Text = "Kayıt Güncelle";
            this.btnGüncel.UseVisualStyleBackColor = true;
            this.btnGüncel.Click += new System.EventHandler(this.btnGüncel_Click);
            // 
            // Btnsilme
            // 
            this.Btnsilme.Location = new System.Drawing.Point(589, 127);
            this.Btnsilme.Name = "Btnsilme";
            this.Btnsilme.Size = new System.Drawing.Size(120, 27);
            this.Btnsilme.TabIndex = 13;
            this.Btnsilme.Text = "Kayıt Sil";
            this.Btnsilme.UseVisualStyleBackColor = true;
            this.Btnsilme.Click += new System.EventHandler(this.Btnsilme_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(102, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Sınıf:";
            // 
            // lblSorgutxt
            // 
            this.lblSorgutxt.AutoSize = true;
            this.lblSorgutxt.Location = new System.Drawing.Point(743, 9);
            this.lblSorgutxt.Name = "lblSorgutxt";
            this.lblSorgutxt.Size = new System.Drawing.Size(115, 20);
            this.lblSorgutxt.TabIndex = 16;
            this.lblSorgutxt.Text = "Okul Numarası:";
            // 
            // listboxSorgu
            // 
            this.listboxSorgu.FormattingEnabled = true;
            this.listboxSorgu.ItemHeight = 20;
            this.listboxSorgu.Location = new System.Drawing.Point(747, 37);
            this.listboxSorgu.Name = "listboxSorgu";
            this.listboxSorgu.Size = new System.Drawing.Size(307, 184);
            this.listboxSorgu.TabIndex = 17;
            // 
            // txtSorgu
            // 
            this.txtSorgu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSorgu.Location = new System.Drawing.Point(861, 6);
            this.txtSorgu.MaxLength = 5;
            this.txtSorgu.Name = "txtSorgu";
            this.txtSorgu.Size = new System.Drawing.Size(126, 25);
            this.txtSorgu.TabIndex = 18;
            // 
            // checkbxSorgu
            // 
            this.checkbxSorgu.AutoSize = true;
            this.checkbxSorgu.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.checkbxSorgu.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkbxSorgu.Location = new System.Drawing.Point(1060, 4);
            this.checkbxSorgu.Name = "checkbxSorgu";
            this.checkbxSorgu.Size = new System.Drawing.Size(137, 24);
            this.checkbxSorgu.TabIndex = 19;
            this.checkbxSorgu.Text = "Ad-Soyad Sorgu";
            this.checkbxSorgu.UseVisualStyleBackColor = true;
            this.checkbxSorgu.CheckedChanged += new System.EventHandler(this.checkbxSorgu_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(993, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(993, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(152, 134);
            this.textBox1.MaxLength = 7;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 27);
            this.textBox1.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(589, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 27);
            this.button1.TabIndex = 23;
            this.button1.Text = "Temizle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1209, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Kitap Ad";
            // 
            // TxtKitabAd
            // 
            this.TxtKitabAd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKitabAd.Location = new System.Drawing.Point(1279, 7);
            this.TxtKitabAd.MaxLength = 40;
            this.TxtKitabAd.Name = "TxtKitabAd";
            this.TxtKitabAd.Size = new System.Drawing.Size(153, 25);
            this.TxtKitabAd.TabIndex = 25;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1444, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 28);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // listBoxKayıtlıKitaplar
            // 
            this.listBoxKayıtlıKitaplar.FormattingEnabled = true;
            this.listBoxKayıtlıKitaplar.ItemHeight = 20;
            this.listBoxKayıtlıKitaplar.Location = new System.Drawing.Point(1279, 37);
            this.listBoxKayıtlıKitaplar.Name = "listBoxKayıtlıKitaplar";
            this.listBoxKayıtlıKitaplar.Size = new System.Drawing.Size(244, 484);
            this.listBoxKayıtlıKitaplar.TabIndex = 27;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1483, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 28);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 28;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(565, -2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 27);
            this.button2.TabIndex = 29;
            this.button2.Text = "Ögrenci Sorgu Paneli";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(1024, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(30, 28);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 30;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(1, -2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(50, 34);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 31;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmÖgrenciKitap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(161)))));
            this.ClientSize = new System.Drawing.Size(1522, 522);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.listBoxKayıtlıKitaplar);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.TxtKitabAd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkbxSorgu);
            this.Controls.Add(this.txtSorgu);
            this.Controls.Add(this.listboxSorgu);
            this.Controls.Add(this.lblSorgutxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Btnsilme);
            this.Controls.Add(this.btnGüncel);
            this.Controls.Add(this.btnKayıt);
            this.Controls.Add(this.maskalınıştarih);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.maskVeriliştarihi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbboxKitaplar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtokulno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtÖgradsoyad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmÖgrenciKitap";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ögrenci Kitap Kayıt";
            this.Load += new System.EventHandler(this.FrmÖgrenciKitap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtÖgradsoyad;
        private System.Windows.Forms.TextBox txtokulno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbboxKitaplar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskVeriliştarihi;
        private System.Windows.Forms.MaskedTextBox maskalınıştarih;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnKayıt;
        private System.Windows.Forms.Button btnGüncel;
        private System.Windows.Forms.Button Btnsilme;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSorgutxt;
        private System.Windows.Forms.ListBox listboxSorgu;
        private System.Windows.Forms.TextBox txtSorgu;
        private System.Windows.Forms.CheckBox checkbxSorgu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtKitabAd;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ListBox listBoxKayıtlıKitaplar;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Timer timer1;
    }
}