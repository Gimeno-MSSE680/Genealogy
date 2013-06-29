/*
 * Genealogy.ServiceTest.ServiceUnitTests
 * ServiceUnitTests tests implementation methods
 *      PersonSvcImplTest - tests Person implementation (getPerson, addPerson, editPerson, deletePerson)
 *      FatherSvcImplTest - tests Father implementation (getFather, addFather, editFather, deleteFather)
 *      MotherSvcImplTest - tests Mother implementation (getMother, addMother, editMother, deleteMother)
 *      ListSvcImplTest   - tests List implementation (getList, editList)
 *      UserSvcImplTest   - tests User implementation (getUser, addUser, editUser, deleteUser)
 *      LoginSvcImplTest  - tests Login implementation (authenticateLogin, addLogin, editLogin, deleteLogin)
 * @author Kelly J Gimeno
 * @version 1
 * @date 06/01/2013
 */
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Service;
using Domain;
using System.Data;
using System.Linq;

namespace ServiceTest
{
    [TestClass]
    public class ServiceUnitTests
    {
        /*
         * Method PersonSvcImplTest() to test whether the implementation of
         * person services work or not
         */
        [TestMethod]
        public void PersonSvcImplTest()
        {
            // Arrange - variables for testing the services
            Factory factory = new Factory();
            Person person = new Person();
            IPersonSvc personService;

            List list = new List();
            Father father = new Father();
            Mother mother = new Mother();

            person.firstName = "Fun";
            person.lastName = "Risers";
            person.givenName = "Risers";
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

            // Act - use GetPersonSvc method through the factory
            personService = (IPersonSvc)factory.GetService("IPersonSvc");

            // Assert - verify that the interface methods work through the factory 
            //          return of the implementation 
            personService.getPerson(person);
            personService.addPerson(person);
            personService.editPerson(person);
            personService.deletePerson(person);

        } // End PersonSvcImplTest()

        /*
         * Method FatherSvcImplTest() to test whether the implementation of
         * father services work or not
         */
        [TestMethod]
        public void FatherSvcImplTest()
        {
            // Arrange - variables for testing the services
            Factory factory = new Factory();
            Father father = new Father();
            IFatherSvc fatherSvc;

            // Act - use GetFatherSvc method through the factory
            fatherSvc = (IFatherSvc)factory.GetService("IFatherSvc");

            // Assert - verify that the interface methods work through the factory 
            //          return of the implementation 
            fatherSvc.getFather(father);
            fatherSvc.addFather(father);
            fatherSvc.editFather(father);
            fatherSvc.deleteFather(father);

        } // End FatherSvcImplTest()

        /*
         * Method MotherSvcImplTest() to test whether the implementation of
         * mother services work or not
         */
        [TestMethod]
        public void MotherSvcImplTest()
        {
            // Arrange - variables for testing the services
            Factory factory = new Factory();
            Mother mother = new Mother();
            IMotherSvc motherSvc;

            // Act - use GetMotherSvc method through the factory
            motherSvc = (IMotherSvc)factory.GetService("IMotherSvc");

            // Assert - verify that the interface methods work through the factory 
            //          return of the implementation 
            motherSvc.getMother(mother);
            motherSvc.addMother(mother);
            motherSvc.editMother(mother);
            motherSvc.deleteMother(mother);

        } // End MotherSvcImplTest()

        /*
         * Method ListSvcImplTest() to test whether the implementation of
         * list services work or not
         */
        [TestMethod]
        public void ListSvcImplTest()
        {
            // Arrange - variables for testing the services
            Factory factory = new Factory();
            List list = new List();
            IListSvc listSvc;

            // Act - use GetListSvc method through the factory
            listSvc = (IListSvc)factory.GetService("IListSvc");

            // Assert - verify that the interface methods work through the factory 
            //          return of the implementation 
            listSvc.getList(list);
            listSvc.editList(list);

        } // End ListSvcImplTest()

        /*
         * Method UserSvcImplTest() to test whether the implementation of
         * user services work or not
         */
        [TestMethod]
        public void UserSvcImplTest()
        {
            // Arrange - variables for testing the services
            Factory factory = new Factory();
            User user = new User();
            IUserSvc userSvc;

            // Act - use GetUserSvc method through the factory
            userSvc = (IUserSvc)factory.GetService("IUserSvc");

            // Assert - verify that the interface methods work through the factory 
            //          return of the implementation 
            userSvc.getUser(user);
            userSvc.addUser(user);
            userSvc.editUser(user);
            userSvc.deleteUser(user);

        } // End UserSvcImplTest()

        /*
         * Method LoginSvcImplTest() to test whether the implementation of
         * login services work or not
         */
        [TestMethod]
        public void LoginSvcImplTest()
        {
            // Arrange - variables for testing the services
            Factory factory = new Factory();
            Login login = new Login();
            ILoginSvc loginSvc;

            // Act - use GetLoginSvc method through the factory
            loginSvc = (ILoginSvc)factory.GetService("ILoginSvc");

            // Assert - verify that the interface methods work through the factory 
            //          return of the implementation 
            loginSvc.authenticateLogin(login);
            loginSvc.addLogin(login);
            loginSvc.editLogin(login);
            loginSvc.deleteLogin(login);

        } // End LoginSvcImplTest()

    } // End ServiceUnitTests class

} // End ServiceTest namespace
