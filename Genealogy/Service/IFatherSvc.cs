/*****************************************************************************
 * Genealogy.Service.IFatherSvc
 * IFatherSvc gets, adds, edits, and deletes a father from the database
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
    public interface IFatherSvc : IService 
    {
        // Returns the father that is retrieved from the database
        Father getFather(Father father);

        // Add father to the database
        void addFather(Father father);

        // Edit father to the database
        void editFather(Father father);

        // Delete father to the database
        void deleteFather(Father father);

    } // End IFatherSvc interface

} // End Service namespace