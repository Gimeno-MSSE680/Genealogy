/*****************************************************************************
 * Genealogy.Service.ILoginSvc
 * ILoginSvc authenticates, adds, edits, and deletes a login from the database
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
    public interface ILoginSvc : IService 
    {
        // Authenticate login stored in database
        Boolean authenticateLogin(Login login);

        // Adds login to the database
        void addLogin(Login login);

        // Edit login from the database
        void editLogin(Login login);

        // Deletes login from the database
        void deleteLogin(Login login);

    } // End ILoginSvc interface

} // End Service namespace