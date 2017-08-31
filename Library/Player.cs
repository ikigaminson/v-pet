using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Player
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string Mail { get; set; }
        public string User { get; set; }

        public Player()
        {
            this.Init();
        }

        public Player(string name, string password, string mail, string user)
        {
            Name = name;
            Password = password;
            Mail = mail;
            User = user;
        }

        private void Init()
        {
            Name = string.Empty;
            Password = string.Empty;
            Mail = string.Empty;
            User = string.Empty;
        }
    }
}
