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

            UserMgr userMgr = new UserMgr();
            Login loginAuthentication = userMgr.authenticateLogin(login);

        } // End buttonLogin_Click(object sender, EventArgs e)

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxUsername.Clear();
            textBoxPassword.Clear();

        } // End buttonClear_Click(object sender, EventArgs e)

    } // End FormLogin class

} // End Presentation namespace