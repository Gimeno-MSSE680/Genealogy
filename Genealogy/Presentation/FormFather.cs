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
    public partial class FormFather : Form
    {
        public FormFather()
        {
            InitializeComponent();
        }

        private void checkBoxFatherKnown_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxFatherKnown.Checked)
            {
                textBoxFFirstName.Clear();
                textBoxFLastName.Clear();
                textBoxFGivenName.Clear();

                textBoxFFirstName.Hide();
                textBoxFLastName.Hide();
                textBoxFGivenName.Hide();
            }
            else if (checkBoxFatherKnown.Checked)
            {
                textBoxFFirstName.Show();
                textBoxFLastName.Show();
                textBoxFGivenName.Show();
            }
        }

        private void buttonAddFather_Click(object sender, EventArgs e)
        {
            Father father = new Father();
            if (checkBoxFatherKnown.Checked) father.fatherKnown = true;
            else if (!checkBoxFatherKnown.Checked) father.fatherKnown = false;
            father.fFirstName = textBoxFFirstName.Text;
            father.fLastName = textBoxFLastName.Text;
            father.fGivenName = textBoxFGivenName.Text;

            FatherMgr fatherMgr = new FatherMgr();
            fatherMgr.addFather(father);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxFFirstName.Clear();
            textBoxFLastName.Clear();
            textBoxFGivenName.Clear();
        }
    }
}
