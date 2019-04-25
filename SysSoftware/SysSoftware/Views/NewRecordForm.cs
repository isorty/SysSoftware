using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysSoftware.Views
{
    public partial class NewRecordForm : Form
    {
        public bool OK { get; set; }
        public string Login
        {
            get { return loginTextBox.Text; }
            set { loginTextBox.Text = value; }
        }

        public string HashPassword
        {
            get { return hashTextBox.Text; }
            set { hashTextBox.Text = value; }
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

        public NewRecordForm(string login, string hashPassword, string email)
        {
            OK = false;
            Login = login;
            HashPassword = hashPassword;
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
