/*****************************************************************************
 * Genealogy.Service.PersonSvcImpl
 * Implementation of Person services
 * @author Kelly J Gimeno
 * @version 2
 * @date 06/22/2013
 *****************************************************************************/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Soap;
using Domain;

namespace Service
{
    public class PersonSvcImpl : IPersonSvc
    {
        public Person getPerson(Person person)
        {
            try
            {
                Console.WriteLine("Entering method PersonSvcImpl::getPerson");
                GenealogyModelContainer db = new GenealogyModelContainer();

                // Currently pulls the person stored in 4th index in the database table
                Person savedPerson = (from d in db.People where d.personId == 4 select d).Single();

                return savedPerson;
            }
            catch (PersonNotFoundException pe)
            {
                Console.WriteLine("Exception occured: {0}", pe);
                throw pe;
            }
        } // End getPerson(Person person)

        public void addPerson(Person person)
        {
            try
            {
                Console.WriteLine("Entering method PersonSvcImpl::addPerson");
                GenealogyModelContainer db = new GenealogyModelContainer();
                db.People.Add(person);
                db.SaveChanges();
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
                Console.WriteLine("Entering method PersonSvcImpl::editPerson");
            }
            catch (PersonNotFoundException pe)
            {
                Console.WriteLine("Exception occured: {0}", pe);
                throw pe;
            }
        } // End editPerson(Person person)

        public void deletePerson(Person person)
        {
            try
            {
                Console.WriteLine("Entering method PersonSvcImpl::deletePerson");
            }
            catch (PersonNotFoundException pe)
            {
                Console.WriteLine("Exception occured: {0}", pe);
                throw pe;
            }
        } // End deletePerson(Person person)

        /*
         * GetFamily() gets all people currently stored in the People database table
         */
        public IEnumerable<Person> GetFamily()
        {
            Console.WriteLine("Entering method PersonSvcImpl::getFamily");
            GenealogyModelContainer db = new GenealogyModelContainer();
            List<Person> savedPerson = (from d in db.People select d).ToList();

            IOrderedQueryable<Person> lastNameQuery = (from person in db.People orderby person.lastName select person);

            return lastNameQuery;
        } // End GetFamily()

    } // End PersonSvcImpl class

} // End Service namespace
