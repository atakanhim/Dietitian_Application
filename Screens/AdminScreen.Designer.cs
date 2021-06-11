
namespace diyetisyenproje
{
    partial class AdminScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminScreen));
            this.diyetisyenEkle = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.D_listele_datagridview = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.D_listele_datagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // diyetisyenEkle
            // 
            this.diyetisyenEkle.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diyetisyenEkle.Location = new System.Drawing.Point(535, 42);
            this.diyetisyenEkle.Name = "diyetisyenEkle";
            this.diyetisyenEkle.Size = new System.Drawing.Size(201, 63);
            this.diyetisyenEkle.TabIndex = 0;
            this.diyetisyenEkle.Text = "Yeni Diyetisyen Ekle";
            this.diyetisyenEkle.UseVisualStyleBackColor = true;
            this.diyetisyenEkle.Click += new System.EventHandler(this.DiyetisyenEkle_Click);
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
            this.back_btn.Location = new System.Drawing.Point(762, 12);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(44, 37);
            this.back_btn.TabIndex = 60;
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
            this.exit_btn.Location = new System.Drawing.Point(812, 12);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(44, 37);
            this.exit_btn.TabIndex = 61;
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // D_listele_datagridview
            // 
            this.D_listele_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.D_listele_datagridview.ColumnHeadersVisible = false;
            this.D_listele_datagridview.Location = new System.Drawing.Point(12, 123);
            this.D_listele_datagridview.Name = "D_listele_datagridview";
            this.D_listele_datagridview.ReadOnly = true;
            this.D_listele_datagridview.Size = new System.Drawing.Size(844, 315);
            this.D_listele_datagridview.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(160, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 32);
            this.label1.TabIndex = 64;
            this.label1.Text = "DİYETİSYENLER";
            // 
            // AdminScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(865, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.D_listele_datagridview);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.diyetisyenEkle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminScreen";
            this.Load += new System.EventHandler(this.AdminScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.D_listele_datagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button diyetisyenEkle;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.DataGridView D_listele_datagridview;
        private System.Windows.Forms.Label label1;
    }
}