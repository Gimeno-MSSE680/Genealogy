using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    class MotherNotFoundException : Exception
    {
        public MotherNotFoundException(string s) : base(s) 
        {
            throw new MotherNotFoundException("Mother not valid");
        }
    }
}