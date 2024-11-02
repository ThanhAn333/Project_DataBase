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
using win_project_2.Models;
using win_project_2.Service;

namespace win_project_2.Forms.Recruiter
{
    public partial class FormInfoCandidate : Form
    {
        private int userID;
        public FormInfoCandidate()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void themThongTin(int userid, string name, string birthday, string phone, string email, string address)
        {
            userID = userid;
            lb_YourName.Text = txb_Name.Text = name;
            txb_SDT.Text = phone;
            dtBirthday.Text = birthday;
            txb_Email.Text = email;
            txtaddress.Text = address;
        }
        public int getUserID()
        {
            return userID;
        }
        private void FormInfoCandidate_Load(object sender, EventArgs e)
        {
             
            SkillDAO skillDAO = new SkillDAO();
            List<Skill> skills = skillDAO.GetSkillsByUserId(getUserID());

            if (skills.Count > 0)
            {
                Skill skill = skills[0];
                txb_skill_name.Text = skill.Name;
                txb_skill_descript.Text = skill.Description;
                Level.SelectedItem = skill.ProficiencyLevel;
            }


        }
    }
}
