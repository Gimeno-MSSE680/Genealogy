/*****************************************************************************
 * Genealogy.Service.IPersonSvc
 * IPersonSvc gets, adds, edits, and deletes a person from the database
 * @author Kelly J Gimeno
 * @version 1
 * @date 05/29/2013
 *****************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Service
{
    public interface IPersonSvc : IService
    {
        // Returns the person that is retrieved from the database
        Person getPerson(Person person);

        // Adds person to the database
        void addPerson(Person person);

        // Edit person from the database
        void editPerson(Person person);

        // Deletes person from the database
        void deletePerson(Person person);

    } // End IPersonSvc interface

} // End Service namespace
