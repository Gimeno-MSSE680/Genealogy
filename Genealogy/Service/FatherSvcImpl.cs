/*****************************************************************************
 * Genealogy.Service.FatherSvcImpl
 * Implementation of Father services
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
    public class FatherSvcImpl : IFatherSvc
    {
        public Father getFather(Father father)
        {
            try
            {
                Console.WriteLine("Entering method FatherSvcImpl::getFather");
                return new Father();
            }
            catch (FatherNotFoundException fe)
            {
                Console.WriteLine("Exception occured: {0}", fe);
                throw fe;
            }
        } // End getFather(Father father)

        public void addFather(Father father)
        { 
            try
            {
                Console.WriteLine("Entering method FatherSvcImpl::addFather"); 
            }
            catch (FatherNotFoundException fe)
            {
                Console.WriteLine("Exception occured: {0}", fe);
                throw fe;
            }
        } // End addFather(Father father)

        public void editFather(Father father)
        { 
            try
            {
                Console.WriteLine("Entering method FatherSvcImpl::editFather"); 
            }
            catch (FatherNotFoundException fe)
            {
                Console.WriteLine("Exception occured: {0}", fe);
                throw fe;
            }
        } // End editFather(Father father)

        public void deleteFather(Father father)
        { 
            try
            {
                Console.WriteLine("Entering method FatherSvcImpl::deleteFather"); 
            }
            catch (FatherNotFoundException fe)
            {
                Console.WriteLine("Exception occured: {0}", fe);
                throw fe;
            }
        } // End deleteFather(Father father)

    } // End FatherSvcImpl class

} // End Service namespace
