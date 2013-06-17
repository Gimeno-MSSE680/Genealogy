using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    class ListException : Exception
    {
        public ListException(string s) : base(s) 
        {
            throw new ListException("List count not valid");
        }
    }
}
