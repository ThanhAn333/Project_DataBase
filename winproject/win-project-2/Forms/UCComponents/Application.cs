﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace win_project_2.Forms.UCComponents
{
    public partial class Application : UserControl
    {
        public Application()
        {
            InitializeComponent();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void themThongTin(string title, string date, string status)
        {
            lbltitle.Text = title;
            lbdate.Text = date;
            lbstatus.Text = status;
        }
        private void btnDetail_Click(object sender, EventArgs e)
        {

        }
    }
}
