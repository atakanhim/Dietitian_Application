
namespace diyetisyenproje.Screens
{
    partial class ShowRapor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowRapor));
            this.raporhazirla_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.birinciBolum_combo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.birinciBolum_label = new System.Windows.Forms.Label();
            this.ikinciBolum_label = new System.Windows.Forms.Label();
            this.ikinciBolumKarar_label = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // raporhazirla_label
            // 
            this.raporhazirla_label.AutoSize = true;
            this.raporhazirla_label.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.raporhazirla_label.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.raporhazirla_label.Location = new System.Drawing.Point(71, 9);
            this.raporhazirla_label.Name = "raporhazirla_label";
            this.raporhazirla_label.Size = new System.Drawing.Size(179, 31);
            this.raporhazirla_label.TabIndex = 0;
            this.raporhazirla_label.Text = "Rapor Hazırla";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(18, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "1. Bolum :";
            // 
            // birinciBolum_combo
            // 
            this.birinciBolum_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.birinciBolum_combo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.birinciBolum_combo.FormattingEnabled = true;
            this.birinciBolum_combo.Location = new System.Drawing.Point(126, 48);
            this.birinciBolum_combo.Name = "birinciBolum_combo";
            this.birinciBolum_combo.Size = new System.Drawing.Size(180, 23);
            this.birinciBolum_combo.TabIndex = 2;
            this.birinciBolum_combo.SelectedIndexChanged += new System.EventHandler(this.BirinciBolum_combo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(15, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "2. Bolum :";
            // 
            // birinciBolum_label
            // 
            this.birinciBolum_label.AutoSize = true;
            this.birinciBolum_label.ForeColor = System.Drawing.Color.DarkCyan;
            this.birinciBolum_label.Location = new System.Drawing.Point(19, 88);
            this.birinciBolum_label.Name = "birinciBolum_label";
            this.birinciBolum_label.Size = new System.Drawing.Size(45, 13);
            this.birinciBolum_label.TabIndex = 3;
            this.birinciBolum_label.Text = "1.Bolum";
            this.birinciBolum_label.Visible = false;
            // 
            // ikinciBolum_label
            // 
            this.ikinciBolum_label.AutoSize = true;
            this.ikinciBolum_label.ForeColor = System.Drawing.Color.Purple;
            this.ikinciBolum_label.Location = new System.Drawing.Point(16, 399);
            this.ikinciBolum_label.Name = "ikinciBolum_label";
            this.ikinciBolum_label.Size = new System.Drawing.Size(44, 13);
            this.ikinciBolum_label.TabIndex = 3;
            this.ikinciBolum_label.Text = "2.bolum";
            this.ikinciBolum_label.Visible = false;
            // 
            // ikinciBolumKarar_label
            // 
            this.ikinciBolumKarar_label.AutoSize = true;
            this.ikinciBolumKarar_label.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ikinciBolumKarar_label.Location = new System.Drawing.Point(123, 366);
            this.ikinciBolumKarar_label.Name = "ikinciBolumKarar_label";
            this.ikinciBolumKarar_label.Size = new System.Drawing.Size(88, 15);
            this.ikinciBolumKarar_label.TabIndex = 3;
            this.ikinciBolumKarar_label.Text = "2.Bolum karar";
            this.ikinciBolumKarar_label.Visible = false;
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
            this.back_btn.Location = new System.Drawing.Point(603, 12);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(44, 37);
            this.back_btn.TabIndex = 64;
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(77, 695);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 39);
            this.button1.TabIndex = 67;
            this.button1.Text = "Dönüştür";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(332, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 37);
            this.button2.TabIndex = 68;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // ShowRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 755);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.ikinciBolumKarar_label);
            this.Controls.Add(this.ikinciBolum_label);
            this.Controls.Add(this.birinciBolum_label);
            this.Controls.Add(this.birinciBolum_combo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.raporhazirla_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowRapor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowRapor";
            this.Load += new System.EventHandler(this.ShowRapor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label raporhazirla_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox birinciBolum_combo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label birinciBolum_label;
        private System.Windows.Forms.Label ikinciBolum_label;
        private System.Windows.Forms.Label ikinciBolumKarar_label;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}