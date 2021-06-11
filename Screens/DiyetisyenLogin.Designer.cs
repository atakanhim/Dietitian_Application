
namespace diyetisyenproje
{
    partial class DiyetisyenLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiyetisyenLogin));
            this.login_btn = new System.Windows.Forms.Button();
            this.passwordlabel = new System.Windows.Forms.Label();
            this.tclabel = new System.Windows.Forms.Label();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.tc_txt = new System.Windows.Forms.TextBox();
            this.resim1_picture = new System.Windows.Forms.PictureBox();
            this.back_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.resim1_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // login_btn
            // 
            this.login_btn.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.login_btn.Location = new System.Drawing.Point(113, 84);
            this.login_btn.Margin = new System.Windows.Forms.Padding(2);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(165, 41);
            this.login_btn.TabIndex = 12;
            this.login_btn.Text = "Giriş";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // passwordlabel
            // 
            this.passwordlabel.AutoSize = true;
            this.passwordlabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordlabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordlabel.Location = new System.Drawing.Point(36, 49);
            this.passwordlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(59, 22);
            this.passwordlabel.TabIndex = 11;
            this.passwordlabel.Text = "Şifre :";
            // 
            // tclabel
            // 
            this.tclabel.AutoSize = true;
            this.tclabel.BackColor = System.Drawing.Color.Transparent;
            this.tclabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tclabel.Location = new System.Drawing.Point(34, 19);
            this.tclabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tclabel.Name = "tclabel";
            this.tclabel.Size = new System.Drawing.Size(61, 22);
            this.tclabel.TabIndex = 10;
            this.tclabel.Text = "Tc No:";
            // 
            // password_txt
            // 
            this.password_txt.Location = new System.Drawing.Point(113, 51);
            this.password_txt.Margin = new System.Windows.Forms.Padding(2);
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(165, 20);
            this.password_txt.TabIndex = 9;
            // 
            // tc_txt
            // 
            this.tc_txt.Location = new System.Drawing.Point(113, 19);
            this.tc_txt.Margin = new System.Windows.Forms.Padding(2);
            this.tc_txt.MaxLength = 11;
            this.tc_txt.Name = "tc_txt";
            this.tc_txt.Size = new System.Drawing.Size(165, 20);
            this.tc_txt.TabIndex = 8;
            // 
            // resim1_picture
            // 
            this.resim1_picture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resim1_picture.BackgroundImage")));
            this.resim1_picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.resim1_picture.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.resim1_picture.Location = new System.Drawing.Point(0, 149);
            this.resim1_picture.Margin = new System.Windows.Forms.Padding(2);
            this.resim1_picture.Name = "resim1_picture";
            this.resim1_picture.Size = new System.Drawing.Size(398, 222);
            this.resim1_picture.TabIndex = 7;
            this.resim1_picture.TabStop = false;
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
            this.back_btn.Location = new System.Drawing.Point(292, 20);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(44, 37);
            this.back_btn.TabIndex = 14;
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.Back_btn_Click);
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
            this.exit_btn.Location = new System.Drawing.Point(342, 20);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(44, 37);
            this.exit_btn.TabIndex = 20;
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // DiyetisyenLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(398, 371);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.passwordlabel);
            this.Controls.Add(this.tclabel);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.tc_txt);
            this.Controls.Add(this.resim1_picture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DiyetisyenLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            ((System.ComponentModel.ISupportInitialize)(this.resim1_picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Label passwordlabel;
        private System.Windows.Forms.Label tclabel;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.TextBox tc_txt;
        private System.Windows.Forms.PictureBox resim1_picture;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button exit_btn;
    }
}