/*****************************************************************************
 * Genealogy.Business.PersonMgr
 * PersonMgr to manage the work flow of the services related to Person
 * @author Kelly J Gimeno
 * @version 2
 * @date 06/20/2013
 *****************************************************************************/
using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service;
using Domain;

namespace Business
{
    public class PersonMgr : Manager
    {
        public Person getPerson(Person person)
        {
            try
            {
                IPersonSvc personSvc = (IPersonSvc)GetService(typeof(IPersonSvc).Name);
                Person personInfo = personSvc.getPerson(person);
                return personInfo;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occured: {0}", e);
                throw e;
            }

        } // End getPerson(Person person)

        public void addPerson(Person person)
        {
            try
            {
                IPersonSvc personSvc = (IPersonSvc)GetService(typeof(IPersonSvc).Name);
                
                if (person.firstName == "" && person.lastName == "")
                {
                    person.firstName = "Person";
                    person.lastName = "Unknown";
                }

                personSvc.addPerson(person);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occured: {0}", e);
                throw e;
            }

        } // End addPerson(Person person)

        public void editPerson(Person person)
        {
            try
            {
                IPersonSvc personSvc = (IPersonSvc)GetService(typeof(IPersonSvc).Name);
                personSvc.editPerson(person);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occured: {0}", e);
                throw e;
            }

        } // End editPerson(Person person)

        public void deletePerson(Person person)
        {
            try
            {
                IPersonSvc personSvc = (IPersonSvc)GetService(typeof(IPersonSvc).Name);
                personSvc.deletePerson(person);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occured: {0}", e);
                throw e;
            }

        } // End deletePerson(Person person)

        public IEnumerable<Person> GetFamily()
        {
            try
            {
                IPersonSvc personSvc = (IPersonSvc)GetService(typeof(IPersonSvc).Name);
                return personSvc.GetFamily();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occured: {0}", e);
                throw e;
            }
        } // End IEnumerable<Person> GetFamily()

    } // End PersonMgr class

} // End Business namespace
