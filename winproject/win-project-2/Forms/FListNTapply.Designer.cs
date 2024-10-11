namespace win_project_2.Forms
{
    partial class FListNTapply
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Shapes6 = new Guna.UI2.WinForms.Guna2Shapes();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(31, 65);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(781, 483);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(868, 65);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(962, 483);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // guna2Shapes6
            // 
            this.guna2Shapes6.BorderColor = System.Drawing.Color.DimGray;
            this.guna2Shapes6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2Shapes6.LineOrientation = System.Windows.Forms.Orientation.Vertical;
            this.guna2Shapes6.LineThickness = 1;
            this.guna2Shapes6.Location = new System.Drawing.Point(817, 34);
            this.guna2Shapes6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Shapes6.Name = "guna2Shapes6";
            this.guna2Shapes6.PolygonSkip = 1;
            this.guna2Shapes6.Rotate = 0F;
            this.guna2Shapes6.Shape = Guna.UI2.WinForms.Enums.ShapeType.Line;
            this.guna2Shapes6.Size = new System.Drawing.Size(45, 743);
            this.guna2Shapes6.TabIndex = 42;
            this.guna2Shapes6.Text = "guna2Shapes6";
            this.guna2Shapes6.Zoom = 80;
            // 
            // FListNTapply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1870, 594);
            this.Controls.Add(this.guna2Shapes6);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "FListNTapply";
            this.Text = "FListNTapply";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes6;
    }
}