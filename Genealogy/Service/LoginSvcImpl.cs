/*****************************************************************************
 * Genealogy.Service.LoginSvcImpl
 * Implementation of Login services
 * @author Kelly J Gimeno
 * @version 2
 * @date 06/20/2013
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
    public class LoginSvcImpl : ILoginSvc
    {
        public Boolean authenticateLogin(Login login)
        {
            try
            {
                Console.WriteLine("Entering method LoginSvcImpl::authenticateLogin");
                GenealogyModelContainer db = new GenealogyModelContainer();

                Boolean isAuthenticated = false;

                // Try/catch statement to search for user input username and password.  The catch statement allows the
                // application to output an error message to the user if the username and/or password is not found.
                // Otherwise, the FirstOrDefault method would throw an exception error if the username and password 
                // were not found within the database
                try
                {
                    Login savedLogin = (from d in db.Logins where d.username == login.username select d).FirstOrDefault();
              
                    if (Equals(savedLogin.username, login.username))
                    {
                        if (Equals(savedLogin.password, login.password))
                            isAuthenticated = true;
                    }
                }
                catch
                {
                    return isAuthenticated;
                }

                return isAuthenticated;
            }
            catch (LoginNotFoundException le)
            {
                Console.WriteLine("Exception occured: {0}", le);
                throw le;
            }

        } // End authenticateLogin(Login login)

        public void addLogin(Login login)
        {
            try
            {
                Console.WriteLine("Entering method LoginSvcImpl::addLogin");
            }
            catch (LoginNotFoundException le)
            {
                Console.WriteLine("Exception occured: {0}", le);
                throw le;
            }
        } // End addLogin(Login login)

        public void editLogin(Login login)
        {
            try
            {
                Console.WriteLine("Entering method LoginSvcImpl::editLogin");
            }
            catch (LoginNotFoundException le)
            {
                Console.WriteLine("Exception occured: {0}", le);
                throw le;
            }
        } // End editLogin(Login login)

        public void deleteLogin(Login login)
        {
            try
            {
                Console.WriteLine("Entering method LoginSvcImpl::deleteLogin");
            }
            catch (LoginNotFoundException le)
            {
                Console.WriteLine("Exception occured: {0}", le);
                throw le;
            }
        } // End deleteLogin(Login login)

    } // End LoginSvcImpl class

} // End Service namespace
