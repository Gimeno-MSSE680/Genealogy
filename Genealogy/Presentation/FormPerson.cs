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
        public FormPerson()
        {
            InitializeComponent();
        }

        private void buttonAddPerson_Click(object sender, EventArgs e)
        {
            // Place person input in a domain object
            Person person = new Person();
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

            // Open FormFather to get information on father
//            FormFather formFather = new FormFather();
//            formFather.Show();

            // Place father in domain object
            Father father = new Father();
            father.fatherKnown = true;
            father.fFirstName = "Father";
            father.fLastName = "Time";
            father.fGivenName = "Time";
            person.Fathers = father;            // because of the Person/Father relationship

            // Place mother in domain object
            Mother mother = new Mother();
            mother.motherKnown = true;
            mother.mFirstName = "Mother";
            mother.mLastName = "Time";
            mother.mGivenName = "Nature";
            person.Mothers = mother;            // because of the Person/Mother relationship

            // Delegate
            PersonMgr personMgr = new PersonMgr();
            personMgr.addPerson(person);

            if (person.firstName  != "" ||
                person.lastName   != "" ||
                person.givenName  != "" ||
                person.gender     != "" ||
                person.birthDate  != "" ||
                person.birthPlace != "" ||
                person.deathDate  != "" ||
                person.deathPlace != "" ||
                person.occupation != "")
            {
                MessageBox.Show("Person successfully added", "Person is known",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (person.firstName  == "" &&
                     person.lastName   == "" &&
                     person.givenName  == "" &&
                     person.gender     == "" &&
                     person.birthDate  == "" &&
                     person.birthPlace == "" &&
                     person.deathDate  == "" &&
                     person.deathPlace == "" &&
                     person.occupation == "")
            {
                MessageBox.Show("Unknown person successfully added", "Person is unknown",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        } // End buttonAddPerson_Click(object sender, EventArgs e)

        private void buttonClear_Click(object sender, EventArgs e)
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

        } // End buttonClear_Click(object sender, EventArgs e)

    } // End FormPerson class

} // End Presentation namespace
