using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class LoginNotFoundException : Exception
    {
        public LoginNotFoundException(string s) : base(s) 
        {
            throw new LoginNotFoundException("username and/or password not valid");
        }
    }
}
