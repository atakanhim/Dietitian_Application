
namespace diyetisyenproje
{
    partial class girisekrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(girisekrani));
            this.admin_btn = new System.Windows.Forms.Button();
            this.doctor_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // admin_btn
            // 
            this.admin_btn.Location = new System.Drawing.Point(91, 100);
            this.admin_btn.Name = "admin_btn";
            this.admin_btn.Size = new System.Drawing.Size(272, 131);
            this.admin_btn.TabIndex = 0;
            this.admin_btn.Text = "Admin Giris";
            this.admin_btn.UseVisualStyleBackColor = true;
            this.admin_btn.Click += new System.EventHandler(this.admin_btn_Click);
            // 
            // doctor_btn
            // 
            this.doctor_btn.Location = new System.Drawing.Point(423, 100);
            this.doctor_btn.Name = "doctor_btn";
            this.doctor_btn.Size = new System.Drawing.Size(272, 131);
            this.doctor_btn.TabIndex = 0;
            this.doctor_btn.Text = "Diyetisyen Giris";
            this.doctor_btn.UseVisualStyleBackColor = true;
            this.doctor_btn.Click += new System.EventHandler(this.doctor_btn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(698, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 71);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // girisekrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.doctor_btn);
            this.Controls.Add(this.admin_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "girisekrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button admin_btn;
        private System.Windows.Forms.Button doctor_btn;
        private System.Windows.Forms.Button button1;
    }
}

