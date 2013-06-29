/*****************************************************************************
 * Genealogy.Business.FatherMgr
 * FatherMgr to manage the work flow of the services related to Father
 * @author Kelly J Gimeno
 * @version 2
 * @date 06/20/2013
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
    public class FatherMgr : Manager
    {
        public Father getFather(Father father)
        {
            try
            {
                IFatherSvc fatherSvc = (IFatherSvc)GetService(typeof(IFatherSvc).Name);
                fatherSvc.getFather(father);
                return father;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occured: {0}", e);
                throw e;
            }

        } // End getFather(Father father)

        public void addFather(Father father)
        {
            try
            {
                IFatherSvc fatherSvc = (IFatherSvc)GetService(typeof(IFatherSvc).Name);
                fatherSvc.addFather(father);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occured: {0}", e);
                throw e;
            }

        } // End addFather(Father father)

        public void editFather(Father father)
        {
            try
            {
                IFatherSvc fatherSvc = (IFatherSvc)GetService(typeof(IFatherSvc).Name);
                fatherSvc.editFather(father);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occured: {0}", e);
                throw e;
            }

        } // End editFather(Father father)

        public void deleteFather(Father father)
        {
            try
            {
                IFatherSvc fatherSvc = (IFatherSvc)GetService(typeof(IFatherSvc).Name);
                fatherSvc.deleteFather(father);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occured: {0}", e);
                throw e;
            }

        } // End deleteFather(Father father)

    } // End FatherMgr class

} // End Business namespace
