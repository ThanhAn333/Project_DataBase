namespace win_project_2.UserControls
{
    partial class UCWaitJob
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
            this.lb_jobname = new System.Windows.Forms.Label();
            this.lb_status = new System.Windows.Forms.Label();
            this.btn_complete = new System.Windows.Forms.Button();
            this.guna2Shapes1 = new Guna.UI2.WinForms.Guna2Shapes();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.SuspendLayout();
            // 
            // lb_jobname
            // 
            this.lb_jobname.AutoSize = true;
            this.lb_jobname.BackColor = System.Drawing.Color.White;
            this.lb_jobname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_jobname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lb_jobname.Location = new System.Drawing.Point(107, 64);
            this.lb_jobname.Name = "lb_jobname";
            this.lb_jobname.Size = new System.Drawing.Size(99, 36);
            this.lb_jobname.TabIndex = 0;
            this.lb_jobname.Text = "label1";
            // 
            // lb_status
            // 
            this.lb_status.AutoSize = true;
            this.lb_status.BackColor = System.Drawing.Color.White;
            this.lb_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lb_status.Location = new System.Drawing.Point(347, 71);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(44, 16);
            this.lb_status.TabIndex = 1;
            this.lb_status.Text = "label2";
            // 
            // btn_complete
            // 
            this.btn_complete.Location = new System.Drawing.Point(609, 53);
            this.btn_complete.Name = "btn_complete";
            this.btn_complete.Size = new System.Drawing.Size(128, 58);
            this.btn_complete.TabIndex = 2;
            this.btn_complete.Text = "HOÀN THÀNH";
            this.btn_complete.UseVisualStyleBackColor = true;
            this.btn_complete.Click += new System.EventHandler(this.btn_complete_Click);
            // 
            // guna2Shapes1
            // 
            this.guna2Shapes1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Shapes1.FillColor = System.Drawing.Color.White;
            this.guna2Shapes1.Location = new System.Drawing.Point(-46, 3);
            this.guna2Shapes1.Name = "guna2Shapes1";
            this.guna2Shapes1.PolygonSkip = 1;
            this.guna2Shapes1.Rotate = 0F;
            this.guna2Shapes1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rounded;
            this.guna2Shapes1.Size = new System.Drawing.Size(892, 154);
            this.guna2Shapes1.TabIndex = 3;
            this.guna2Shapes1.Text = "guna2Shapes1";
            this.guna2Shapes1.Zoom = 80;
            // 
            // UCWaitJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btn_complete);
            this.Controls.Add(this.lb_status);
            this.Controls.Add(this.lb_jobname);
            this.Controls.Add(this.guna2Shapes1);
            this.Name = "UCWaitJob";
            this.Size = new System.Drawing.Size(812, 171);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_jobname;
        private System.Windows.Forms.Label lb_status;
        private System.Windows.Forms.Button btn_complete;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
    }
}
