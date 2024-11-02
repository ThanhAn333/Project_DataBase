using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using win_project_2.DAO;

namespace win_project_2.Forms.Recruiter.UC
{
    public partial class UCCandidate : UserControl
    {
        private int userID;
        public UCCandidate()
        {
            InitializeComponent();
        }
        public void themThongTin(int userid, string name, string email, string date)
        {
            userID = userid;
            lblname.Text = name;
            lblemail.Text = email;
            lbldate.Text = date;
        }
        public int getUserID()
        {
            return userID;
        }

        private void UCCandidate_Load(object sender, EventArgs e)
        {
           
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            UserDAO userDAO = new UserDAO();

            DataTable dt = userDAO.doDuLieuThongTinNguoidung(getUserID());
            foreach (DataRow row in dt.Rows)
            {

                FormInfoCandidate formInfoCandidate = new FormInfoCandidate();

                int userid = (int)row["UserID"];
                string name = row["Name"].ToString();
                string email = row["Email"].ToString();
                string address = row["Address"].ToString();
                string date = row["DateOfBirth"].ToString();
                string phone = row["PhoneNumber"].ToString();

                formInfoCandidate.themThongTin(userid, name, date, phone, email, address);

                formInfoCandidate.Show();

            }
        }
    }
}
