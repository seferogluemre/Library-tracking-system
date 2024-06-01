namespace Kütüphane_Takip_Sistemi
{
    partial class FrmÖgrenciSorgu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmÖgrenciSorgu));
            this.listboxKayıtlar = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSorgu = new System.Windows.Forms.Label();
            this.txtÖgr = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.checkAdsorgu = new System.Windows.Forms.CheckBox();
            this.checkSnfSorgu = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFetchData = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listboxKayıtlar
            // 
            this.listboxKayıtlar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listboxKayıtlar.FormattingEnabled = true;
            this.listboxKayıtlar.ItemHeight = 21;
            this.listboxKayıtlar.Location = new System.Drawing.Point(174, 31);
            this.listboxKayıtlar.Name = "listboxKayıtlar";
            this.listboxKayıtlar.Size = new System.Drawing.Size(181, 340);
            this.listboxKayıtlar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(225, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kayıtlar";
            // 
            // labelSorgu
            // 
            this.labelSorgu.AutoSize = true;
            this.labelSorgu.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSorgu.Location = new System.Drawing.Point(2, 22);
            this.labelSorgu.Name = "labelSorgu";
            this.labelSorgu.Size = new System.Drawing.Size(91, 20);
            this.labelSorgu.TabIndex = 2;
            this.labelSorgu.Text = "Ögrenci No:";
            // 
            // txtÖgr
            // 
            this.txtÖgr.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtÖgr.Location = new System.Drawing.Point(6, 46);
            this.txtÖgr.MaxLength = 40;
            this.txtÖgr.Name = "txtÖgr";
            this.txtÖgr.Size = new System.Drawing.Size(149, 27);
            this.txtÖgr.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.checkAdsorgu);
            this.panel1.Controls.Add(this.checkSnfSorgu);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel1.Location = new System.Drawing.Point(13, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(142, 190);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Listeyi temizle";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // checkAdsorgu
            // 
            this.checkAdsorgu.AutoSize = true;
            this.checkAdsorgu.Location = new System.Drawing.Point(3, 28);
            this.checkAdsorgu.Name = "checkAdsorgu";
            this.checkAdsorgu.Size = new System.Drawing.Size(138, 24);
            this.checkAdsorgu.TabIndex = 2;
            this.checkAdsorgu.Text = "Ad Soyad Sorgu";
            this.checkAdsorgu.UseVisualStyleBackColor = true;
            this.checkAdsorgu.CheckedChanged += new System.EventHandler(this.checkAdsorgu_CheckedChanged);
            // 
            // checkSnfSorgu
            // 
            this.checkSnfSorgu.AutoSize = true;
            this.checkSnfSorgu.Location = new System.Drawing.Point(3, 58);
            this.checkSnfSorgu.Name = "checkSnfSorgu";
            this.checkSnfSorgu.Size = new System.Drawing.Size(103, 24);
            this.checkSnfSorgu.TabIndex = 1;
            this.checkSnfSorgu.Text = "Sınıf Sorgu";
            this.checkSnfSorgu.UseVisualStyleBackColor = true;
            this.checkSnfSorgu.CheckedChanged += new System.EventHandler(this.checkSnfSorgu_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(17, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sorgular;";
            // 
            // btnFetchData
            // 
            this.btnFetchData.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFetchData.Location = new System.Drawing.Point(6, 79);
            this.btnFetchData.Name = "btnFetchData";
            this.btnFetchData.Size = new System.Drawing.Size(87, 29);
            this.btnFetchData.TabIndex = 5;
            this.btnFetchData.Text = "Sorgula";
            this.btnFetchData.UseVisualStyleBackColor = true;
            this.btnFetchData.Click += new System.EventHandler(this.btnFetchData_Click_1);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(6, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "Sorgula";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(6, 79);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 29);
            this.button2.TabIndex = 7;
            this.button2.Text = "Sorgula";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmÖgrenciSorgu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(123)))), ((int)(((byte)(141)))));
            this.ClientSize = new System.Drawing.Size(367, 373);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnFetchData);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtÖgr);
            this.Controls.Add(this.labelSorgu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listboxKayıtlar);
            this.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmÖgrenciSorgu";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ögrenci Sorgu";
            this.Load += new System.EventHandler(this.FrmÖgrenciSorgu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listboxKayıtlar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSorgu;
        private System.Windows.Forms.TextBox txtÖgr;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFetchData;
        private System.Windows.Forms.CheckBox checkSnfSorgu;
        private System.Windows.Forms.CheckBox checkAdsorgu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
    }
}