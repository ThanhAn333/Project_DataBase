namespace win_project_2.Forms
{
    partial class FRating
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_cmt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2RatingStar1 = new Guna.UI2.WinForms.Guna2RatingStar();
            this.btn_up = new Guna.UI2.WinForms.Guna2Button();
            this.btn_upImg = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1822, 100);
            this.guna2Panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(763, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đánh giá";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(34, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ý kiến đánh giá:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txb_cmt
            // 
            this.txb_cmt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_cmt.DefaultText = "";
            this.txb_cmt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_cmt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_cmt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_cmt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_cmt.FillColor = System.Drawing.SystemColors.Control;
            this.txb_cmt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_cmt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txb_cmt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_cmt.Location = new System.Drawing.Point(68, 181);
            this.txb_cmt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_cmt.Name = "txb_cmt";
            this.txb_cmt.PasswordChar = '\0';
            this.txb_cmt.PlaceholderText = "";
            this.txb_cmt.SelectedText = "";
            this.txb_cmt.Size = new System.Drawing.Size(1703, 122);
            this.txb_cmt.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(64, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hình ảnh:";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.DarkGray;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(68, 348);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(335, 134);
            this.guna2PictureBox1.TabIndex = 7;
            this.guna2PictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(65, 545);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 28);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mức độ hài lòng:";
            // 
            // guna2RatingStar1
            // 
            this.guna2RatingStar1.Location = new System.Drawing.Point(68, 575);
            this.guna2RatingStar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2RatingStar1.Name = "guna2RatingStar1";
            this.guna2RatingStar1.Size = new System.Drawing.Size(153, 41);
            this.guna2RatingStar1.TabIndex = 9;
            this.guna2RatingStar1.ValueChanged += new System.EventHandler(this.guna2RatingStar1_ValueChanged);
            // 
            // btn_up
            // 
            this.btn_up.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_up.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_up.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_up.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_up.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_up.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_up.ForeColor = System.Drawing.Color.White;
            this.btn_up.Location = new System.Drawing.Point(888, 707);
            this.btn_up.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(125, 45);
            this.btn_up.TabIndex = 10;
            this.btn_up.Text = "Gửi";
            this.btn_up.Click += new System.EventHandler(this.btn_up_Click);
            // 
            // btn_upImg
            // 
            this.btn_upImg.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_upImg.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_upImg.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_upImg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_upImg.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_upImg.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_upImg.ForeColor = System.Drawing.Color.White;
            this.btn_upImg.Location = new System.Drawing.Point(137, 488);
            this.btn_upImg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_upImg.Name = "btn_upImg";
            this.btn_upImg.Size = new System.Drawing.Size(180, 36);
            this.btn_upImg.TabIndex = 11;
            this.btn_upImg.Text = "Tải ảnh";
            this.btn_upImg.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // FRating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1822, 774);
            this.Controls.Add(this.btn_upImg);
            this.Controls.Add(this.btn_up);
            this.Controls.Add(this.guna2RatingStar1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txb_cmt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.guna2Panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FRating";
            this.Text = "FRating";
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txb_cmt;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2RatingStar guna2RatingStar1;
        private Guna.UI2.WinForms.Guna2Button btn_up;
        private Guna.UI2.WinForms.Guna2Button btn_upImg;
    }
}