using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Labb
{
    class Owner
    {

        public Owner()
        {
            _animals = new List<Animal>();
        }

        public string _name { get; set; }
        private List<Animal> _animals;

        public List<Animal> Animals
        {
            get { return _animals; }
        }

        public void AddAnimal(Animal animal)
        {
            _animals.Add(animal);
        }
    }
}
