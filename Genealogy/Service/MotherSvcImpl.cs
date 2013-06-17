/*****************************************************************************
 * Genealogy.Service.MotherSvcImpl
 * Implementation of Mother services
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
    public class MotherSvcImpl : IMotherSvc
    {
        public Mother getMother(Mother mother)
        {
            try
            {
                Console.WriteLine("Entering method MotherSvcImpl::getMother");
                return new Mother();
            }
            catch (MotherNotFoundException me)
            {
                Console.WriteLine("Exception occured: {0}", me);
                throw me;
            }
        } // End getMother(Mother mother)

        public void addMother(Mother mother)
        {
            try
            {
                Console.WriteLine("Entering method MotherSvcImpl::addMother");
            }
            catch (MotherNotFoundException me)
            {
                Console.WriteLine("Exception occured: {0}", me);
                throw me;
            }
        } // End addMother(Mother mother)

        public void editMother(Mother mother)
        {
            try
            {
                Console.WriteLine("Entering method MotherSvcImpl::editMother");
            }
            catch (MotherNotFoundException me)
            {
                Console.WriteLine("Exception occured: {0}", me);
                throw me;
            }
        } // End editMother(Mother mother)

        public void deleteMother(Mother mother)
        {
            try
            {
                Console.WriteLine("Entering method MotherSvcImpl::deleteMother");
            }
            catch (MotherNotFoundException me)
            {
                Console.WriteLine("Exception occured: {0}", me);
                throw me;
            }
        }  // End deleteMother(Mother mother)

    } // End MotherSvcImpl class

} // End Service namespace
