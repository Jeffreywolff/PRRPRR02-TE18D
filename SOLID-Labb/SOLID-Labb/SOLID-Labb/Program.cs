using System;

namespace SOLID_Labb
{
    class Program
    {
        static void Main(string[] args)
        {

            Animal[] animals = {new Dog("Black"),
                            new Hedgehog("Pink"),
                            new Bird("Yellow")};

            var owner = new Owner();

            Console.WriteLine("###############");
            Console.WriteLine();

            owner._name = "Niklas";
            foreach (var animal in animals)
            {
                if (animal is Dog dog)
                {

                    dog.speakingPhrase = "Dog is eating. " + owner._name + " is happy!";

                }

                animal.Eat();
                animal.Sleep();
                animal.Speak();
                if (animal._color == "")
                {
                    animal._color = "Grey";
                }
                Console.WriteLine(animal.GetType().Name + " is " + animal._color);
                Console.WriteLine();

                Console.WriteLine("###############");
                Console.WriteLine();
            }
        }
    }
}
