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

                // int variable used so that each member of the database table is checked and no more.
                // Without this, I get an exception error because the query is searching beyond the list
                int sizeOfList = db.Logins.Count();

                int loginSearchCount = 1;
                int checkLoginId = 1;

                while (loginSearchCount <= sizeOfList)
                {
                    Login savedLogin = (from d in db.Logins where d.loginId == checkLoginId select d).Single();

                    if (savedLogin.username == login.username && savedLogin.password == login.password)
                    {
                        isAuthenticated = true;
                        loginSearchCount = sizeOfList + 1;
                    }
                    else if (savedLogin.username != login.username || savedLogin.password != login.password)
                    {
                        isAuthenticated = false;
                        loginSearchCount++;
                        checkLoginId++;
                    }
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
