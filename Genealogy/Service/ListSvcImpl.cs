/*****************************************************************************
 * Genealogy.Service.ListSvcImpl
 * Implementation of List services
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
    public class ListSvcImpl : IListSvc
    {
        public List getList(List list)
        {
            try
            {
                Console.WriteLine("Entering method ListSvcImpl::getList");
                return new List();
            }
            catch (ListException le)
            {
                Console.WriteLine("Exception occured: {0}", le);
                throw le;
            }
        } // End getList(List list)

        public void editList(List list)
        {
            try
            {
                Console.WriteLine("Entering method ListSvcImpl::editList");
                list.knownPersonQuantity++;
            }
           
            catch (ListException le)
            {
                Console.WriteLine("Exception occured: {0}", le);
                throw le;
            }
        } // End editList(List list)

    } // End ListSvcImpl

} // End Service namespace