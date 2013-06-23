using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using Business;

namespace Presentation
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.username = textBoxUsername.Text;
            login.password = textBoxPassword.Text;

            LoginMgr loginMgr = new LoginMgr();
            Boolean isAuthenticated = loginMgr.authenticateLogin(login);

            if (isAuthenticated)
            {
                MessageBox.Show("Welcome to your family tree!", "Login success",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    
                FormPerson formPerson = new FormPerson();
                formPerson.Show();
            }
            else if (!isAuthenticated)
            {
                MessageBox.Show("Invalid username and/or password. Try again.", "Login failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        } // End buttonLogin_Click(object sender, EventArgs e)

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxUsername.Clear();
            textBoxPassword.Clear();
        }

    } // End FormLogin class

} // End Presentation namespace