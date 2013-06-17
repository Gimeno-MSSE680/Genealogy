/*****************************************************************************
 * Genealogy.Service.IListSvc
 * IListSvc gets and edits a list from the database
 * @author Kelly J Gimeno
 * @version 1
 * @date 05/30/2013
 *****************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Service
{
    public interface IListSvc : IService 
    {
        // Returns the list that is retireved form the database
        List getList(List list);

        // Edit list from the database
        void editList(List list);

    } // End IListSvc interface

} // End Service namespace