using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class ColeccionPet
    {
        public Pet PetData { get; set; }
        public Player PlayerData { get; set; }

        public ColeccionPet()
        {
            PetData = new Pet();
            PlayerData = new Player();
        }
    }
}
