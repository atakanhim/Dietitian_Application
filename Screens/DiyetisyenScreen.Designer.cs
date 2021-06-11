
namespace diyetisyenproje
{
    partial class DiyetisyenScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiyetisyenScreen));
            this.exit_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.hastaTablosu = new System.Windows.Forms.DataGridView();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.hastaTedaviEt = new System.Windows.Forms.Button();
            this.name_label = new System.Windows.Forms.Label();
            this.hasta_bilgileri_lbl = new System.Windows.Forms.Label();
            this.currenttarih = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.addNewHasta_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hastaTablosu)).BeginInit();
            this.SuspendLayout();
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.Transparent;
            this.exit_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exit_btn.BackgroundImage")));
            this.exit_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exit_btn.FlatAppearance.BorderSize = 0;
            this.exit_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.exit_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_btn.Location = new System.Drawing.Point(1176, 12);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(44, 37);
            this.exit_btn.TabIndex = 63;
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.Transparent;
            this.back_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back_btn.BackgroundImage")));
            this.back_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back_btn.FlatAppearance.BorderSize = 0;
            this.back_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.back_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_btn.Location = new System.Drawing.Point(1126, 12);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(44, 37);
            this.back_btn.TabIndex = 62;
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // hastaTablosu
            // 
            this.hastaTablosu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.hastaTablosu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hastaTablosu.ColumnHeadersVisible = false;
            this.hastaTablosu.Location = new System.Drawing.Point(24, 161);
            this.hastaTablosu.Name = "hastaTablosu";
            this.hastaTablosu.ReadOnly = true;
            this.hastaTablosu.RowHeadersVisible = false;
            this.hastaTablosu.Size = new System.Drawing.Size(907, 303);
            this.hastaTablosu.TabIndex = 64;
            this.hastaTablosu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HastaTablosu_CellClick);
            // 
            // textBox14
            // 
            this.textBox14.BackColor = System.Drawing.Color.LightBlue;
            this.textBox14.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox14.Enabled = false;
            this.textBox14.Location = new System.Drawing.Point(24, 115);
            this.textBox14.Margin = new System.Windows.Forms.Padding(2);
            this.textBox14.Multiline = true;
            this.textBox14.Name = "textBox14";
            this.textBox14.ReadOnly = true;
            this.textBox14.Size = new System.Drawing.Size(104, 17);
            this.textBox14.TabIndex = 74;
            this.textBox14.Text = "Hasta Tc";
            this.textBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightBlue;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(526, 115);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(104, 17);
            this.textBox1.TabIndex = 74;
            this.textBox1.Text = "Hasta Diyeti";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.LightBlue;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(132, 115);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(86, 17);
            this.textBox2.TabIndex = 74;
            this.textBox2.Text = "Hasta Ad";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.LightBlue;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(222, 115);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(102, 17);
            this.textBox3.TabIndex = 74;
            this.textBox3.Text = "Hasta Soyad";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.LightBlue;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(431, 115);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(91, 17);
            this.textBox4.TabIndex = 74;
            this.textBox4.Text = "Hasta Şikayeti";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.LightBlue;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(328, 115);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(99, 17);
            this.textBox5.TabIndex = 74;
            this.textBox5.Text = "Hasta Telefon No";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // hastaTedaviEt
            // 
            this.hastaTedaviEt.Location = new System.Drawing.Point(896, 536);
            this.hastaTedaviEt.Name = "hastaTedaviEt";
            this.hastaTedaviEt.Size = new System.Drawing.Size(324, 58);
            this.hastaTedaviEt.TabIndex = 75;
            this.hastaTedaviEt.Text = "Hastayı Tedavi ET";
            this.hastaTedaviEt.UseVisualStyleBackColor = true;
            this.hastaTedaviEt.Click += new System.EventHandler(this.HastaTedaviEt_Click);
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.name_label.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.name_label.Location = new System.Drawing.Point(20, 25);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(134, 24);
            this.name_label.TabIndex = 65;
            this.name_label.Text = "Diyetisyen Adı";
            // 
            // hasta_bilgileri_lbl
            // 
            this.hasta_bilgileri_lbl.AutoSize = true;
            this.hasta_bilgileri_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hasta_bilgileri_lbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.hasta_bilgileri_lbl.Location = new System.Drawing.Point(936, 115);
            this.hasta_bilgileri_lbl.Name = "hasta_bilgileri_lbl";
            this.hasta_bilgileri_lbl.Size = new System.Drawing.Size(109, 19);
            this.hasta_bilgileri_lbl.TabIndex = 65;
            this.hasta_bilgileri_lbl.Text = "Hasta Bilgileri";
            // 
            // currenttarih
            // 
            this.currenttarih.AutoSize = true;
            this.currenttarih.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.currenttarih.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.currenttarih.Location = new System.Drawing.Point(1067, 70);
            this.currenttarih.Name = "currenttarih";
            this.currenttarih.Size = new System.Drawing.Size(46, 19);
            this.currenttarih.TabIndex = 65;
            this.currenttarih.Text = "Tarih";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.LightBlue;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(634, 115);
            this.textBox6.Margin = new System.Windows.Forms.Padding(2);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(91, 17);
            this.textBox6.TabIndex = 74;
            this.textBox6.Text = "Hasta Kayıt Tarihi";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.LightBlue;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Enabled = false;
            this.textBox7.Location = new System.Drawing.Point(729, 115);
            this.textBox7.Margin = new System.Windows.Forms.Padding(2);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(99, 17);
            this.textBox7.TabIndex = 74;
            this.textBox7.Text = "Hasta Son Kontrol";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.LightBlue;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Enabled = false;
            this.textBox8.Location = new System.Drawing.Point(832, 115);
            this.textBox8.Margin = new System.Windows.Forms.Padding(2);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(99, 17);
            this.textBox8.TabIndex = 74;
            this.textBox8.Text = "Hasta Diyetisyeni";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // addNewHasta_btn
            // 
            this.addNewHasta_btn.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addNewHasta_btn.Location = new System.Drawing.Point(24, 536);
            this.addNewHasta_btn.Name = "addNewHasta_btn";
            this.addNewHasta_btn.Size = new System.Drawing.Size(263, 58);
            this.addNewHasta_btn.TabIndex = 76;
            this.addNewHasta_btn.Text = "Yeni Hasta Ekle";
            this.addNewHasta_btn.UseVisualStyleBackColor = true;
            this.addNewHasta_btn.Click += new System.EventHandler(this.AddNewHasta_btn_Click);
            // 
            // DiyetisyenScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1232, 606);
            this.Controls.Add(this.addNewHasta_btn);
            this.Controls.Add(this.hastaTedaviEt);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.hasta_bilgileri_lbl);
            this.Controls.Add(this.currenttarih);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.hastaTablosu);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.back_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DiyetisyenScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DiyetisyenScreen";
            this.Load += new System.EventHandler(this.DiyetisyenScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hastaTablosu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.DataGridView hastaTablosu;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button hastaTedaviEt;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label hasta_bilgileri_lbl;
        private System.Windows.Forms.Label currenttarih;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button addNewHasta_btn;
    }
}