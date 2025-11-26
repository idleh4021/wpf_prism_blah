using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpf_blah.Services
{
    internal class AuthService : IAuthService
    {
        public bool Login(string username, string password)
        {
            return username == "1" && password == "1";
        }
    }
}
