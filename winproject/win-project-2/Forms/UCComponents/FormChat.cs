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
using win_project_2.Service;

namespace win_project_2.Forms.UCComponents
{
    public partial class FormChat : Form
    {
        int _id_receiver;
        public FormChat(int id_receiver)
        {
            InitializeComponent();
            _id_receiver = id_receiver;

            listMessage.View = View.Details;
            listMessage.Columns.Add("Sender", 100);
            listMessage.Columns.Add("Content", 300);
            listMessage.Columns.Add("Timestamp", 150);

            LoadMessagesToListView(UserDangNhap.userId, _id_receiver);
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            MessageDAO messageDAO = new MessageDAO();
            messageDAO.SendMessage(UserDangNhap.userId, _id_receiver, tb_mess.Text);
            tb_mess.Clear();
        }

        public void LoadMessagesToListView(int senderId, int receiverId)
        {
            listMessage.Items.Clear();

            MessageDAO messageDAO = new MessageDAO();
            //List<win_project_2.Models.Message> messages = messageDAO.LoadMessages(senderId, receiverId);

            
        }

        private void tb_mess_TextChanged(object sender, EventArgs e)
        {

        }

        private void listMessage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
