namespace win_project_2.Forms.Recruiter
{
    partial class FormInfoCandidate
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Level = new System.Windows.Forms.ComboBox();
            this.dgreview = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txb_skill_descript = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtBirthday = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2Shapes7 = new Guna.UI2.WinForms.Guna2Shapes();
            this.label12 = new System.Windows.Forms.Label();
            this.txb_skill_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.guna2RatingStar1 = new Guna.UI2.WinForms.Guna2RatingStar();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.guna2Shapes2 = new Guna.UI2.WinForms.Guna2Shapes();
            this.guna2Shapes1 = new Guna.UI2.WinForms.Guna2Shapes();
            this.txb_Email = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txb_SDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_FavTho = new System.Windows.Forms.Label();
            this.lb_DoneJob = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_Name = new Guna.UI2.WinForms.Guna2TextBox();
            this.avatar_box = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2Shapes3 = new Guna.UI2.WinForms.Guna2Shapes();
            this.guna2Shapes5 = new Guna.UI2.WinForms.Guna2Shapes();
            this.guna2Shapes4 = new Guna.UI2.WinForms.Guna2Shapes();
            this.guna2ShapesTool2 = new Guna.UI2.WinForms.Guna2ShapesTool(this.components);
            this.lb_YourName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2ShapesTool1 = new Guna.UI2.WinForms.Guna2ShapesTool(this.components);
            this.lb_Profie = new System.Windows.Forms.Label();
            this.guna2Shapes6 = new Guna.UI2.WinForms.Guna2Shapes();
            this.btnaccept = new Guna.UI2.WinForms.Guna2Button();
            this.btnRecject = new Guna.UI2.WinForms.Guna2Button();
            this.txtaddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbltrangthai = new System.Windows.Forms.Label();
            this.ReviewID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReviewDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatar_box)).BeginInit();
            this.SuspendLayout();
            // 
            // Level
            // 
            this.Level.FormattingEnabled = true;
            this.Level.Items.AddRange(new object[] {
            "Beginner",
            "Advanced",
            "Expert"});
            this.Level.Location = new System.Drawing.Point(1090, 310);
            this.Level.Name = "Level";
            this.Level.Size = new System.Drawing.Size(407, 24);
            this.Level.TabIndex = 70;
            // 
            // dgreview
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgreview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgreview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgreview.ColumnHeadersHeight = 4;
            this.dgreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgreview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReviewID,
            this.Name,
            this.Rating,
            this.Comment,
            this.ReviewDate});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgreview.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgreview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgreview.Location = new System.Drawing.Point(507, 611);
            this.dgreview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgreview.Name = "dgreview";
            this.dgreview.RowHeadersVisible = false;
            this.dgreview.RowHeadersWidth = 51;
            this.dgreview.RowTemplate.Height = 24;
            this.dgreview.Size = new System.Drawing.Size(1008, 234);
            this.dgreview.TabIndex = 68;
            this.dgreview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgreview.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgreview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgreview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgreview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgreview.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgreview.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgreview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgreview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgreview.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgreview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgreview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgreview.ThemeStyle.HeaderStyle.Height = 4;
            this.dgreview.ThemeStyle.ReadOnly = false;
            this.dgreview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgreview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgreview.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgreview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgreview.ThemeStyle.RowsStyle.Height = 24;
            this.dgreview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgreview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // txb_skill_descript
            // 
            this.txb_skill_descript.Animated = true;
            this.txb_skill_descript.BorderColor = System.Drawing.Color.Gainsboro;
            this.txb_skill_descript.BorderRadius = 6;
            this.txb_skill_descript.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_skill_descript.DefaultText = "";
            this.txb_skill_descript.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_skill_descript.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_skill_descript.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_skill_descript.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_skill_descript.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_skill_descript.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txb_skill_descript.ForeColor = System.Drawing.Color.DimGray;
            this.txb_skill_descript.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_skill_descript.Location = new System.Drawing.Point(1088, 373);
            this.txb_skill_descript.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txb_skill_descript.Name = "txb_skill_descript";
            this.txb_skill_descript.PasswordChar = '\0';
            this.txb_skill_descript.PlaceholderText = "Mô tả kĩ năng";
            this.txb_skill_descript.SelectedText = "";
            this.txb_skill_descript.Size = new System.Drawing.Size(418, 200);
            this.txb_skill_descript.TabIndex = 67;
            // 
            // dtBirthday
            // 
            this.dtBirthday.BorderRadius = 5;
            this.dtBirthday.Checked = true;
            this.dtBirthday.FillColor = System.Drawing.Color.Silver;
            this.dtBirthday.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtBirthday.Location = new System.Drawing.Point(496, 242);
            this.dtBirthday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtBirthday.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtBirthday.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtBirthday.Name = "dtBirthday";
            this.dtBirthday.Size = new System.Drawing.Size(456, 36);
            this.dtBirthday.TabIndex = 66;
            this.dtBirthday.Value = new System.DateTime(2024, 10, 18, 22, 4, 54, 455);
            // 
            // guna2Shapes7
            // 
            this.guna2Shapes7.BorderColor = System.Drawing.SystemColors.Highlight;
            this.guna2Shapes7.BorderThickness = 3;
            this.guna2Shapes7.FillColor = System.Drawing.SystemColors.Highlight;
            this.guna2Shapes7.LineThickness = 3;
            this.guna2Shapes7.Location = new System.Drawing.Point(29, 50);
            this.guna2Shapes7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Shapes7.Name = "guna2Shapes7";
            this.guna2Shapes7.PolygonSkip = 1;
            this.guna2Shapes7.Rotate = 0F;
            this.guna2Shapes7.Shape = Guna.UI2.WinForms.Enums.ShapeType.Line;
            this.guna2Shapes7.Size = new System.Drawing.Size(82, 30);
            this.guna2Shapes7.TabIndex = 64;
            this.guna2Shapes7.Text = "guna2Shapes1";
            this.guna2Shapes7.Zoom = 80;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label12.Location = new System.Drawing.Point(31, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 22);
            this.label12.TabIndex = 61;
            this.label12.Text = "Profile";
            // 
            // txb_skill_name
            // 
            this.txb_skill_name.Animated = true;
            this.txb_skill_name.BorderColor = System.Drawing.Color.Gainsboro;
            this.txb_skill_name.BorderRadius = 6;
            this.txb_skill_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_skill_name.DefaultText = "";
            this.txb_skill_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_skill_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_skill_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_skill_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_skill_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_skill_name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txb_skill_name.ForeColor = System.Drawing.Color.DimGray;
            this.txb_skill_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_skill_name.Location = new System.Drawing.Point(1090, 242);
            this.txb_skill_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txb_skill_name.Name = "txb_skill_name";
            this.txb_skill_name.PasswordChar = '\0';
            this.txb_skill_name.PlaceholderText = "Điền tên kỹ năng công việc ";
            this.txb_skill_name.SelectedText = "";
            this.txb_skill_name.Size = new System.Drawing.Size(405, 34);
            this.txb_skill_name.TabIndex = 60;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(1085, 197);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 22);
            this.label10.TabIndex = 58;
            this.label10.Text = "Kỹ năng";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1085, 144);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 22);
            this.label11.TabIndex = 59;
            this.label11.Text = "Khác";
            // 
            // guna2RatingStar1
            // 
            this.guna2RatingStar1.BorderColor = System.Drawing.Color.Black;
            this.guna2RatingStar1.BorderThickness = 1;
            this.guna2RatingStar1.Location = new System.Drawing.Point(129, 533);
            this.guna2RatingStar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2RatingStar1.Name = "guna2RatingStar1";
            this.guna2RatingStar1.RatingColor = System.Drawing.Color.Yellow;
            this.guna2RatingStar1.Size = new System.Drawing.Size(75, 22);
            this.guna2RatingStar1.TabIndex = 54;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(10, 567);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 18);
            this.label9.TabIndex = 50;
            this.label9.Text = "Bậc kĩ năng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(138, 567);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 18);
            this.label8.TabIndex = 49;
            this.label8.Text = "Đánh giá";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(226, 567);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 18);
            this.label7.TabIndex = 51;
            this.label7.Text = "Số công việc đã hoàn thành";
            // 
            // guna2Shapes2
            // 
            this.guna2Shapes2.BorderColor = System.Drawing.Color.Silver;
            this.guna2Shapes2.BorderThickness = 1;
            this.guna2Shapes2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2Shapes2.LineThickness = 1;
            this.guna2Shapes2.Location = new System.Drawing.Point(-171, 50);
            this.guna2Shapes2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Shapes2.Name = "guna2Shapes2";
            this.guna2Shapes2.PolygonSkip = 1;
            this.guna2Shapes2.Rotate = 0F;
            this.guna2Shapes2.Shape = Guna.UI2.WinForms.Enums.ShapeType.Line;
            this.guna2Shapes2.Size = new System.Drawing.Size(2037, 34);
            this.guna2Shapes2.TabIndex = 46;
            this.guna2Shapes2.Text = "guna2Shapes1";
            this.guna2Shapes2.Zoom = 80;
            // 
            // guna2Shapes1
            // 
            this.guna2Shapes1.BorderColor = System.Drawing.Color.Silver;
            this.guna2Shapes1.BorderThickness = 1;
            this.guna2Shapes1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2Shapes1.LineOrientation = System.Windows.Forms.Orientation.Vertical;
            this.guna2Shapes1.LineThickness = 1;
            this.guna2Shapes1.Location = new System.Drawing.Point(421, 37);
            this.guna2Shapes1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Shapes1.Name = "guna2Shapes1";
            this.guna2Shapes1.PolygonSkip = 1;
            this.guna2Shapes1.Rotate = 0F;
            this.guna2Shapes1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Line;
            this.guna2Shapes1.Size = new System.Drawing.Size(45, 958);
            this.guna2Shapes1.TabIndex = 47;
            this.guna2Shapes1.Text = "guna2Shapes1";
            this.guna2Shapes1.Zoom = 80;
            // 
            // txb_Email
            // 
            this.txb_Email.Animated = true;
            this.txb_Email.BorderColor = System.Drawing.Color.Gainsboro;
            this.txb_Email.BorderRadius = 6;
            this.txb_Email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_Email.DefaultText = "";
            this.txb_Email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_Email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_Email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_Email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_Email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_Email.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txb_Email.ForeColor = System.Drawing.Color.DimGray;
            this.txb_Email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_Email.Location = new System.Drawing.Point(497, 422);
            this.txb_Email.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txb_Email.Name = "txb_Email";
            this.txb_Email.PasswordChar = '\0';
            this.txb_Email.PlaceholderText = "Điền Email";
            this.txb_Email.SelectedText = "";
            this.txb_Email.Size = new System.Drawing.Size(456, 41);
            this.txb_Email.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(492, 386);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 22);
            this.label6.TabIndex = 43;
            this.label6.Text = "Email";
            // 
            // txb_SDT
            // 
            this.txb_SDT.Animated = true;
            this.txb_SDT.BorderColor = System.Drawing.Color.Gainsboro;
            this.txb_SDT.BorderRadius = 6;
            this.txb_SDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_SDT.DefaultText = "";
            this.txb_SDT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_SDT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_SDT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_SDT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_SDT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_SDT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txb_SDT.ForeColor = System.Drawing.Color.DimGray;
            this.txb_SDT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_SDT.Location = new System.Drawing.Point(496, 335);
            this.txb_SDT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txb_SDT.Name = "txb_SDT";
            this.txb_SDT.PasswordChar = '\0';
            this.txb_SDT.PlaceholderText = "Điền Email";
            this.txb_SDT.SelectedText = "";
            this.txb_SDT.Size = new System.Drawing.Size(456, 37);
            this.txb_SDT.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(491, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 22);
            this.label5.TabIndex = 42;
            this.label5.Text = "Số điện thoại";
            // 
            // lb_FavTho
            // 
            this.lb_FavTho.AutoSize = true;
            this.lb_FavTho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_FavTho.Location = new System.Drawing.Point(289, 527);
            this.lb_FavTho.Name = "lb_FavTho";
            this.lb_FavTho.Size = new System.Drawing.Size(23, 25);
            this.lb_FavTho.TabIndex = 41;
            this.lb_FavTho.Text = "0";
            // 
            // lb_DoneJob
            // 
            this.lb_DoneJob.AutoSize = true;
            this.lb_DoneJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_DoneJob.Location = new System.Drawing.Point(41, 531);
            this.lb_DoneJob.Name = "lb_DoneJob";
            this.lb_DoneJob.Size = new System.Drawing.Size(23, 25);
            this.lb_DoneJob.TabIndex = 40;
            this.lb_DoneJob.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(491, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 22);
            this.label4.TabIndex = 39;
            this.label4.Text = "Ngày sinh";
            // 
            // txb_Name
            // 
            this.txb_Name.Animated = true;
            this.txb_Name.BorderColor = System.Drawing.Color.Gainsboro;
            this.txb_Name.BorderRadius = 6;
            this.txb_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_Name.DefaultText = "";
            this.txb_Name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_Name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_Name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_Name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_Name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_Name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txb_Name.ForeColor = System.Drawing.Color.DimGray;
            this.txb_Name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_Name.Location = new System.Drawing.Point(497, 158);
            this.txb_Name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txb_Name.Name = "txb_Name";
            this.txb_Name.PasswordChar = '\0';
            this.txb_Name.PlaceholderText = "Điền họ và tên ";
            this.txb_Name.SelectedText = "";
            this.txb_Name.Size = new System.Drawing.Size(456, 37);
            this.txb_Name.TabIndex = 38;
            // 
            // avatar_box
            // 
            this.avatar_box.Image = global::win_project_2.Properties.Resources.avatar_trang_4;
            this.avatar_box.ImageRotate = 0F;
            this.avatar_box.Location = new System.Drawing.Point(129, 299);
            this.avatar_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.avatar_box.Name = "avatar_box";
            this.avatar_box.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.avatar_box.Size = new System.Drawing.Size(141, 142);
            this.avatar_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatar_box.TabIndex = 37;
            this.avatar_box.TabStop = false;
            // 
            // guna2Shapes3
            // 
            this.guna2Shapes3.BorderColor = System.Drawing.Color.Silver;
            this.guna2Shapes3.BorderThickness = 1;
            this.guna2Shapes3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2Shapes3.LineThickness = 1;
            this.guna2Shapes3.Location = new System.Drawing.Point(407, 572);
            this.guna2Shapes3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Shapes3.Name = "guna2Shapes3";
            this.guna2Shapes3.PolygonSkip = 1;
            this.guna2Shapes3.Rotate = 0F;
            this.guna2Shapes3.Shape = Guna.UI2.WinForms.Enums.ShapeType.Line;
            this.guna2Shapes3.Size = new System.Drawing.Size(1099, 34);
            this.guna2Shapes3.TabIndex = 48;
            this.guna2Shapes3.Text = "guna2Shapes1";
            this.guna2Shapes3.Zoom = 80;
            // 
            // guna2Shapes5
            // 
            this.guna2Shapes5.BorderColor = System.Drawing.Color.Silver;
            this.guna2Shapes5.BorderThickness = 1;
            this.guna2Shapes5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2Shapes5.LineOrientation = System.Windows.Forms.Orientation.Vertical;
            this.guna2Shapes5.LineThickness = 1;
            this.guna2Shapes5.Location = new System.Drawing.Point(198, 509);
            this.guna2Shapes5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Shapes5.Name = "guna2Shapes5";
            this.guna2Shapes5.PolygonSkip = 1;
            this.guna2Shapes5.Rotate = 0F;
            this.guna2Shapes5.Shape = Guna.UI2.WinForms.Enums.ShapeType.Line;
            this.guna2Shapes5.Size = new System.Drawing.Size(45, 87);
            this.guna2Shapes5.TabIndex = 52;
            this.guna2Shapes5.Text = "guna2Shapes4";
            this.guna2Shapes5.Zoom = 80;
            // 
            // guna2Shapes4
            // 
            this.guna2Shapes4.BorderColor = System.Drawing.Color.Silver;
            this.guna2Shapes4.BorderThickness = 1;
            this.guna2Shapes4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2Shapes4.LineOrientation = System.Windows.Forms.Orientation.Vertical;
            this.guna2Shapes4.LineThickness = 1;
            this.guna2Shapes4.Location = new System.Drawing.Point(91, 509);
            this.guna2Shapes4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Shapes4.Name = "guna2Shapes4";
            this.guna2Shapes4.PolygonSkip = 1;
            this.guna2Shapes4.Rotate = 0F;
            this.guna2Shapes4.Shape = Guna.UI2.WinForms.Enums.ShapeType.Line;
            this.guna2Shapes4.Size = new System.Drawing.Size(45, 87);
            this.guna2Shapes4.TabIndex = 53;
            this.guna2Shapes4.Text = "guna2Shapes4";
            this.guna2Shapes4.Zoom = 80;
            // 
            // guna2ShapesTool2
            // 
            this.guna2ShapesTool2.Location = new System.Drawing.Point(0, 0);
            this.guna2ShapesTool2.PolygonSkip = 1;
            this.guna2ShapesTool2.Rotate = 0F;
            this.guna2ShapesTool2.Size = new System.Drawing.Size(200, 200);
            this.guna2ShapesTool2.TargetControl = null;
            // 
            // lb_YourName
            // 
            this.lb_YourName.AutoSize = true;
            this.lb_YourName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_YourName.Location = new System.Drawing.Point(142, 463);
            this.lb_YourName.Name = "lb_YourName";
            this.lb_YourName.Size = new System.Drawing.Size(122, 22);
            this.lb_YourName.TabIndex = 34;
            this.lb_YourName.Text = "Tên của bạn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(503, 554);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 22);
            this.label3.TabIndex = 33;
            this.label3.Text = "Review";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(492, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 22);
            this.label2.TabIndex = 32;
            this.label2.Text = "Họ và Tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(493, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 22);
            this.label1.TabIndex = 31;
            this.label1.Text = "Thông tin cơ bản";
            // 
            // guna2ShapesTool1
            // 
            this.guna2ShapesTool1.Location = new System.Drawing.Point(0, 0);
            this.guna2ShapesTool1.PolygonSkip = 1;
            this.guna2ShapesTool1.Rotate = 0F;
            this.guna2ShapesTool1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Line;
            this.guna2ShapesTool1.Size = new System.Drawing.Size(200, 200);
            this.guna2ShapesTool1.TargetControl = null;
            // 
            // lb_Profie
            // 
            this.lb_Profie.AutoSize = true;
            this.lb_Profie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Profie.Location = new System.Drawing.Point(164, 255);
            this.lb_Profie.Name = "lb_Profie";
            this.lb_Profie.Size = new System.Drawing.Size(65, 22);
            this.lb_Profie.TabIndex = 36;
            this.lb_Profie.Text = "Hồ Sơ";
            // 
            // guna2Shapes6
            // 
            this.guna2Shapes6.BorderColor = System.Drawing.Color.Silver;
            this.guna2Shapes6.BorderThickness = 1;
            this.guna2Shapes6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2Shapes6.LineOrientation = System.Windows.Forms.Orientation.Vertical;
            this.guna2Shapes6.LineThickness = 1;
            this.guna2Shapes6.Location = new System.Drawing.Point(1034, 50);
            this.guna2Shapes6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Shapes6.Name = "guna2Shapes6";
            this.guna2Shapes6.PolygonSkip = 1;
            this.guna2Shapes6.Rotate = 0F;
            this.guna2Shapes6.Shape = Guna.UI2.WinForms.Enums.ShapeType.Line;
            this.guna2Shapes6.Size = new System.Drawing.Size(45, 572);
            this.guna2Shapes6.TabIndex = 57;
            this.guna2Shapes6.Text = "guna2Shapes6";
            this.guna2Shapes6.Zoom = 80;
            // 
            // btnaccept
            // 
            this.btnaccept.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnaccept.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnaccept.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnaccept.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnaccept.FillColor = System.Drawing.Color.SteelBlue;
            this.btnaccept.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaccept.ForeColor = System.Drawing.Color.White;
            this.btnaccept.Location = new System.Drawing.Point(1326, 850);
            this.btnaccept.Name = "btnaccept";
            this.btnaccept.Size = new System.Drawing.Size(180, 45);
            this.btnaccept.TabIndex = 72;
            this.btnaccept.Text = "Chấp nhận";
            this.btnaccept.Click += new System.EventHandler(this.btnaccept_Click);
            // 
            // btnRecject
            // 
            this.btnRecject.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRecject.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRecject.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRecject.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRecject.FillColor = System.Drawing.Color.SteelBlue;
            this.btnRecject.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecject.ForeColor = System.Drawing.Color.White;
            this.btnRecject.Location = new System.Drawing.Point(1090, 850);
            this.btnRecject.Name = "btnRecject";
            this.btnRecject.Size = new System.Drawing.Size(180, 45);
            this.btnRecject.TabIndex = 73;
            this.btnRecject.Text = "Từ chối";
            this.btnRecject.Click += new System.EventHandler(this.btnRecject_Click);
            // 
            // txtaddress
            // 
            this.txtaddress.Animated = true;
            this.txtaddress.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtaddress.BorderRadius = 6;
            this.txtaddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtaddress.DefaultText = "";
            this.txtaddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtaddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtaddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtaddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtaddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtaddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtaddress.ForeColor = System.Drawing.Color.DimGray;
            this.txtaddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtaddress.Location = new System.Drawing.Point(496, 505);
            this.txtaddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.PasswordChar = '\0';
            this.txtaddress.PlaceholderText = "Điền Email";
            this.txtaddress.SelectedText = "";
            this.txtaddress.Size = new System.Drawing.Size(456, 41);
            this.txtaddress.TabIndex = 75;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label13.Location = new System.Drawing.Point(491, 469);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 22);
            this.label13.TabIndex = 74;
            this.label13.Text = "Địa chỉ ";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(13, 798);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(191, 63);
            this.guna2HtmlLabel1.TabIndex = 76;
            this.guna2HtmlLabel1.Text = "Trạng thái :";
            // 
            // lbltrangthai
            // 
            this.lbltrangthai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltrangthai.ForeColor = System.Drawing.Color.Red;
            this.lbltrangthai.Location = new System.Drawing.Point(170, 807);
            this.lbltrangthai.Name = "lbltrangthai";
            this.lbltrangthai.Size = new System.Drawing.Size(289, 63);
            this.lbltrangthai.TabIndex = 77;
            this.lbltrangthai.Text = "label14";
            // 
            // ReviewID
            // 
            this.ReviewID.DataPropertyName = "ReviewID";
            this.ReviewID.HeaderText = "ReviewID";
            this.ReviewID.MinimumWidth = 6;
            this.ReviewID.Name = "ReviewID";
            // 
            // Name
            // 
            this.Name.DataPropertyName = "EmployerName";
            this.Name.HeaderText = "Employer";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            // 
            // Rating
            // 
            this.Rating.DataPropertyName = "Rating";
            this.Rating.HeaderText = "Rating";
            this.Rating.MinimumWidth = 6;
            this.Rating.Name = "Rating";
            // 
            // Comment
            // 
            this.Comment.DataPropertyName = "Comment";
            this.Comment.HeaderText = "Comment";
            this.Comment.MinimumWidth = 6;
            this.Comment.Name = "Comment";
            // 
            // ReviewDate
            // 
            this.ReviewDate.DataPropertyName = "ReviewDate";
            this.ReviewDate.HeaderText = "ReviewDate";
            this.ReviewDate.MinimumWidth = 6;
            this.ReviewDate.Name = "ReviewDate";
            // 
            // FormInfoCandidate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1527, 907);
            this.Controls.Add(this.lbltrangthai);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnRecject);
            this.Controls.Add(this.btnaccept);
            this.Controls.Add(this.Level);
            this.Controls.Add(this.dgreview);
            this.Controls.Add(this.txb_skill_descript);
            this.Controls.Add(this.dtBirthday);
            this.Controls.Add(this.guna2Shapes7);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txb_skill_name);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.guna2RatingStar1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.guna2Shapes2);
            this.Controls.Add(this.guna2Shapes1);
            this.Controls.Add(this.txb_Email);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txb_SDT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lb_FavTho);
            this.Controls.Add(this.lb_DoneJob);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txb_Name);
            this.Controls.Add(this.avatar_box);
            this.Controls.Add(this.guna2Shapes3);
            this.Controls.Add(this.guna2Shapes5);
            this.Controls.Add(this.guna2Shapes4);
            this.Controls.Add(this.lb_YourName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_Profie);
            this.Controls.Add(this.guna2Shapes6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            //this.Name = "FormInfoCandidate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInfoCandidate";
            this.Load += new System.EventHandler(this.FormInfoCandidate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatar_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox Level;
        private Guna.UI2.WinForms.Guna2DataGridView dgreview;
        private Guna.UI2.WinForms.Guna2TextBox txb_skill_descript;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtBirthday;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes7;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2TextBox txb_skill_name;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2RatingStar guna2RatingStar1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes2;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes1;
        private Guna.UI2.WinForms.Guna2TextBox txb_Email;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txb_SDT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_FavTho;
        private System.Windows.Forms.Label lb_DoneJob;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txb_Name;
        private Guna.UI2.WinForms.Guna2CirclePictureBox avatar_box;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes3;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes5;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes4;
        private Guna.UI2.WinForms.Guna2ShapesTool guna2ShapesTool2;
        private System.Windows.Forms.Label lb_YourName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2ShapesTool guna2ShapesTool1;
        private System.Windows.Forms.Label lb_Profie;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes6;
        private Guna.UI2.WinForms.Guna2Button btnaccept;
        private Guna.UI2.WinForms.Guna2Button btnRecject;
        private Guna.UI2.WinForms.Guna2TextBox txtaddress;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.Label lbltrangthai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReviewID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rating;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comment;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReviewDate;
    }
}