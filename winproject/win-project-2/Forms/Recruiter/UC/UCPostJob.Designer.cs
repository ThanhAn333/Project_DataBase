namespace win_project_2.Forms.Recruiter.UC
{
    partial class UCPostJob
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCPostJob));
            this.lbError_status = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.rbPaused = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.rbOpen = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.guna2HtmlLabel10 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel18 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.rbClosed = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.guna2HtmlLabel19 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_skill = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_salary = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_des = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_locaton = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_title = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnQuayLai = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_company = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel11 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dtPostday = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btn_Post = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel12 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel13 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbError = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.txt_Type = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnQuayLai)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbError_status
            // 
            this.lbError_status.AutoSize = false;
            this.lbError_status.BackColor = System.Drawing.Color.Transparent;
            this.lbError_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbError_status.ForeColor = System.Drawing.Color.Red;
            this.lbError_status.Location = new System.Drawing.Point(829, 481);
            this.lbError_status.Name = "lbError_status";
            this.lbError_status.Size = new System.Drawing.Size(181, 34);
            this.lbError_status.TabIndex = 210;
            this.lbError_status.Text = "Vui lòng chọn trạng thái";
            this.lbError_status.Visible = false;
            // 
            // rbPaused
            // 
            this.rbPaused.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbPaused.CheckedState.BorderThickness = 0;
            this.rbPaused.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbPaused.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbPaused.Location = new System.Drawing.Point(872, 445);
            this.rbPaused.Name = "rbPaused";
            this.rbPaused.Size = new System.Drawing.Size(22, 25);
            this.rbPaused.TabIndex = 208;
            this.rbPaused.Text = "guna2CustomRadioButton6";
            this.rbPaused.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbPaused.UncheckedState.BorderThickness = 2;
            this.rbPaused.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbPaused.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rbOpen
            // 
            this.rbOpen.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbOpen.CheckedState.BorderThickness = 0;
            this.rbOpen.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbOpen.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbOpen.Location = new System.Drawing.Point(872, 355);
            this.rbOpen.Name = "rbOpen";
            this.rbOpen.Size = new System.Drawing.Size(22, 25);
            this.rbOpen.TabIndex = 207;
            this.rbOpen.Text = "guna2CustomRadioButton7";
            this.rbOpen.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbOpen.UncheckedState.BorderThickness = 2;
            this.rbOpen.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbOpen.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // guna2HtmlLabel10
            // 
            this.guna2HtmlLabel10.AutoSize = false;
            this.guna2HtmlLabel10.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel10.Font = new System.Drawing.Font("Sylfaen", 12F);
            this.guna2HtmlLabel10.Location = new System.Drawing.Point(900, 445);
            this.guna2HtmlLabel10.Name = "guna2HtmlLabel10";
            this.guna2HtmlLabel10.Size = new System.Drawing.Size(96, 25);
            this.guna2HtmlLabel10.TabIndex = 206;
            this.guna2HtmlLabel10.Text = "Paused";
            // 
            // guna2HtmlLabel18
            // 
            this.guna2HtmlLabel18.AutoSize = false;
            this.guna2HtmlLabel18.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel18.Font = new System.Drawing.Font("Sylfaen", 12F);
            this.guna2HtmlLabel18.Location = new System.Drawing.Point(900, 400);
            this.guna2HtmlLabel18.Name = "guna2HtmlLabel18";
            this.guna2HtmlLabel18.Size = new System.Drawing.Size(96, 25);
            this.guna2HtmlLabel18.TabIndex = 205;
            this.guna2HtmlLabel18.Text = "Closed";
            // 
            // rbClosed
            // 
            this.rbClosed.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbClosed.CheckedState.BorderThickness = 0;
            this.rbClosed.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbClosed.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbClosed.Location = new System.Drawing.Point(872, 400);
            this.rbClosed.Name = "rbClosed";
            this.rbClosed.Size = new System.Drawing.Size(22, 25);
            this.rbClosed.TabIndex = 204;
            this.rbClosed.Text = "guna2CustomRadioButton2";
            this.rbClosed.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbClosed.UncheckedState.BorderThickness = 2;
            this.rbClosed.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbClosed.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // guna2HtmlLabel19
            // 
            this.guna2HtmlLabel19.AutoSize = false;
            this.guna2HtmlLabel19.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel19.Font = new System.Drawing.Font("Sylfaen", 12F);
            this.guna2HtmlLabel19.Location = new System.Drawing.Point(900, 355);
            this.guna2HtmlLabel19.Name = "guna2HtmlLabel19";
            this.guna2HtmlLabel19.Size = new System.Drawing.Size(88, 25);
            this.guna2HtmlLabel19.TabIndex = 203;
            this.guna2HtmlLabel19.Text = "Open";
            // 
            // txt_skill
            // 
            this.txt_skill.BorderRadius = 5;
            this.txt_skill.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_skill.DefaultText = "";
            this.txt_skill.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_skill.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_skill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_skill.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_skill.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_skill.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_skill.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_skill.Location = new System.Drawing.Point(873, 200);
            this.txt_skill.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_skill.Name = "txt_skill";
            this.txt_skill.PasswordChar = '\0';
            this.txt_skill.PlaceholderText = "";
            this.txt_skill.SelectedText = "";
            this.txt_skill.Size = new System.Drawing.Size(242, 40);
            this.txt_skill.TabIndex = 193;
            // 
            // txt_salary
            // 
            this.txt_salary.BorderRadius = 5;
            this.txt_salary.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_salary.DefaultText = "";
            this.txt_salary.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_salary.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_salary.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_salary.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_salary.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_salary.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_salary.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_salary.Location = new System.Drawing.Point(268, 278);
            this.txt_salary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_salary.Name = "txt_salary";
            this.txt_salary.PasswordChar = '\0';
            this.txt_salary.PlaceholderText = "";
            this.txt_salary.SelectedText = "";
            this.txt_salary.Size = new System.Drawing.Size(242, 40);
            this.txt_salary.TabIndex = 192;
            // 
            // txt_des
            // 
            this.txt_des.BorderRadius = 5;
            this.txt_des.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_des.DefaultText = "";
            this.txt_des.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_des.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_des.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_des.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_des.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_des.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_des.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_des.Location = new System.Drawing.Point(268, 621);
            this.txt_des.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_des.Name = "txt_des";
            this.txt_des.PasswordChar = '\0';
            this.txt_des.PlaceholderText = "";
            this.txt_des.SelectedText = "";
            this.txt_des.Size = new System.Drawing.Size(834, 150);
            this.txt_des.TabIndex = 191;
            // 
            // txt_locaton
            // 
            this.txt_locaton.BorderRadius = 5;
            this.txt_locaton.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_locaton.DefaultText = "";
            this.txt_locaton.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_locaton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_locaton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_locaton.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_locaton.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_locaton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_locaton.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_locaton.Location = new System.Drawing.Point(268, 200);
            this.txt_locaton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_locaton.Name = "txt_locaton";
            this.txt_locaton.PasswordChar = '\0';
            this.txt_locaton.PlaceholderText = "";
            this.txt_locaton.SelectedText = "";
            this.txt_locaton.Size = new System.Drawing.Size(242, 40);
            this.txt_locaton.TabIndex = 190;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.AutoSize = false;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(152, 353);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(83, 40);
            this.guna2HtmlLabel3.TabIndex = 188;
            this.guna2HtmlLabel3.Text = "Type :";
            // 
            // txt_title
            // 
            this.txt_title.BorderRadius = 5;
            this.txt_title.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_title.DefaultText = "";
            this.txt_title.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_title.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_title.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_title.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_title.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_title.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_title.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_title.Location = new System.Drawing.Point(268, 123);
            this.txt_title.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_title.Name = "txt_title";
            this.txt_title.PasswordChar = '\0';
            this.txt_title.PlaceholderText = "";
            this.txt_title.SelectedText = "";
            this.txt_title.Size = new System.Drawing.Size(242, 40);
            this.txt_title.TabIndex = 187;
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.BackColor = System.Drawing.Color.Transparent;
            this.btnQuayLai.FillColor = System.Drawing.Color.Transparent;
            this.btnQuayLai.Image = ((System.Drawing.Image)(resources.GetObject("btnQuayLai.Image")));
            this.btnQuayLai.ImageRotate = 0F;
            this.btnQuayLai.Location = new System.Drawing.Point(3, 12);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(59, 46);
            this.btnQuayLai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnQuayLai.TabIndex = 1;
            this.btnQuayLai.TabStop = false;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(404, 15);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(475, 61);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Đăng Công Việc";
            // 
            // txt_company
            // 
            this.txt_company.BorderRadius = 5;
            this.txt_company.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_company.DefaultText = "";
            this.txt_company.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_company.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_company.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_company.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_company.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_company.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_company.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_company.Location = new System.Drawing.Point(873, 123);
            this.txt_company.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_company.Name = "txt_company";
            this.txt_company.PasswordChar = '\0';
            this.txt_company.PlaceholderText = "";
            this.txt_company.SelectedText = "";
            this.txt_company.Size = new System.Drawing.Size(242, 40);
            this.txt_company.TabIndex = 189;
            // 
            // guna2HtmlLabel11
            // 
            this.guna2HtmlLabel11.AutoSize = false;
            this.guna2HtmlLabel11.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel11.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel11.Location = new System.Drawing.Point(715, 200);
            this.guna2HtmlLabel11.Name = "guna2HtmlLabel11";
            this.guna2HtmlLabel11.Size = new System.Drawing.Size(158, 40);
            this.guna2HtmlLabel11.TabIndex = 186;
            this.guna2HtmlLabel11.Text = "Skill Require :";
            // 
            // guna2HtmlLabel9
            // 
            this.guna2HtmlLabel9.AutoSize = false;
            this.guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel9.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel9.Location = new System.Drawing.Point(101, 611);
            this.guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            this.guna2HtmlLabel9.Size = new System.Drawing.Size(134, 40);
            this.guna2HtmlLabel9.TabIndex = 185;
            this.guna2HtmlLabel9.Text = "Description :";
            // 
            // dtPostday
            // 
            this.dtPostday.BorderRadius = 5;
            this.dtPostday.Checked = true;
            this.dtPostday.FillColor = System.Drawing.Color.Silver;
            this.dtPostday.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtPostday.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtPostday.Location = new System.Drawing.Point(873, 282);
            this.dtPostday.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtPostday.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtPostday.Name = "dtPostday";
            this.dtPostday.Size = new System.Drawing.Size(242, 36);
            this.dtPostday.TabIndex = 184;
            this.dtPostday.Value = new System.DateTime(2024, 10, 18, 22, 4, 54, 455);
            // 
            // btn_Post
            // 
            this.btn_Post.BorderRadius = 5;
            this.btn_Post.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Post.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Post.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Post.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Post.FillColor = System.Drawing.Color.Gray;
            this.btn_Post.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Post.ForeColor = System.Drawing.Color.White;
            this.btn_Post.Location = new System.Drawing.Point(504, 795);
            this.btn_Post.Name = "btn_Post";
            this.btn_Post.Size = new System.Drawing.Size(180, 45);
            this.btn_Post.TabIndex = 183;
            this.btn_Post.Text = "Post Job";
            this.btn_Post.Click += new System.EventHandler(this.btn_Post_Click);
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.AutoSize = false;
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(715, 353);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(94, 40);
            this.guna2HtmlLabel8.TabIndex = 182;
            this.guna2HtmlLabel8.Text = "Status :";
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.AutoSize = false;
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(715, 278);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(150, 40);
            this.guna2HtmlLabel7.TabIndex = 181;
            this.guna2HtmlLabel7.Text = "PostedDate :";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.AutoSize = false;
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(715, 123);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(127, 40);
            this.guna2HtmlLabel6.TabIndex = 180;
            this.guna2HtmlLabel6.Text = "Company :";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.AutoSize = false;
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(152, 278);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(83, 40);
            this.guna2HtmlLabel4.TabIndex = 178;
            this.guna2HtmlLabel4.Text = "Salary :";
            // 
            // guna2HtmlLabel12
            // 
            this.guna2HtmlLabel12.AutoSize = false;
            this.guna2HtmlLabel12.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel12.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel12.Location = new System.Drawing.Point(152, 200);
            this.guna2HtmlLabel12.Name = "guna2HtmlLabel12";
            this.guna2HtmlLabel12.Size = new System.Drawing.Size(110, 40);
            this.guna2HtmlLabel12.TabIndex = 177;
            this.guna2HtmlLabel12.Text = "Location :";
            // 
            // guna2HtmlLabel13
            // 
            this.guna2HtmlLabel13.AutoSize = false;
            this.guna2HtmlLabel13.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel13.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel13.Location = new System.Drawing.Point(152, 123);
            this.guna2HtmlLabel13.Name = "guna2HtmlLabel13";
            this.guna2HtmlLabel13.Size = new System.Drawing.Size(85, 40);
            this.guna2HtmlLabel13.TabIndex = 176;
            this.guna2HtmlLabel13.Text = "Title :";
            // 
            // lbError
            // 
            this.lbError.AutoSize = false;
            this.lbError.BackColor = System.Drawing.Color.Transparent;
            this.lbError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbError.ForeColor = System.Drawing.Color.Red;
            this.lbError.Location = new System.Drawing.Point(481, 82);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(334, 34);
            this.lbError.TabIndex = 175;
            this.lbError.Text = "Vui lòng nhập đầy đủ thông tin !";
            this.lbError.Visible = false;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btnQuayLai);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.Black;
            this.guna2Panel1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1403, 76);
            this.guna2Panel1.TabIndex = 174;
            // 
            // txt_Type
            // 
            this.txt_Type.BackColor = System.Drawing.Color.Transparent;
            this.txt_Type.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txt_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_Type.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Type.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Type.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_Type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txt_Type.ItemHeight = 30;
            this.txt_Type.Items.AddRange(new object[] {
            "Full-time",
            "Part-time",
            "Contract",
            "Internship",
            "Freelance"});
            this.txt_Type.Location = new System.Drawing.Point(268, 353);
            this.txt_Type.Name = "txt_Type";
            this.txt_Type.Size = new System.Drawing.Size(242, 36);
            this.txt_Type.TabIndex = 211;
            // 
            // UCPostJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_Type);
            this.Controls.Add(this.lbError_status);
            this.Controls.Add(this.rbPaused);
            this.Controls.Add(this.rbOpen);
            this.Controls.Add(this.guna2HtmlLabel10);
            this.Controls.Add(this.guna2HtmlLabel18);
            this.Controls.Add(this.rbClosed);
            this.Controls.Add(this.guna2HtmlLabel19);
            this.Controls.Add(this.txt_skill);
            this.Controls.Add(this.txt_salary);
            this.Controls.Add(this.txt_des);
            this.Controls.Add(this.txt_locaton);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.txt_title);
            this.Controls.Add(this.txt_company);
            this.Controls.Add(this.guna2HtmlLabel11);
            this.Controls.Add(this.guna2HtmlLabel9);
            this.Controls.Add(this.dtPostday);
            this.Controls.Add(this.btn_Post);
            this.Controls.Add(this.guna2HtmlLabel8);
            this.Controls.Add(this.guna2HtmlLabel7);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.guna2HtmlLabel12);
            this.Controls.Add(this.guna2HtmlLabel13);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "UCPostJob";
            this.Size = new System.Drawing.Size(1403, 878);
            ((System.ComponentModel.ISupportInitialize)(this.btnQuayLai)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lbError_status;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rbPaused;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rbOpen;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel10;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel18;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rbClosed;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel19;
        private Guna.UI2.WinForms.Guna2TextBox txt_skill;
        private Guna.UI2.WinForms.Guna2TextBox txt_salary;
        private Guna.UI2.WinForms.Guna2TextBox txt_des;
        private Guna.UI2.WinForms.Guna2TextBox txt_locaton;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2TextBox txt_title;
        private Guna.UI2.WinForms.Guna2PictureBox btnQuayLai;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txt_company;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel11;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtPostday;
        private Guna.UI2.WinForms.Guna2Button btn_Post;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel12;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel13;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbError;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ComboBox txt_Type;
    }
}
