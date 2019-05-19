using System;
using System.Windows.Forms;

namespace SysSoftware
{
    public partial class NewRecordForm : Form
    {
        public bool OK { get; set; }
        public string Login
        {
            get { return loginTextBox.Text; }
            set { loginTextBox.Text = value; }
        }

        public string Password
        {
            get { return passwordTextBox.Text; }
            set { passwordTextBox.Text = value; }
        }

        public string Email
        {
            get { return emailTextBox.Text; }
            set { emailTextBox.Text = value; }
        }

        public NewRecordForm()
        {
            OK = false;
            InitializeComponent();
        }

        public NewRecordForm(string login, string password, string email)
        {
            OK = false;
            Login = login;
            Password = password;
            Email = email;
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            OK = true;
            this.Close();
        }

        private void cancelButtom_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
