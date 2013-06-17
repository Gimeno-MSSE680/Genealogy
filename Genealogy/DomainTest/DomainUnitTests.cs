using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;
using System.Data;
using System.Linq;

namespace DomainTest
{
    [TestClass]
    public class DomainUnitTests
    {
        //**********************************************************************
        // * Test methods to PULL records from the Genealogy database
        //**********************************************************************

        /*
         * Method TestPersonForRecords() checks whether or not the table for Person
         * is empty or not by searching the first position in the table for a Person
         */
        [TestMethod]
        public void TestPersonForRecords()
        {
            // Arrange - variable for database
            GenealogyModelContainer db = new GenealogyModelContainer();

            // Act - get the person in the first position
            Person savedPerson = (from d in db.People where d.personId == 1 select d).Single();

            // Assert - verify that a person is stored in the first position
            Assert.AreEqual(savedPerson.personId, 1);

        } // end TestPersonForRecords()

        /*
         * Method TestUserForRecords() checks whether or not the table for User
         * is empty or not by searching the first position in the table for a User
         */
        [TestMethod]
        public void TestUserForRecords()
        {
            // Arrange - variable for database
            GenealogyModelContainer db = new GenealogyModelContainer();

            // Act - get the user in the first position
            User savedUser = (from d in db.Users where d.userId == 1 select d).Single();

            // Assert - verify that a user is stored in the first position
            Assert.AreEqual(savedUser.userId, 1);

        } // end TestUserForRecords()

        //**********************************************************************
        // * Test methods to ADD objects to the Genealogy database
        //**********************************************************************

        /*
         * Method TestAddPerson() to test whether an object Person will add this 
         * person to the repository. This test includes adding List, Father, and
         * Mother to the repository due to the many-to-one relationships
         * (i.e. many people per list/father/mother)
         */
        [TestMethod]
        public void TestAddPerson()
        {
            // Arrange - add a person, list, father, and mother to the database
            Person person = new Person();
            List list = new List();
            Father father = new Father();
            Mother mother = new Mother();
            
            GenealogyModelContainer db = new GenealogyModelContainer();

            person.firstName = "Penny";
            person.lastName = "Saver";
            person.givenName = "Spender";
            person.gender = "female";
            person.birthDate = "January 1, 1921";
            person.birthPlace = "Hollywood";
            person.deathDate = "January 1, 1984";
            person.deathPlace = "Bakersville";
            person.occupation = "Baker";

            list.knownPersonQuantity = 1;
            list.unknownPersonQuantity = 0;

            father.fatherKnown = true;
            father.fFirstName = "Buck";
            father.fLastName = "Saver";
            father.fGivenName = "Saver";

            mother.motherKnown = true;
            mother.mFirstName = "Sharin";
            mother.mLastName = "Saver";
            mother.mGivenName = "Allota";

            person.Lists = list;        // because of the Person/List relationship
            person.Fathers = father;    // because of the Person/Father relationship
            person.Mothers = mother;    // because of the Person/Mother relationship
 
            db.People.Add(person);

            // Act - save changes to the database
            db.SaveChanges();

            // Assert - verify that this person has been saved to the database
            Person savedPerson = (from d in db.People where d.personId == person.personId select d).Single();
            List savedList = (from d in db.Lists where d.listId == list.listId select d).Single();
            Father savedFather = (from d in db.Fathers where d.fatherId == father.fatherId select d).Single();
            Mother savedMother = (from d in db.Mothers where d.motherId == mother.motherId select d).Single();

            Assert.AreEqual(savedPerson.firstName, person.firstName);
            Assert.AreEqual(savedPerson.lastName, person.lastName);
            Assert.AreEqual(savedPerson.givenName, person.givenName);
            Assert.AreEqual(savedPerson.gender, person.gender);
            Assert.AreEqual(savedPerson.birthDate, person.birthDate);
            Assert.AreEqual(savedPerson.birthPlace, person.birthPlace);
            Assert.AreEqual(savedPerson.deathDate, person.deathDate);
            Assert.AreEqual(savedPerson.deathPlace, person.deathPlace);
            Assert.AreEqual(savedPerson.occupation, person.occupation);

            Assert.AreEqual(savedList.knownPersonQuantity, list.knownPersonQuantity);
            Assert.AreEqual(savedList.unknownPersonQuantity, list.unknownPersonQuantity);

            Assert.AreEqual(savedFather.fatherKnown, father.fatherKnown);
            Assert.AreEqual(savedFather.fFirstName, father.fFirstName);
            Assert.AreEqual(savedFather.fLastName, father.fLastName);
            Assert.AreEqual(savedFather.fGivenName, father.fGivenName);

            Assert.AreEqual(savedMother.motherKnown, mother.motherKnown);
            Assert.AreEqual(savedMother.mFirstName, mother.mFirstName);
            Assert.AreEqual(savedMother.mLastName, mother.mLastName);
            Assert.AreEqual(savedMother.mGivenName, mother.mGivenName);

        } // end TestAddPerson()

