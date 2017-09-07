using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class VPet
    {
        public Player Player { get; set; }
        public Pet Pet { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Food { get; set; }
        public int Poop { get; set; }
        public int Ex { get; set; }
        public DateTime Date { get; set; }
        public typeHabillity PetHabillity { get; set; }

        public VPet()
        {
            this.Init();
        }

        private void Init()
        {
            Player = new Player();
            Pet = new Pet();
            Name = string.Empty;
            Age = 0;
            Food = 0;
            Poop = 0;
            Ex = 0;
            Date = new DateTime();
            PetHabillity = (typeHabillity)1;
        }

        /*public VPet(Player player, Pet pet, string name, int age, int food, int health, int poop, DateTime date, typeHabillity petHabillity)
        {
            Player = player;
            Pet = pet;
            Name = name;
            Age = age;
            Food = food;
            Poop = poop;
            Ex = 0;
            Date = date;
            PetHabillity = petHabillity;
        }*/

        // Recived Damage
        public int dañoCausado(int enemyDamage)
        {
            return enemyDamage - Pet.Defense;
        }

        // Update HP after battle
        public void vidaPostDaño(int enemyDamage)
        {
            Pet.Health = Pet.Health - dañoCausado(enemyDamage);
        }

        // solicitar comida
        public string tengoHambre()
        {
            string hambre = "";
            if (Food < 2)
            {
                hambre = " porfavor dame comida :c";
            }
            else
            {
                hambre = " guatita llena corazon contento :3";
            }
            return hambre;
        } 

        // cuando esta a punto hacerse popo
        public string poopIncoming()
        {
            string poops = "";
            if (Poop <= 0)
            {
                poops = " necesito baño :c";
            }
            else
            {
                poops = "  estoy bien c:";
            }
            return poops;
        }

        //  metodo para que se muera (?) o no se llama 
        // Se implementa en  ¿web?

        // If have enought points, ev = true and make the evolution
        public bool statusEvolution()
        {
            bool ev = false;
            if (Pet.EvPoint == Ex)
                ev = true;
            return ev;
        }
    }
}
