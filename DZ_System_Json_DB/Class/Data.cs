using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cient.Class
{
    internal class Data
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Registration { get; set; }
        public Data( string _email, string _password, bool _registration)
        {
            Email = _email;
            Password = _password;
            Registration = _registration;
        }
    }
}
