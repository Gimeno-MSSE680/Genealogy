using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Service;

namespace Business
{
    public class MotherMgr : Manager
    {
        public Mother getMother(Mother mother)
        {
            try
            {
                IMotherSvc motherSvc = (IMotherSvc)GetService(typeof(IMotherSvc).Name);
                motherSvc.getMother(mother);
                return mother;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occured: {0}", e);
                throw e;
            }

        } // End getMother(Mother mother)

        public void addMother(Mother mother)
        {
            try
            {
                IMotherSvc motherSvc = (IMotherSvc)GetService(typeof(IMotherSvc).Name);
                motherSvc.addMother(mother);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occured: {0}", e);
                throw e;
            }

        } // End addMother(Mother mother)

        public void editMother(Mother mother)
        {
            try
            {
                IMotherSvc motherSvc = (IMotherSvc)GetService(typeof(IMotherSvc).Name);
                motherSvc.editMother(mother);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occured: {0}", e);
                throw e;
            }

        } // End editMother(Mother mother)

        public void deleteMother(Mother mother)
        {
            try
            {
                IMotherSvc motherSvc = (IMotherSvc)GetService(typeof(IMotherSvc).Name);
                motherSvc.deleteMother(mother);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occured: {0}", e);
                throw e;
            }

        } // End deleteMother(Mother mother)

    } // End MotherMgr class

} // End Business namespace
