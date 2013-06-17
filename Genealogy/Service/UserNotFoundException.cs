using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    class UserNotFoundException : Exception
    {
        public UserNotFoundException(string s) : base(s) 
        {
            throw new UserNotFoundException("User not valid");
        }
    }
}
