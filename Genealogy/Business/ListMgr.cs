/*****************************************************************************
 * Genealogy.Business.ListMgr
 * ListMgr to manage the work flow of the services related to List
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
    public class ListMgr : Manager
    {
        public List getList(List list)
        {
            try
            {
                IListSvc listSvc = (IListSvc)GetService(typeof(IListSvc).Name);
                listSvc.getList(list);
                return list;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occured: {0}", e);
                throw e;
            }

        } // End getList(List list)

        public void editList(List list)
        {
            try
            {
                IListSvc listSvc = (IListSvc)GetService(typeof(IListSvc).Name);
                listSvc.editList(list);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occured: {0}", e);
                throw e;
            }

        } // End editList(List list)

    } // End ListMgr class

} // End Business namespace