        /*
         * Method TestAddUser() to test whether an object User will add this 
         * user to the repository. This test includes adding Login to the 
         * repository due to the many-to-one relationship (i.e. many users has
         * one login)
         */
        [TestMethod]
        public void TestAddUser()
        {
            // Arrange - add a user and login to the database
            User user = new User();
            Login login = new Login();

            GenealogyModelContainer db = new GenealogyModelContainer();

            user.userFirstName = "Ibee";
            user.userLastName = "Cookin";
            user.userEmail = "ibee.cookin@email.com";

            login.username = "Cookin4U";
            login.password = "1Password!";

            user.Login = login;        // because of the User/Login relationship

            db.Users.Add(user);

            // Act - save changes to the database
            db.SaveChanges();

            // Assert - verify that this user has been saved to the database
            User savedUser = (from d in db.Users where d.userId == user.userId select d).Single();
            Login savedLogin = (from d in db.Logins where d.loginId == login.loginId select d).Single();

            Assert.AreEqual(savedUser.userFirstName, user.userFirstName);
            Assert.AreEqual(savedUser.userLastName, user.userLastName);
            Assert.AreEqual(savedUser.userEmail, user.userEmail);

            Assert.AreEqual(savedLogin.username, login.username);
            Assert.AreEqual(savedLogin.password, login.password);

        } // end TestAddUser()

        //**********************************************************************
        // * Test methods to EDIT objects from the Genealogy database
        //**********************************************************************

        /*
         * Method TestEditPerson() to test whether an object Person can be edited 
         * from the repository
         */
        [TestMethod]
        public void TestEditPerson()
        {
            // Arrange - select a person for editing from the database
            int pId = 2;        // variable used for specific person location in database
            GenealogyModelContainer db = new GenealogyModelContainer();
            Person person = db.People.SingleOrDefault(p => p.personId == pId);

            person.firstName = "Mr. Big";   // assign a new name
            person.gender = "male";         // assign a new gender

            // Act - save changes to the database
            db.SaveChanges();

            // Assert - verify that this person has been saved to the database
            Person editedPerson = (from d in db.People where d.personId == pId select d).Single();

            Assert.AreEqual(editedPerson.firstName, person.firstName);
            Assert.AreEqual(editedPerson.lastName, "Kenson");
            Assert.AreEqual(editedPerson.givenName, "Schmo");
            Assert.AreEqual(editedPerson.gender, person.gender);
            Assert.AreEqual(editedPerson.birthDate, "January 21, 1980");
            Assert.AreEqual(editedPerson.birthPlace, "Lafayette");
            Assert.AreEqual(editedPerson.deathDate, "January 21, 2062");
            Assert.AreEqual(editedPerson.deathPlace, "Lafayette");
            Assert.AreEqual(editedPerson.occupation, "model");

        } // end TestEditPerson()

        /*
         * Method TestEditUser() to test whether an object User can be edited 
         * from the repository
         */
        [TestMethod]
        public void TestEditUser()
        {
            // Arrange - select a user for editing from the database
            int pId = 2;        // variable used for specific user ID location in database
            GenealogyModelContainer db = new GenealogyModelContainer();
            User user = db.Users.SingleOrDefault(p => p.userId == pId);
            Login login = db.Logins.SingleOrDefault(p => p.loginId == pId);

            user.userEmail = "CrazyCatLady@email.com";  // assign a new email
            login.password = "123Pass!";                // assign a new password

            // Act - save changes to the database
            db.SaveChanges();

            // Assert - verify that this user has been saved to the database
            User editedUser = (from d in db.Users where d.userId == pId select d).Single();
            Login editedLogin = (from d in db.Logins where d.loginId == pId select d).Single();

            Assert.AreEqual(editedUser.userFirstName, "Mary");
            Assert.AreEqual(editedUser.userLastName, "Lamb");
            Assert.AreEqual(editedUser.userEmail, user.userEmail);
            Assert.AreEqual(editedLogin.username, "mLamb");
            Assert.AreEqual(editedLogin.password, login.password);

        } // end TestEditUser()

        //**********************************************************************
        // * Test methods to DELETE objects from the Genealogy database
        //**********************************************************************

        /*
         * Method TestDeletePerson() to test whether an object Person can be deleted 
         * from the repository
         */
        [TestMethod]
        public void TestDeletePerson()
        {
            // Arrange - select a person for deletion from the database
            int pId = 3;       // variable used for specific person location in database
            GenealogyModelContainer db = new GenealogyModelContainer();
            Person person = db.People.SingleOrDefault(p => p.personId == pId);

            db.People.Remove(person);

            // Act - save changes to the database
            db.SaveChanges();

            // Assert

        } // end TestDeletePerson()

        /*
         * Method TestDeleteUser() to test whether an object User can be deleted 
         * from the repository
         */
        [TestMethod]
        public void TestDeleteUser()
        {
            // Arrange - select a user for deletion from the database
            int pId = 3;       // variable used for specific user location in database
            GenealogyModelContainer db = new GenealogyModelContainer();
            User user = db.Users.SingleOrDefault(p => p.userId == pId);
            Login login = db.Logins.SingleOrDefault(p => p.loginId == pId);

            db.Users.Remove(user);
            db.Logins.Remove(login);

            // Act - save changes to the database
            db.SaveChanges();

            // Assert

        } // end TestDeleteUser()

    } // end DomainUnitTests class

} // end DomainTest namespace
