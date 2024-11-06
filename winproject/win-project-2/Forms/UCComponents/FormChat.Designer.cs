namespace win_project_2.Forms.UCComponents
{
    partial class FormChat
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
            this.listConversation = new System.Windows.Forms.ListView();
            this.btn_send = new System.Windows.Forms.Button();
            this.tb_mess = new Guna.UI2.WinForms.Guna2TextBox();
            this.listMessage = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listConversation
            // 
            this.listConversation.HideSelection = false;
            this.listConversation.Location = new System.Drawing.Point(56, 98);
            this.listConversation.Name = "listConversation";
            this.listConversation.Size = new System.Drawing.Size(429, 508);
            this.listConversation.TabIndex = 7;
            this.listConversation.UseCompatibleStateImageBehavior = false;
            this.listConversation.Click += new System.EventHandler(this.listMessage_SelectedIndexChanged);
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(1275, 648);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(112, 47);
            this.btn_send.TabIndex = 6;
            this.btn_send.Text = "SEND";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // tb_mess
            // 
            this.tb_mess.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_mess.DefaultText = "";
            this.tb_mess.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_mess.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_mess.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_mess.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_mess.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_mess.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_mess.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_mess.Location = new System.Drawing.Point(505, 648);
            this.tb_mess.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_mess.Name = "tb_mess";
            this.tb_mess.PasswordChar = '\0';
            this.tb_mess.PlaceholderText = "";
            this.tb_mess.SelectedText = "";
            this.tb_mess.Size = new System.Drawing.Size(764, 47);
            this.tb_mess.TabIndex = 5;
            // 
            // listMessage
            // 
            this.listMessage.HideSelection = false;
            this.listMessage.Location = new System.Drawing.Point(505, 98);
            this.listMessage.Name = "listMessage";
            this.listMessage.Size = new System.Drawing.Size(882, 508);
            this.listMessage.TabIndex = 4;
            this.listMessage.UseCompatibleStateImageBehavior = false;
            // 
            // FormChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 793);
            this.Controls.Add(this.listConversation);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.tb_mess);
            this.Controls.Add(this.listMessage);
            this.Name = "FormChat";
            this.Text = "FormChat";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listConversation;
        private System.Windows.Forms.Button btn_send;
        private Guna.UI2.WinForms.Guna2TextBox tb_mess;
        private System.Windows.Forms.ListView listMessage;
    }
}