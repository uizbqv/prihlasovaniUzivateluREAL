using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrihlasovaniUzivatelu
{
    internal class RegisteredUser
    {
        public string username { get; set; }
        public string password { get; set; }
        public DateTime registrationTime { get; set; }

        public double balance { get; set; } = 1000;


        public RegisteredUser(string username, string password, DateTime registrationTime, double balance)
        {
            this.username = username;
            this.password = password;
            this.registrationTime = registrationTime;
            this.balance = balance;
        }

    }
}
