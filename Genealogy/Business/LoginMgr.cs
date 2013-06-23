/*****************************************************************************
 * Genealogy.Business.LoginMgr
 * LoginMgr to manage the work flow of the services related to Login
 * @author Kelly J Gimeno
 * @version 2
 * @date 06/20/2013
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
    public class LoginMgr : Manager
    {
        public Boolean authenticateLogin(Login login)
        {
            try
            {
                ILoginSvc loginSvc = (ILoginSvc)GetService(typeof(ILoginSvc).Name);
                Boolean loginSuccess = loginSvc.authenticateLogin(login);

                return Convert.ToBoolean(loginSuccess);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occured: {0}", e);
                throw e;
            }
        
        } // End authenticateLogin(Login login)

        public void addLogin(Login login)
        {
            try
            {
                ILoginSvc loginSvc = (ILoginSvc)GetService(typeof(ILoginSvc).Name);
                loginSvc.addLogin(login);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occured: {0}", e);
                throw e;
            }

        } // End addLogin(Login login)

        public void editLogin(Login login)
        {
            try
            {
                ILoginSvc loginSvc = (ILoginSvc)GetService(typeof(ILoginSvc).Name);
                loginSvc.editLogin(login);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occured: {0}", e);
                throw e;
            }

        } // End editUser(User user, Login login)

        public void deleteLogin(Login login)
        {
            try
            {
                ILoginSvc loginSvc = (ILoginSvc)GetService(typeof(ILoginSvc).Name);
                loginSvc.deleteLogin(login);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occured: {0}", e);
                throw e;
            }
        }
    }
}
