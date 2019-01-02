using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Account
    {
        string username, password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        int type;

        public int Type
        {
            get { return type; }
            set { type = value; }
        }

        public Account(string username, string password, int type)
        {
            Username = username;
            Password = password;
            Type = type;
        }
    }
}
