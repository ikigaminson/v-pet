using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Player
    {
        public string User { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Mail { get; set; }


        public Player()
        {
            this.Init();
        }

        private void Init()
        {
            User = string.Empty;
            Name = string.Empty;
            Password = string.Empty;
            Mail = string.Empty;

        }
    }
}
