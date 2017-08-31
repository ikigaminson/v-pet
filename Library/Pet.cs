using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Pet
    {
        public typePet PetType { get; set; }
        public string Name { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Health { get; set; }
        public int EvPoint { get; set; }

        public Pet(typePet petType, string name, int attack, int defense, int evPoint, int health)
        {
            PetType = petType;
            Name = name;
            Attack = attack;
            Defense = defense;
            Health = health;
            EvPoint = evPoint;
        }

        public Pet()
        {
            this.Init();
        }

        private void Init()
        {
            PetType = (typePet)1;
            Name = string.Empty;
            Attack = 0;
            Health = 0;
            Defense = 0;
            EvPoint = 0;
        }
    }
}
