/*****************************************************************************
 * Genealogy.Service.IUserSvc
 * IUserSvc gets, adds, edits, and deletes a user from the database
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
    public interface IUserSvc : IService 
    {
        // Returns the user that is retrieved from the database
        User getUser(User user);

        // Adds user to the database
        void addUser(User user);

        // Edit user from the database
        void editUser(User user);

        // Deletes user from the database
        void deleteUser(User user);

    } // End IUserSvc interface

} // End Service namespace