using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrailGuard
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public List<string> Modes { get; set; }

        public User(string username, string password, List<string> modes)
        {
            Username = username;
            Password = password;
            Modes = modes;
        }
    }
}
