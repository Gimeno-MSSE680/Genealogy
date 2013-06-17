using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    class PersonNotFoundException : Exception
    {
        public PersonNotFoundException(string s) : base(s) 
        {
            throw new PersonNotFoundException("Person not valid");
        }
    }
}