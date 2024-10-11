namespace win_project_2.UserControls
{
    partial class UCWriteRV
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
            this.components = new System.ComponentModel.Container();
            this.lb_name = new System.Windows.Forms.Label();
            this.btn_rv = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.guna2Shapes1 = new Guna.UI2.WinForms.Guna2Shapes();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.SuspendLayout();
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.BackColor = System.Drawing.Color.White;
            this.lb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lb_name.Location = new System.Drawing.Point(135, 64);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(64, 25);
            this.lb_name.TabIndex = 0;
            this.lb_name.Text = "label1";
            // 
            // btn_rv
            // 
            this.btn_rv.Location = new System.Drawing.Point(693, 51);
            this.btn_rv.Name = "btn_rv";
            this.btn_rv.Size = new System.Drawing.Size(164, 57);
            this.btn_rv.TabIndex = 1;
            this.btn_rv.Text = "Viết đánh giá";
            this.btn_rv.UseVisualStyleBackColor = true;
            this.btn_rv.Click += new System.EventHandler(this.btn_rv_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(547, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // guna2Shapes1
            // 
            this.guna2Shapes1.BorderColor = System.Drawing.Color.White;
            this.guna2Shapes1.FillColor = System.Drawing.Color.White;
            this.guna2Shapes1.Location = new System.Drawing.Point(-64, -6);
            this.guna2Shapes1.Name = "guna2Shapes1";
            this.guna2Shapes1.PolygonSkip = 1;
            this.guna2Shapes1.Rotate = 0F;
            this.guna2Shapes1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rounded;
            this.guna2Shapes1.Size = new System.Drawing.Size(1060, 164);
            this.guna2Shapes1.TabIndex = 3;
            this.guna2Shapes1.Text = "guna2Shapes1";
            this.guna2Shapes1.Zoom = 80;
            this.guna2Shapes1.Click += new System.EventHandler(this.guna2Shapes1_Click);
            // 
            // UCWriteRV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_rv);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.guna2Shapes1);
            this.Name = "UCWriteRV";
            this.Size = new System.Drawing.Size(919, 161);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Button btn_rv;
        private System.Windows.Forms.Button button1;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
    }
}
