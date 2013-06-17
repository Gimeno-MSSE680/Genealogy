/*****************************************************************************
 * Genealogy.Business.Manager
 * Manager class used as a SuperType class to promote decoupling from the 
 * factory while still "getting services"
 * @author Kelly J Gimeno
 * @version 1
 * @date 06/12/2013
 *****************************************************************************/
using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service;
using Domain;

namespace Business
{
    public abstract class Manager   // abstract class to because it's never intended to be instantiated
    {
        private Factory factory = Factory.GetInstance();

        protected IService GetService(string name) // protected access because it is not to be used outside inheritance
        {
            return factory.GetService(name);
        }

    } // End Manager class

} // End Business namespace
