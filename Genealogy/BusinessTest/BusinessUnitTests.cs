/*
 * Genealogy.BusinessTest.BusinessUnitTests
 * BusinessUnitTests tests manager methods and whether they are capable of working
 * with with the flow of the application (business to service using the factory)
 * @author Kelly J Gimeno
 * @version 1
 * @date 06/08/2013
 */
using System;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Business;
using Domain;

namespace BusinessTest
{
    [TestClass]
    public class BusinessUnitTests
    {
        /*
         * Method PersonMgrTest() to test whether the manager class works
         * with the service class 
         */
        [TestMethod]
        public void PersonMgrTest()
        {
            // Arrange - variables for testing the manager
            Person person = new Person();
            PersonMgr personMgr = new PersonMgr();

            List list = new List();
            Father father = new Father();
            Mother mother = new Mother();

            person.firstName = "Round";
            person.lastName = "About";
            person.givenName = "Robin";
            person.gender = "male";
            person.birthDate = "January 2000";
            person.birthPlace = "Hollywood";
            person.deathDate = "December 3000";
            person.deathPlace = "Hollywood";
            person.occupation = "Shine";

            list.knownPersonQuantity = 1;
            list.unknownPersonQuantity = 0;

            father.fatherKnown = false;
            father.fFirstName = "";
            father.fLastName = "";
            father.fGivenName = "";

            mother.motherKnown = false;
            mother.mFirstName = "";
            mother.mLastName = "";
            mother.mGivenName = "";

            person.Lists = list;        // because of the Person/List relationship
            person.Fathers = father;    // because of the Person/Father relationship
            person.Mothers = mother;    // because of the Person/Mother relationship

            // Act and Assert - verify the PersonMgr is capable of calling on service methods
            personMgr.getPerson(person);
            personMgr.addPerson(person);
            personMgr.editPerson(person);
            personMgr.deletePerson(person);

        } // End PersonMgrTest()

        /*
         * Method FatherMgrTest() to test whether the manager class works
         * with the service class 
         */
        [TestMethod]
        public void FatherMgrTest()
        {
            // Arrange - variables for testing the managers
            Father father = new Father();
            FatherMgr fatherMgr = new FatherMgr();

            // Act and Assert - verify the FatherMgr is capable of calling on service methods
            fatherMgr.getFather(father);
            fatherMgr.addFather(father);
            fatherMgr.editFather(father);
            fatherMgr.deleteFather(father);

        } // End FatherMgrTest()

        /*
         * Method MotherMgrTest() to test whether the manager class works
         * with the service class 
         */
        [TestMethod]
        public void MotherMgrTest()
        {
            // Arrange - variables for testing the manager
            Mother mother = new Mother();
            MotherMgr motherMgr = new MotherMgr();

            // Act and Assert - verify the PersonMgr is capable of calling on service methods
            motherMgr.getMother(mother);
            motherMgr.addMother(mother);
            motherMgr.editMother(mother);
            motherMgr.deleteMother(mother);

        } // End MotherMgrTest()

        /*
         * Method UserMgrTest() to test whether the manager class works
         * with the service class 
         */
        [TestMethod]
        public void UserMgrTest()
        {
            // Arange - variables for testing the managers
            User user = new User();

            UserMgr userMgr = new UserMgr();

            // Act and Assert - verify the UserMgr is capable of calling on service methods
            userMgr.getUser(user);
            userMgr.addUser(user);
            userMgr.editUser(user);
            userMgr.deleteUser(user);

        } // End UserMgrTest()

        /*
         * Method LoginMgrTest() to test whether the manager class works
         * with the service class 
         */
        [TestMethod]
        public void LoginMgrTest()
        {
            // Arange - variables for testing the managers
            Login login = new Login();

            LoginMgr loginMgr = new LoginMgr();

            // Act and Assert - verify the UserMgr is capable of calling on service methods
            loginMgr.authenticateLogin(login);
            loginMgr.addLogin(login);
            loginMgr.editLogin(login);
            loginMgr.deleteLogin(login);

        } // End LoginMgrTest()

        /*
         * Method ListMgrTest() to test whether the manager class works
         * with the service class 
         */
        [TestMethod]
        public void ListMgrTest()
        {
            // Arange - variables for testing the managers
            List list = new List();

            ListMgr listMgr = new ListMgr();

            // Act and Assert - verify the ListMgr is capable of calling on service methods
            listMgr.getList(list);
            listMgr.editList(list);

        } // End ListMgrTest()

    } // End BusinessUnitTests class

} // End BusinessTest namespace
