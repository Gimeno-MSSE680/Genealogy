/*****************************************************************************
 * Genealogy.Business.UserMgr
 * UserMgr to manage the work flow of the services related to User
 * @author Kelly J Gimeno
 * @version 1
 * @date 06/06/2013
 *****************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service;
using Domain;

namespace Business
{
    public class UserMgr : Manager
    {
        public User getUser(User user)
        {
            try
            {
                IUserSvc userSvc = (IUserSvc)GetService(typeof(IUserSvc).Name);
                userSvc.getUser(user);
                return user;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occured: {0}", e);
                throw e;
            }

        } // End getUser(User user)

        public void addUser(User user, Login login)
        {
            try
            {
                IUserSvc userSvc = (IUserSvc)GetService(typeof(IUserSvc).Name);
                userSvc.addUser(user);
                ILoginSvc loginSvc = (ILoginSvc)GetService(typeof(ILoginSvc).Name);
                loginSvc.addLogin(login);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occured: {0}", e);
                throw e;
            }

        } // End addUser(User user, Login login)

        public void editUser(User user, Login login)
        {
            try
            {
                IUserSvc userSvc = (IUserSvc)GetService(typeof(IUserSvc).Name);
                userSvc.editUser(user);
                ILoginSvc loginSvc = (ILoginSvc)GetService(typeof(ILoginSvc).Name);
                loginSvc.editLogin(login);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occured: {0}", e);
                throw e;
            }

        } // End editUser(User user, Login login)

        public void deleteUser(User user, Login login)
        {
            try
            {
                IUserSvc userSvc = (IUserSvc)GetService(typeof(IUserSvc).Name);
                userSvc.deleteUser(user);
                ILoginSvc loginSvc = (ILoginSvc)GetService(typeof(ILoginSvc).Name);
                loginSvc.deleteLogin(login);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occured: {0}", e);
                throw e;
            }

        } // End deleteUser(User user, Login login)

        public Login authenticateLogin(Login login)
        {
            try
            {
                ILoginSvc loginSvc = (ILoginSvc)GetService(typeof(ILoginSvc).Name);
                loginSvc.authenticateLogin(login);
                return login;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occured: {0}", e);
                throw e;
            }

        } // End authenticateLogin(Login login)

    } // End UserMgr class

} // End Business namespace
