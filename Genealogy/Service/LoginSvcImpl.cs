/*****************************************************************************
 * Genealogy.Service.LoginSvcImpl
 * Implementation of Login services
 * @author Kelly J Gimeno
 * @version 1
 * @date 05/31/2013
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
                return new Boolean();
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
