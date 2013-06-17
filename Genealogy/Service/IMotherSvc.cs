/*****************************************************************************
 * Genealogy.Service.IMotherSvc
 * IMotherSvc gets, adds, edits, and deletes a mother from the database
 * @author Kelly J Gimeno
 * @version 1
 * @date 05/30/2013
 *****************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Service
{
    public interface IMotherSvc : IService 
    {
        // Returns the mother that is retrieved from the database
        Mother getMother(Mother mother);

        // Add mother to the database
        void addMother(Mother mother);

        // Edit mother to the database
        void editMother(Mother mother);

        // Delete mother to the database
        void deleteMother(Mother mother);

    } // End IMotherSvc interface

} // End Service namespace