namespace win_project_2.Forms
{
    partial class FHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FHome));
            this.pt_Chat = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pt_TimTho = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pt_TimViec = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Shapes1 = new Guna.UI2.WinForms.Guna2Shapes();
            this.guna2Shapes2 = new Guna.UI2.WinForms.Guna2Shapes();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_TimViec = new System.Windows.Forms.Label();
            this.lb_XinChao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pt_Chat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt_TimTho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt_TimViec)).BeginInit();
            this.SuspendLayout();
            // 
            // pt_Chat
            // 
            this.pt_Chat.BackColor = System.Drawing.Color.Transparent;
            this.pt_Chat.BorderRadius = 20;
            this.pt_Chat.Image = ((System.Drawing.Image)(resources.GetObject("pt_Chat.Image")));
            this.pt_Chat.ImageRotate = 0F;
            this.pt_Chat.Location = new System.Drawing.Point(1151, 185);
            this.pt_Chat.Name = "pt_Chat";
            this.pt_Chat.Size = new System.Drawing.Size(375, 358);
            this.pt_Chat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pt_Chat.TabIndex = 55;
            this.pt_Chat.TabStop = false;
            this.pt_Chat.UseTransparentBackground = true;
            this.pt_Chat.Click += new System.EventHandler(this.pt_Chat_Click_1);
            // 
            // pt_TimTho
            // 
            this.pt_TimTho.BackColor = System.Drawing.Color.Transparent;
            this.pt_TimTho.BorderRadius = 20;
            this.pt_TimTho.Image = ((System.Drawing.Image)(resources.GetObject("pt_TimTho.Image")));
            this.pt_TimTho.ImageRotate = 0F;
            this.pt_TimTho.Location = new System.Drawing.Point(659, 185);
            this.pt_TimTho.Name = "pt_TimTho";
            this.pt_TimTho.Size = new System.Drawing.Size(375, 358);
            this.pt_TimTho.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pt_TimTho.TabIndex = 54;
            this.pt_TimTho.TabStop = false;
            this.pt_TimTho.UseTransparentBackground = true;
            this.pt_TimTho.Click += new System.EventHandler(this.pt_TimTho_Click_1);
            // 
            // pt_TimViec
            // 
            this.pt_TimViec.BorderRadius = 20;
            this.pt_TimViec.Image = ((System.Drawing.Image)(resources.GetObject("pt_TimViec.Image")));
            this.pt_TimViec.ImageRotate = 0F;
            this.pt_TimViec.Location = new System.Drawing.Point(191, 185);
            this.pt_TimViec.Name = "pt_TimViec";
            this.pt_TimViec.Size = new System.Drawing.Size(357, 358);
            this.pt_TimViec.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pt_TimViec.TabIndex = 53;
            this.pt_TimViec.TabStop = false;
            this.pt_TimViec.Click += new System.EventHandler(this.pt_TimViec_Click_1);
            // 
            // guna2Shapes1
            // 
            this.guna2Shapes1.BorderColor = System.Drawing.Color.Silver;
            this.guna2Shapes1.BorderThickness = 1;
            this.guna2Shapes1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2Shapes1.LineThickness = 1;
            this.guna2Shapes1.Location = new System.Drawing.Point(-54, 685);
            this.guna2Shapes1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Shapes1.Name = "guna2Shapes1";
            this.guna2Shapes1.PolygonSkip = 1;
            this.guna2Shapes1.Rotate = 0F;
            this.guna2Shapes1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Line;
            this.guna2Shapes1.Size = new System.Drawing.Size(1752, 34);
            this.guna2Shapes1.TabIndex = 51;
            this.guna2Shapes1.Text = "guna2Shapes1";
            this.guna2Shapes1.Zoom = 80;
            // 
            // guna2Shapes2
            // 
            this.guna2Shapes2.BorderColor = System.Drawing.Color.Silver;
            this.guna2Shapes2.BorderThickness = 1;
            this.guna2Shapes2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2Shapes2.LineThickness = 1;
            this.guna2Shapes2.Location = new System.Drawing.Point(-116, 67);
            this.guna2Shapes2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Shapes2.Name = "guna2Shapes2";
            this.guna2Shapes2.PolygonSkip = 1;
            this.guna2Shapes2.Rotate = 0F;
            this.guna2Shapes2.Shape = Guna.UI2.WinForms.Enums.ShapeType.Line;
            this.guna2Shapes2.Size = new System.Drawing.Size(1752, 34);
            this.guna2Shapes2.TabIndex = 52;
            this.guna2Shapes2.Text = "guna2Shapes1";
            this.guna2Shapes2.Zoom = 80;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(1281, 578);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 32);
            this.label2.TabIndex = 49;
            this.label2.Text = "Đăng bài";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(799, 578);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 32);
            this.label1.TabIndex = 47;
            this.label1.Text = "Tìm thợ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(42, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(373, 32);
            this.label5.TabIndex = 44;
            this.label5.Text = "Hôm nay bạn muốn làm gì ";
            // 
            // lb_TimViec
            // 
            this.lb_TimViec.AutoSize = true;
            this.lb_TimViec.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TimViec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lb_TimViec.Location = new System.Drawing.Point(305, 578);
            this.lb_TimViec.Name = "lb_TimViec";
            this.lb_TimViec.Size = new System.Drawing.Size(127, 32);
            this.lb_TimViec.TabIndex = 43;
            this.lb_TimViec.Text = "Tìm việc";
            // 
            // lb_XinChao
            // 
            this.lb_XinChao.AutoSize = true;
            this.lb_XinChao.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_XinChao.Location = new System.Drawing.Point(42, 30);
            this.lb_XinChao.Name = "lb_XinChao";
            this.lb_XinChao.Size = new System.Drawing.Size(125, 32);
            this.lb_XinChao.TabIndex = 48;
            this.lb_XinChao.Text = "Xin chào";
            // 
            // FHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.pt_Chat);
            this.Controls.Add(this.pt_TimTho);
            this.Controls.Add(this.pt_TimViec);
            this.Controls.Add(this.guna2Shapes1);
            this.Controls.Add(this.guna2Shapes2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lb_TimViec);
            this.Controls.Add(this.lb_XinChao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FHome";
            this.Text = "FHome";
            ((System.ComponentModel.ISupportInitialize)(this.pt_Chat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt_TimTho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt_TimViec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private Guna.UI2.WinForms.Guna2PictureBox pt_Chat;
        private Guna.UI2.WinForms.Guna2PictureBox pt_TimTho;
        private Guna.UI2.WinForms.Guna2PictureBox pt_TimViec;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes1;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_TimViec;
        private System.Windows.Forms.Label lb_XinChao;

        #endregion
        //private UCNhanvien ucNhanvien2;
        //private UCNhanvien ucNhanvien1;
    }
}