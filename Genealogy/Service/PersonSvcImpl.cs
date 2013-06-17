/*****************************************************************************
 * Genealogy.Service.PersonSvcImpl
 * Implementation of Person services
 * @author Kelly J Gimeno
 * @version 1
 * @date 05/29/2013
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
                return person;
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

    } // End PersonSvcImpl class

} // End Service namespace
