using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    class FatherNotFoundException : Exception
    {
        public FatherNotFoundException(string s) : base(s) 
        {
            throw new FatherNotFoundException("Father not valid");
        }
    }
}
