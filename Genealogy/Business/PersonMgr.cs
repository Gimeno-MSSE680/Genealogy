/*****************************************************************************
 * Genealogy.Business.PersonMgr
 * PersonMgr to manage the work flow of the services related to Person
 * @author Kelly J Gimeno
 * @version 1
 * @date 06/06/2013
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
                personSvc.getPerson(person);
                return person;
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
                personSvc.addPerson(person);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occured: {0}", e);
                throw e;
            }

        } // End addPerson(Person person)

        //} // End addPerson(Person person)

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

    } // End PersonMgr class

} // End Business namespace
