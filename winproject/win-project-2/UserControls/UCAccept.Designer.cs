namespace win_project_2.UserControls
{
    partial class UCAccept
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_name = new System.Windows.Forms.Label();
            this.guna2Shapes1 = new Guna.UI2.WinForms.Guna2Shapes();
            this.btn_accept = new Guna.UI2.WinForms.Guna2Button();
            this.btn_infor = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.BackColor = System.Drawing.Color.White;
            this.lb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lb_name.Location = new System.Drawing.Point(60, 82);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(146, 25);
            this.lb_name.TabIndex = 2;
            this.lb_name.Text = "ĐƠN XIN VIỆC";
            // 
            // guna2Shapes1
            // 
            this.guna2Shapes1.BorderColor = System.Drawing.Color.White;
            this.guna2Shapes1.FillColor = System.Drawing.Color.White;
            this.guna2Shapes1.Location = new System.Drawing.Point(-55, 22);
            this.guna2Shapes1.Name = "guna2Shapes1";
            this.guna2Shapes1.PolygonSkip = 1;
            this.guna2Shapes1.Rotate = 0F;
            this.guna2Shapes1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rounded;
            this.guna2Shapes1.Size = new System.Drawing.Size(671, 141);
            this.guna2Shapes1.TabIndex = 3;
            this.guna2Shapes1.Text = "guna2Shapes1";
            this.guna2Shapes1.Zoom = 80;
            // 
            // btn_accept
            // 
            this.btn_accept.Animated = true;
            this.btn_accept.BackColor = System.Drawing.Color.Transparent;
            this.btn_accept.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btn_accept.BorderRadius = 10;
            this.btn_accept.BorderThickness = 1;
            this.btn_accept.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_accept.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_accept.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_accept.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_accept.FillColor = System.Drawing.Color.Transparent;
            this.btn_accept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_accept.ForeColor = System.Drawing.Color.Gray;
            this.btn_accept.Location = new System.Drawing.Point(570, 72);
            this.btn_accept.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_accept.Name = "btn_accept";
            this.btn_accept.Size = new System.Drawing.Size(181, 49);
            this.btn_accept.TabIndex = 50;
            this.btn_accept.Text = "Chấp nhận";
            this.btn_accept.UseTransparentBackground = true;
            this.btn_accept.Click += new System.EventHandler(this.btn_accept_Click_1);
            // 
            // btn_infor
            // 
            this.btn_infor.Animated = true;
            this.btn_infor.BackColor = System.Drawing.Color.Transparent;
            this.btn_infor.BorderColor = System.Drawing.Color.Transparent;
            this.btn_infor.BorderRadius = 10;
            this.btn_infor.BorderThickness = 2;
            this.btn_infor.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_infor.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_infor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_infor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_infor.FillColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_infor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_infor.ForeColor = System.Drawing.Color.White;
            this.btn_infor.Location = new System.Drawing.Point(284, 64);
            this.btn_infor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_infor.Name = "btn_infor";
            this.btn_infor.Size = new System.Drawing.Size(210, 57);
            this.btn_infor.TabIndex = 49;
            this.btn_infor.Text = "Xem thông tin";
            this.btn_infor.UseTransparentBackground = true;
            this.btn_infor.Click += new System.EventHandler(this.btn_infor_Click);
            // 
            // UCAccept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btn_accept);
            this.Controls.Add(this.btn_infor);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.guna2Shapes1);
            this.Name = "UCAccept";
            this.Size = new System.Drawing.Size(771, 194);
            this.Load += new System.EventHandler(this.UCAccept_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_name;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes1;
        private Guna.UI2.WinForms.Guna2Button btn_accept;
        private Guna.UI2.WinForms.Guna2Button btn_infor;
    }
}
