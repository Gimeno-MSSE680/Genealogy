/*****************************************************************************
 * Genealogy.Service.UserSvcImpl
 * Implementation of User services
 * @author Kelly J Gimeno
 * @version 1
 * @date 05/30/2013
 *****************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Soap;
using Domain;

namespace Service
{
    public class UserSvcImpl : IUserSvc
    {
        public User getUser(User user)
        {
            try
            {
                Console.WriteLine("Entering method UserSvcImpl::getUser");
                return new User();
            }
            catch (UserNotFoundException ue)
            {
                Console.WriteLine("Exception occured: {0}", ue);
                throw ue;
            }
        } // End getUser(User user)

        public void addUser(User user)
        {
            try
            {
                Console.WriteLine("Entering method UserSvcImpl::addUser");
            }
            catch (UserNotFoundException ue)
            {
                Console.WriteLine("Exception occured: {0}", ue);
                throw ue;
            }
        } // End addUser(User user)


        public void editUser(User user)
        {
            try
            {
                Console.WriteLine("Entering method UserSvcImpl::editUser");
            }
            catch (UserNotFoundException ue)
            {
                Console.WriteLine("Exception occured: {0}", ue);
                throw ue;
            }
        } // End editUser(User user)

        public void deleteUser(User user)
        {
            try
            {
                Console.WriteLine("Entering method UserSvcImpl::deleteUser");
            }
            catch (UserNotFoundException ue)
            {
                Console.WriteLine("Exception occured: {0}", ue);
                throw ue;
            }
        }  // End deleteUser(User user)

    } // End UserSvcImpl class

} // End Service namespace