/*******************************************************************************
 * Genealogy.Service.Factory
 * Manages the creation of other objects and instantiates service implementations
 * @author Kelly J Gimeno
 * @version 2
 * @date 06/03/2013
 *******************************************************************************/
using System;
using System.Configuration;         // Added for using the configuration file
using System.Collections.Specialized;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class Factory
    {
        /**
         * Singleton design pattern used to make sure that only one object
         * is instantiated at any time by hiding the default constructor
         * and providing a getInstance() method
         */
        public Factory() { }
        private static Factory factory = new Factory();
        public static Factory GetInstance() { return factory; }

        /*
         * GetService method used to instantiate all services
         */
        public IService GetService(string serviceName)
        {
            Type type;
            Object obj = null;

            try
            {
                // Used to look up the impl name in app.config
                type = Type.GetType(GetImplName(serviceName));

                // Used to dynamicaly instantiate the implementation classes
                obj = Activator.CreateInstance(type);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occured: {0}", e);
                throw e;
            }

            return (IService)obj;
        }

        /*
         * GetImplName method used to look up the imple name in app.config
         */
        private string GetImplName(string serviceName)
        {
            NameValueCollection settings = ConfigurationManager.AppSettings;
            return settings.Get(serviceName);
        }
       
    } // end Factory class

} // end Service namespace
