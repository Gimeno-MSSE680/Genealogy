/*****************************************************************************
 * Genealogy.Service.IService
 * IService interface used as a marker interface for the service interfaces
 * to inherit from allowing the Factory to be decoupled from its services
 * @author Kelly J Gimeno
 * @version 1
 * @date 06/03/2013
 *****************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    /**
     * Service IService interface is an empty interface to promote decoupling between
     * the Factory and the other service interfaces
     */
    public interface IService
    {
    }
}
