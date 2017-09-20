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
        public int Age { get; set; }
        public int Food { get; set; }
        public int Poop { get; set; }
        public DateTime Date { get; set; }

        public Pet()
        {
            this.Init();
        }

        private void Init()
        {
            PetType = typePet.data;
            Name = string.Empty;
            Age = 0;
            Food = 0;
            Poop = 0;
            Date = new DateTime(1990,01,01);
        }

        public void FoodStatus()
        {
            Food++;            
        }

        // cuando esta a punto hacerse popo
        public void PoopIncoming()
        {
            Poop++;
        }
    }
}
