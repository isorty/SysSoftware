using System;
using System.Windows.Forms;
using System.Drawing;

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

        private void eyeCheck_CheckedChanged(object sender, EventArgs e)
        {

            if (!eyeCheck.Checked)
            {
                passwordTextBox.PasswordChar = '•';
                eyeCheck.Image = Image.FromFile(@"..\..\Resources\eyeOpen.png");
            }
            else
            {
                passwordTextBox.PasswordChar = (char)0;
                eyeCheck.Image = Image.FromFile(@"..\..\Resources\eyeClosed.png");
            }
        }
    }
}
