using System;
using System.Collections;
using System.Configuration;
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
    public partial class FormPerson : Form
    {
        Person person = new Person();

        public FormPerson()
        {
            InitializeComponent();
        }

        //*******************************************************************************
        //*******************************************************************************
        //                     SPLIT CONTAINER ADD PERSON 
        // person is not actually added here.  Person is added after having input all
        // person relationships (father and mother) therefor, person is added with the
        // buttonFinishAddPerson_Click action within the split container add parents panel 2
        //*******************************************************************************
        //*******************************************************************************
        private void buttonClearPerson_Click(object sender, EventArgs e)
        {
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxGivenName.Clear();
            textBoxGender.Clear();
            textBoxBirthDate.Clear();
            textBoxBirthPlace.Clear();
            textBoxDeathDate.Clear();
            textBoxDeathPlace.Clear();
            textBoxOccupation.Clear();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Exit the application
            System.Windows.Forms.Application.Exit();
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            splitContainerAddPerson.Panel1.Enabled = false;
            splitContainerAddParents.Panel1.Enabled = true;
        }

        //*******************************************************************************
        //*******************************************************************************
        //                     SPLIT CONTAINER ADD PARENTS - FATHER
        //*******************************************************************************
        //*******************************************************************************
        private void checkBoxFatherKnow_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxFatherKnow.Checked)
            {
                textBoxFatherFirstName.Clear();
                textBoxFatherLastName.Clear();
                textBoxFatherGivenName.Clear();

                textBoxFatherFirstName.Enabled = false;
                textBoxFatherLastName.Enabled = false;
                textBoxFatherGivenName.Enabled = false;
            }
            else if (checkBoxFatherKnow.Checked)
            {
                textBoxFatherFirstName.Enabled = true;
                textBoxFatherLastName.Enabled = true;
                textBoxFatherGivenName.Enabled = true;
            }
        }

        private void buttonAddingFather_Click(object sender, EventArgs e)
        {
            splitContainerAddParents.Panel1.Enabled = false;
            splitContainerAddParents.Panel2.Enabled = true;
        }

        private void buttonClearFatherInfo_Click(object sender, EventArgs e)
        {
            textBoxFatherFirstName.Clear();
            textBoxFatherLastName.Clear();
            textBoxFatherGivenName.Clear();
        }

        private void buttonBackToPerson_Click(object sender, EventArgs e)
        {
            splitContainerAddPerson.Panel1.Enabled = true;
            splitContainerAddParents.Panel1.Enabled = false;
        }

        //*******************************************************************************
        //*******************************************************************************
        //                     SPLIT CONTAINER ADD PARENTS - MOTHER
        //*******************************************************************************
        //*******************************************************************************
        private void checkBoxMotherKnow_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxMotherKnow.Checked)
            {
                textBoxMotherFirstName.Clear();
                textBoxMotherLastName.Clear();
                textBoxMotherGivenName.Clear();

                textBoxMotherFirstName.Enabled = false;
                textBoxMotherLastName.Enabled = false;
                textBoxMotherGivenName.Enabled = false;
            }
            else if (checkBoxMotherKnow.Checked)
            {
                textBoxMotherFirstName.Enabled = true;
                textBoxMotherLastName.Enabled = true;
                textBoxMotherGivenName.Enabled = true;
            }
        }

        private void buttonClearMotherInfo_Click(object sender, EventArgs e)
        {
            textBoxMotherFirstName.Clear();
            textBoxMotherLastName.Clear();
            textBoxMotherGivenName.Clear();
        }

        private void buttonBackToFather_Click(object sender, EventArgs e)
        {
            splitContainerAddParents.Panel1.Enabled = true;
            splitContainerAddParents.Panel2.Enabled = false;
        }

        /*
         * Add Person and person's relationship's to the table
         */
        private void buttonFinishAddPerson_Click(object sender, EventArgs e)
        {
            // Add Father based on user input
            Father father = new Father();
            if (checkBoxFatherKnow.Checked) father.fatherKnown = true;
            else if (!checkBoxFatherKnow.Checked) father.fatherKnown = false;
            father.fFirstName = textBoxFatherFirstName.Text;
            father.fLastName = textBoxFatherLastName.Text;
            father.fGivenName = textBoxFatherGivenName.Text;

            FatherMgr fatherMgr = new FatherMgr();
            fatherMgr.addFather(father);

            person.Fathers = father;            // because of the Person/Father relationship

            // Add Mother based on user input
            Mother mother = new Mother();
            if (checkBoxMotherKnow.Checked) mother.motherKnown = true;
            else if (!checkBoxMotherKnow.Checked) mother.motherKnown = false;
            mother.mFirstName = textBoxMotherFirstName.Text;
            mother.mLastName = textBoxMotherLastName.Text;
            mother.mGivenName = textBoxMotherGivenName.Text;

            MotherMgr motherMgr = new MotherMgr();
            motherMgr.addMother(mother);

            person.Mothers = mother;            // because of the Person/Mother relationship

            // Place person input in a domain object
            person.firstName = textBoxFirstName.Text;
            person.lastName = textBoxLastName.Text;
            person.givenName = textBoxGivenName.Text;
            person.gender = textBoxGender.Text;
            person.birthDate = textBoxBirthDate.Text;
            person.birthPlace = textBoxBirthPlace.Text;
            person.deathDate = textBoxDeathDate.Text;
            person.deathPlace = textBoxDeathPlace.Text;
            person.occupation = textBoxOccupation.Text;

            // Place list in domain object
            List list = new List();
            ListMgr listMgr = new ListMgr();
            listMgr.editList(list);
            person.Lists = list;                // because of the Person/List relationship

            // Delegate
            PersonMgr personMgr = new PersonMgr();
            personMgr.addPerson(person);

            if (person.firstName == "Person" &&
                     person.lastName == "Unknown" &&
                     person.givenName == "" &&
                     person.gender == "" &&
                     person.birthDate == "" &&
                     person.birthPlace == "" &&
                     person.deathDate == "" &&
                     person.deathPlace == "" &&
                     person.occupation == "")
            {
                MessageBox.Show("Unknown person successfully added", "Person is unknown",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            else if (person.firstName != "" ||
                person.lastName != "" ||
                person.givenName != "" ||
                person.gender != "" ||
                person.birthDate != "" ||
                person.birthPlace != "" ||
                person.deathDate != "" ||
                person.deathPlace != "" ||
                person.occupation != "")
            {
                MessageBox.Show("Person successfully added", "Person is known",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            
            splitContainerAddParents.Panel2.Enabled = false;
            splitContainerAddPerson.Panel1.Enabled = true;
        }

        private void splitContainerAddParents_Panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void splitContainerAddParents_Panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        //*******************************************************************************
        //*******************************************************************************
        //                 TAB CONTROL PERSON - VIEW SAVED FAMILY MEMBERS                
        //*******************************************************************************
        //*******************************************************************************
        private void buttonViewFamily_Click(object sender, EventArgs e)
        {
            listBoxViewFamily.Items.Clear();

            Person person = new Person();
            string genderMark;
           
            PersonMgr personMgr = new PersonMgr();
            IEnumerable<Person> familyMembers = personMgr.GetFamily();
        
            foreach (Person element in familyMembers)
            {
                if (element.gender.ToUpper() == "MALE" || element.gender.ToUpper() == "M") genderMark = "Mr. ";
                else if (element.gender.ToUpper() == "FEMALE" || element.gender.ToUpper() == "F") genderMark = "Ms. ";
                else genderMark = "";

                string personInfo = genderMark + element.firstName + " " + element.lastName;
                listBoxViewFamily.Items.Add(personInfo);
            }
        }
    } // End FormPerson class

} // End Presentation namespace
