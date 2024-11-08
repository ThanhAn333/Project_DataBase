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
using win_project_2.Models;



namespace win_project_2.Forms.UCComponents
{
    public partial class FormChat : Form
    {
        int _id_receiver;
        public FormChat(int id_receiver)
        {
            InitializeComponent();
            _id_receiver = id_receiver;

            //

            listMessage.View = View.Details;
            listMessage.Columns.Add("Sender", 100);
            listMessage.Columns.Add("Content", 300);
            listMessage.Columns.Add("Timestamp", 150);

            LoadMessagesToListView(UserDangNhap.userId, _id_receiver);
            int user1ID = int.Parse(UserDangNhap.userId.ToString());
            int user2ID = int.Parse(_id_receiver.ToString());

            MessageDAO messageDAO = new MessageDAO();
            List<Message> messages = messageDAO.LoadMessages(user1ID, user2ID);

            DisplayMessagesInListView(messages);

            //List conversation

            DisplayConversationInListView();
        }

        public void DisplayMessagesInListView(List<Message> messages)
        {
            listMessage.Items.Clear();

            UserDAO userDAO = new UserDAO();

            foreach (var message in messages)
            {
                
                string senderName = userDAO.GetUserNameByID(message.SenderID) ?? "Unknown"; // Kiểm tra nếu tên không tồn tại

                
                ListViewItem item = new ListViewItem(senderName);
                item.SubItems.Add(message.Content);
                item.SubItems.Add(message.Timestamp.ToString("g"));

                listMessage.Items.Add(item);
            }

        }

        public void DisplayConversationInListView()
        {
            listConversation.Items.Clear();
            UserDAO userDAO = new UserDAO();
            MessageDAO messageDAO = new MessageDAO();

            List<int> receiverIDs = messageDAO.GetDistinctReceiverIDsBySender(UserDangNhap.userId);

            foreach (int receiverID in receiverIDs)
            {
                
                string receiverName = userDAO.GetUserNameByID(receiverID);

                
                ListViewItem item = new ListViewItem(receiverName);
                item.Tag = receiverID;
                listConversation.Items.Add(item);
            }

        }


        private int selectedReceiverID; // Variable to store the selected receiverID

        private void listConversation_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                // Get the receiverID from the selected item's Tag
                selectedReceiverID = (int)e.Item.Tag;
                // You can now use selectedReceiverID for other operations in your form


                listMessage.Items.Clear();


                LoadMessagesToListView(UserDangNhap.userId, _id_receiver);
                int user1ID = int.Parse(UserDangNhap.userId.ToString());
                int user2ID = int.Parse(selectedReceiverID.ToString());

                MessageDAO messageDAO = new MessageDAO();
                List<Message> messages = messageDAO.LoadMessages(user1ID, user2ID);

                DisplayMessagesInListView(messages);

            }
        }


        private void btn_send_Click(object sender, EventArgs e)
        {
            MessageDAO messageDAO = new MessageDAO();
            messageDAO.SendMessage(UserDangNhap.userId, _id_receiver, tb_mess.Text);
            tb_mess.Clear();

            int user1ID = int.Parse(UserDangNhap.userId.ToString());
            int user2ID = int.Parse(_id_receiver.ToString());

            
            List<Message> messages = messageDAO.LoadMessages(user1ID, user2ID);


            // Hiển thị tin nhắn lên ListView
            DisplayMessagesInListView(messages);
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
            if (listConversation.SelectedItems.Count > 0)
            {
                // Get the selected item
                ListViewItem selectedItem = listConversation.SelectedItems[0];

                // Retrieve the Tag (which stores the receiverID)
                int receiverID = (int)selectedItem.Tag;

                // Assign it to your variable or use it as needed
                selectedReceiverID = receiverID;

                listMessage.Items.Clear();


                LoadMessagesToListView(UserDangNhap.userId, _id_receiver);
                int user1ID = int.Parse(UserDangNhap.userId.ToString());
                int user2ID = int.Parse(selectedReceiverID.ToString());

                MessageDAO messageDAO = new MessageDAO();
                List<Message> messages = messageDAO.LoadMessages(user1ID, user2ID);

                DisplayMessagesInListView(messages);

            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
