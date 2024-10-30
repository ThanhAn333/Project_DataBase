using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Animation;
using win_project_2.DAO;
using win_project_2.Models;
using win_project_2.Service;
using win_project_2.UserControls;

namespace win_project_2.Forms
{
    public partial class ThoDetail : Form
    {
        private int favCount,doneJob;
        public string id;
        public ThoDetail(int _id)
        {
            InitializeComponent();
            LoadDataUser(_id);

        }

        void LoadDataUser(int id)
        {
            UserDAO userDAO = new UserDAO();
            User user = userDAO.GetUserByID(id);

            //code load

            SkillDAO skillDAO = new SkillDAO();
            List<Skill> skills = skillDAO.GetSkillsByUserId(UserDangNhap.userId);

            if (skills.Count > 0)
            {
                Skill skill = skills[0];
                lb_skill_name.Text = skill.Name;
                lb_skill_descript.Text = skill.Description;
                lb_level.Text = skill.ProficiencyLevel;
            }

        }

        private async void LoadData(string id)
        {
            
        }
        public int CountJobs(string listjob)
        {

            if (listjob == "")
            {
                return 0;
            }
            string[] jobs = listjob.Split(',');


            return jobs.Length;
        }
        private void guna2Shapes2_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Shapes4_Click(object sender, EventArgs e)
        {

        }

        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void lb_Ex_Click(object sender, EventArgs e)
        {

        }

        private async void bnt_Mess_Click(object sender, EventArgs e)
        {
           
        }


    }
}