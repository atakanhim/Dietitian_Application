
namespace diyetisyenproje.Screens
{
    partial class HastaTedaviScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HastaTedaviScreen));
            this.back_btn = new System.Windows.Forms.Button();
            this.hasta_bilgileri_lbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.hasta_sikayeti = new System.Windows.Forms.Label();
            this.HastaSikayetleri_combo = new System.Windows.Forms.ComboBox();
            this.sikayetlistele_label = new System.Windows.Forms.Label();
            this.DiyetTuruCombo_combo = new System.Windows.Forms.ComboBox();
            this.hastalikEkleGrpbox = new System.Windows.Forms.GroupBox();
            this.HastalikEkle_btn = new System.Windows.Forms.Button();
            this.hastaaciklama_txt = new System.Windows.Forms.TextBox();
            this.hastalikAdi_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.diyetsec_label = new System.Windows.Forms.Label();
            this.diyeteklegrpbox = new System.Windows.Forms.GroupBox();
            this.DiyetEkle_btn = new System.Windows.Forms.Button();
            this.persenbe_txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.diyetadı_txt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pazar_txt = new System.Windows.Forms.TextBox();
            this.cumartesi_txt = new System.Windows.Forms.TextBox();
            this.pazartesi_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.carsanba_txt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cuma_txt = new System.Windows.Forms.TextBox();
            this.sali_txt = new System.Windows.Forms.TextBox();
            this.diyet_bilgisi = new System.Windows.Forms.Label();
            this.tedavi_et_btn = new System.Windows.Forms.Button();
            this.rapor_goruntule_btn = new System.Windows.Forms.Button();
            this.hastalikEkleGrpbox.SuspendLayout();
            this.diyeteklegrpbox.SuspendLayout();
            this.SuspendLayout();
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
            this.back_btn.Location = new System.Drawing.Point(1244, 12);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(44, 37);
            this.back_btn.TabIndex = 63;
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // hasta_bilgileri_lbl
            // 
            this.hasta_bilgileri_lbl.AutoSize = true;
            this.hasta_bilgileri_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hasta_bilgileri_lbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.hasta_bilgileri_lbl.Location = new System.Drawing.Point(12, 20);
            this.hasta_bilgileri_lbl.Name = "hasta_bilgileri_lbl";
            this.hasta_bilgileri_lbl.Size = new System.Drawing.Size(109, 19);
            this.hasta_bilgileri_lbl.TabIndex = 66;
            this.hasta_bilgileri_lbl.Text = "Hasta Bilgileri";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(350, 24);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(26, 680);
            this.textBox1.TabIndex = 67;
            // 
            // hasta_sikayeti
            // 
            this.hasta_sikayeti.AutoSize = true;
            this.hasta_sikayeti.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hasta_sikayeti.Location = new System.Drawing.Point(382, 50);
            this.hasta_sikayeti.Name = "hasta_sikayeti";
            this.hasta_sikayeti.Size = new System.Drawing.Size(178, 25);
            this.hasta_sikayeti.TabIndex = 68;
            this.hasta_sikayeti.Text = "Hasta Şikayeti :";
            // 
            // HastaSikayetleri_combo
            // 
            this.HastaSikayetleri_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HastaSikayetleri_combo.FormattingEnabled = true;
            this.HastaSikayetleri_combo.Location = new System.Drawing.Point(485, 127);
            this.HastaSikayetleri_combo.Name = "HastaSikayetleri_combo";
            this.HastaSikayetleri_combo.Size = new System.Drawing.Size(121, 21);
            this.HastaSikayetleri_combo.TabIndex = 69;
            this.HastaSikayetleri_combo.Visible = false;
            this.HastaSikayetleri_combo.SelectedIndexChanged += new System.EventHandler(this.HastaSikayetleri_combo_SelectedIndexChanged);
            // 
            // sikayetlistele_label
            // 
            this.sikayetlistele_label.AutoSize = true;
            this.sikayetlistele_label.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sikayetlistele_label.Location = new System.Drawing.Point(495, 95);
            this.sikayetlistele_label.Name = "sikayetlistele_label";
            this.sikayetlistele_label.Size = new System.Drawing.Size(94, 19);
            this.sikayetlistele_label.TabIndex = 68;
            this.sikayetlistele_label.Text = "Hastalık Seç";
            // 
            // DiyetTuruCombo_combo
            // 
            this.DiyetTuruCombo_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DiyetTuruCombo_combo.FormattingEnabled = true;
            this.DiyetTuruCombo_combo.Location = new System.Drawing.Point(1033, 127);
            this.DiyetTuruCombo_combo.Name = "DiyetTuruCombo_combo";
            this.DiyetTuruCombo_combo.Size = new System.Drawing.Size(195, 21);
            this.DiyetTuruCombo_combo.TabIndex = 69;
            this.DiyetTuruCombo_combo.Visible = false;
            this.DiyetTuruCombo_combo.SelectedIndexChanged += new System.EventHandler(this.DiyetTuruCombo_combo_SelectedIndexChanged);
            // 
            // hastalikEkleGrpbox
            // 
            this.hastalikEkleGrpbox.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.hastalikEkleGrpbox.Controls.Add(this.HastalikEkle_btn);
            this.hastalikEkleGrpbox.Controls.Add(this.hastaaciklama_txt);
            this.hastalikEkleGrpbox.Controls.Add(this.hastalikAdi_txt);
            this.hastalikEkleGrpbox.Controls.Add(this.label3);
            this.hastalikEkleGrpbox.Controls.Add(this.label2);
            this.hastalikEkleGrpbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hastalikEkleGrpbox.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hastalikEkleGrpbox.Location = new System.Drawing.Point(405, 164);
            this.hastalikEkleGrpbox.Name = "hastalikEkleGrpbox";
            this.hastalikEkleGrpbox.Size = new System.Drawing.Size(270, 351);
            this.hastalikEkleGrpbox.TabIndex = 70;
            this.hastalikEkleGrpbox.TabStop = false;
            this.hastalikEkleGrpbox.Text = "Hastalık Ekle";
            this.hastalikEkleGrpbox.Visible = false;
            // 
            // HastalikEkle_btn
            // 
            this.HastalikEkle_btn.Location = new System.Drawing.Point(0, 320);
            this.HastalikEkle_btn.Name = "HastalikEkle_btn";
            this.HastalikEkle_btn.Size = new System.Drawing.Size(270, 31);
            this.HastalikEkle_btn.TabIndex = 2;
            this.HastalikEkle_btn.Text = "Hastalik ekle";
            this.HastalikEkle_btn.UseVisualStyleBackColor = true;
            this.HastalikEkle_btn.Click += new System.EventHandler(this.HastalikEkle_btn_Click);
            // 
            // hastaaciklama_txt
            // 
            this.hastaaciklama_txt.Location = new System.Drawing.Point(37, 192);
            this.hastaaciklama_txt.MaxLength = 244;
            this.hastaaciklama_txt.Multiline = true;
            this.hastaaciklama_txt.Name = "hastaaciklama_txt";
            this.hastaaciklama_txt.Size = new System.Drawing.Size(210, 78);
            this.hastaaciklama_txt.TabIndex = 1;
            // 
            // hastalikAdi_txt
            // 
            this.hastalikAdi_txt.Location = new System.Drawing.Point(80, 85);
            this.hastalikAdi_txt.Multiline = true;
            this.hastalikAdi_txt.Name = "hastalikAdi_txt";
            this.hastalikAdi_txt.Size = new System.Drawing.Size(128, 32);
            this.hastalikAdi_txt.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Hastalık Aciklamasi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hastalık Adı :";
            // 
            // diyetsec_label
            // 
            this.diyetsec_label.AutoSize = true;
            this.diyetsec_label.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.diyetsec_label.Location = new System.Drawing.Point(1096, 95);
            this.diyetsec_label.Name = "diyetsec_label";
            this.diyetsec_label.Size = new System.Drawing.Size(83, 19);
            this.diyetsec_label.TabIndex = 0;
            this.diyetsec_label.Text = "Diyet Sec :";
            // 
            // diyeteklegrpbox
            // 
            this.diyeteklegrpbox.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.diyeteklegrpbox.Controls.Add(this.DiyetEkle_btn);
            this.diyeteklegrpbox.Controls.Add(this.persenbe_txt);
            this.diyeteklegrpbox.Controls.Add(this.label8);
            this.diyeteklegrpbox.Controls.Add(this.label11);
            this.diyeteklegrpbox.Controls.Add(this.label10);
            this.diyeteklegrpbox.Controls.Add(this.diyetadı_txt);
            this.diyeteklegrpbox.Controls.Add(this.label12);
            this.diyeteklegrpbox.Controls.Add(this.label1);
            this.diyeteklegrpbox.Controls.Add(this.pazar_txt);
            this.diyeteklegrpbox.Controls.Add(this.cumartesi_txt);
            this.diyeteklegrpbox.Controls.Add(this.pazartesi_txt);
            this.diyeteklegrpbox.Controls.Add(this.label7);
            this.diyeteklegrpbox.Controls.Add(this.carsanba_txt);
            this.diyeteklegrpbox.Controls.Add(this.label9);
            this.diyeteklegrpbox.Controls.Add(this.label6);
            this.diyeteklegrpbox.Controls.Add(this.cuma_txt);
            this.diyeteklegrpbox.Controls.Add(this.sali_txt);
            this.diyeteklegrpbox.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.diyeteklegrpbox.Location = new System.Drawing.Point(990, 164);
            this.diyeteklegrpbox.Name = "diyeteklegrpbox";
            this.diyeteklegrpbox.Size = new System.Drawing.Size(270, 351);
            this.diyeteklegrpbox.TabIndex = 70;
            this.diyeteklegrpbox.TabStop = false;
            this.diyeteklegrpbox.Text = "Yeni Diyet Ekle";
            this.diyeteklegrpbox.Visible = false;
            // 
            // DiyetEkle_btn
            // 
            this.DiyetEkle_btn.Location = new System.Drawing.Point(0, 320);
            this.DiyetEkle_btn.Name = "DiyetEkle_btn";
            this.DiyetEkle_btn.Size = new System.Drawing.Size(270, 31);
            this.DiyetEkle_btn.TabIndex = 2;
            this.DiyetEkle_btn.Text = "Diyet Ekle";
            this.DiyetEkle_btn.UseVisualStyleBackColor = true;
            this.DiyetEkle_btn.Click += new System.EventHandler(this.DiyetEkle_btn_Click);
            // 
            // persenbe_txt
            // 
            this.persenbe_txt.Location = new System.Drawing.Point(104, 137);
            this.persenbe_txt.Multiline = true;
            this.persenbe_txt.Name = "persenbe_txt";
            this.persenbe_txt.Size = new System.Drawing.Size(128, 20);
            this.persenbe_txt.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.SeaGreen;
            this.label8.Location = new System.Drawing.Point(7, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Çarşamba :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.SeaGreen;
            this.label11.Location = new System.Drawing.Point(5, 207);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 19);
            this.label11.TabIndex = 0;
            this.label11.Text = "Cumartesi :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.SeaGreen;
            this.label10.Location = new System.Drawing.Point(34, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 19);
            this.label10.TabIndex = 0;
            this.label10.Text = "Cuma :";
            // 
            // diyetadı_txt
            // 
            this.diyetadı_txt.Location = new System.Drawing.Point(126, 279);
            this.diyetadı_txt.Multiline = true;
            this.diyetadı_txt.Name = "diyetadı_txt";
            this.diyetadı_txt.Size = new System.Drawing.Size(128, 20);
            this.diyetadı_txt.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.SeaGreen;
            this.label12.Location = new System.Drawing.Point(40, 236);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 19);
            this.label12.TabIndex = 0;
            this.label12.Text = "Pazar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(18, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Diyet Adı :";
            // 
            // pazar_txt
            // 
            this.pazar_txt.Location = new System.Drawing.Point(104, 236);
            this.pazar_txt.Multiline = true;
            this.pazar_txt.Name = "pazar_txt";
            this.pazar_txt.Size = new System.Drawing.Size(128, 20);
            this.pazar_txt.TabIndex = 1;
            // 
            // cumartesi_txt
            // 
            this.cumartesi_txt.Location = new System.Drawing.Point(104, 207);
            this.cumartesi_txt.Multiline = true;
            this.cumartesi_txt.Name = "cumartesi_txt";
            this.cumartesi_txt.Size = new System.Drawing.Size(128, 20);
            this.cumartesi_txt.TabIndex = 1;
            // 
            // pazartesi_txt
            // 
            this.pazartesi_txt.Location = new System.Drawing.Point(104, 28);
            this.pazartesi_txt.Multiline = true;
            this.pazartesi_txt.Name = "pazartesi_txt";
            this.pazartesi_txt.Size = new System.Drawing.Size(128, 20);
            this.pazartesi_txt.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.SeaGreen;
            this.label7.Location = new System.Drawing.Point(47, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Salı :";
            // 
            // carsanba_txt
            // 
            this.carsanba_txt.Location = new System.Drawing.Point(104, 98);
            this.carsanba_txt.Multiline = true;
            this.carsanba_txt.Name = "carsanba_txt";
            this.carsanba_txt.Size = new System.Drawing.Size(128, 20);
            this.carsanba_txt.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.SeaGreen;
            this.label9.Location = new System.Drawing.Point(11, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "Perşembe :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.SeaGreen;
            this.label6.Location = new System.Drawing.Point(13, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Pazartesi :";
            // 
            // cuma_txt
            // 
            this.cuma_txt.Location = new System.Drawing.Point(104, 172);
            this.cuma_txt.Multiline = true;
            this.cuma_txt.Name = "cuma_txt";
            this.cuma_txt.Size = new System.Drawing.Size(128, 20);
            this.cuma_txt.TabIndex = 1;
            // 
            // sali_txt
            // 
            this.sali_txt.Location = new System.Drawing.Point(104, 63);
            this.sali_txt.Multiline = true;
            this.sali_txt.Name = "sali_txt";
            this.sali_txt.Size = new System.Drawing.Size(128, 20);
            this.sali_txt.TabIndex = 1;
            // 
            // diyet_bilgisi
            // 
            this.diyet_bilgisi.AutoSize = true;
            this.diyet_bilgisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.diyet_bilgisi.Location = new System.Drawing.Point(931, 50);
            this.diyet_bilgisi.Name = "diyet_bilgisi";
            this.diyet_bilgisi.Size = new System.Drawing.Size(151, 25);
            this.diyet_bilgisi.TabIndex = 68;
            this.diyet_bilgisi.Text = "Diyet Bilgisi :";
            // 
            // tedavi_et_btn
            // 
            this.tedavi_et_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tedavi_et_btn.Location = new System.Drawing.Point(405, 582);
            this.tedavi_et_btn.Name = "tedavi_et_btn";
            this.tedavi_et_btn.Size = new System.Drawing.Size(270, 102);
            this.tedavi_et_btn.TabIndex = 71;
            this.tedavi_et_btn.Text = "Tedavi Et ";
            this.tedavi_et_btn.UseVisualStyleBackColor = true;
            this.tedavi_et_btn.Visible = false;
            this.tedavi_et_btn.Click += new System.EventHandler(this.Tedavi_et_btn_Click);
            // 
            // rapor_goruntule_btn
            // 
            this.rapor_goruntule_btn.Location = new System.Drawing.Point(1001, 583);
            this.rapor_goruntule_btn.Name = "rapor_goruntule_btn";
            this.rapor_goruntule_btn.Size = new System.Drawing.Size(270, 102);
            this.rapor_goruntule_btn.TabIndex = 72;
            this.rapor_goruntule_btn.Text = "Rapor Goruntule";
            this.rapor_goruntule_btn.UseVisualStyleBackColor = true;
            this.rapor_goruntule_btn.Visible = false;
            this.rapor_goruntule_btn.Click += new System.EventHandler(this.Rapor_goruntule_btn_Click);
            // 
            // HastaTedaviScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 716);
            this.Controls.Add(this.rapor_goruntule_btn);
            this.Controls.Add(this.tedavi_et_btn);
            this.Controls.Add(this.diyetsec_label);
            this.Controls.Add(this.DiyetTuruCombo_combo);
            this.Controls.Add(this.diyeteklegrpbox);
            this.Controls.Add(this.hastalikEkleGrpbox);
            this.Controls.Add(this.HastaSikayetleri_combo);
            this.Controls.Add(this.sikayetlistele_label);
            this.Controls.Add(this.diyet_bilgisi);
            this.Controls.Add(this.hasta_sikayeti);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.hasta_bilgileri_lbl);
            this.Controls.Add(this.back_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HastaTedaviScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HastaTedaviScreen";
            this.Load += new System.EventHandler(this.HastaTedaviScreen_Load);
            this.hastalikEkleGrpbox.ResumeLayout(false);
            this.hastalikEkleGrpbox.PerformLayout();
            this.diyeteklegrpbox.ResumeLayout(false);
            this.diyeteklegrpbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Label hasta_bilgileri_lbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label hasta_sikayeti;
        private System.Windows.Forms.ComboBox HastaSikayetleri_combo;
        private System.Windows.Forms.Label sikayetlistele_label;
        private System.Windows.Forms.ComboBox DiyetTuruCombo_combo;
        private System.Windows.Forms.GroupBox hastalikEkleGrpbox;
        private System.Windows.Forms.TextBox hastalikAdi_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label diyetsec_label;
        private System.Windows.Forms.TextBox diyetadı_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pazartesi_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cumartesi_txt;
        private System.Windows.Forms.TextBox carsanba_txt;
        private System.Windows.Forms.TextBox cuma_txt;
        private System.Windows.Forms.TextBox sali_txt;
        private System.Windows.Forms.TextBox persenbe_txt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox diyeteklegrpbox;
        private System.Windows.Forms.TextBox pazar_txt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox hastaaciklama_txt;
        private System.Windows.Forms.Button HastalikEkle_btn;
        private System.Windows.Forms.Button DiyetEkle_btn;
        private System.Windows.Forms.Label diyet_bilgisi;
        private System.Windows.Forms.Button tedavi_et_btn;
        private System.Windows.Forms.Button rapor_goruntule_btn;
    }
}