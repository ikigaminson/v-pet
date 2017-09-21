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
        public int Food { get; set; }
        public int Poop { get; set; }
        public DateTime Date { get; set; }
        private int _age;

        public int Age
        {
            get { return GenerarEdad(); }
            set { _age = value; }
        }

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

        private int GenerarEdad()
        {
            TimeSpan t = DateTime.Now - Date;
            return t.Days;
        }
    }
}
