using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Model
{
    internal class User
    {
        public int id { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public override string ToString() { return string.Format("id: {0}\nemail: {1}\npassword: {2}", id, email, password); }

    }
}
