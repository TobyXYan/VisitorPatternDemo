using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPatternDemo.SingleDoubleDispatchExample
{
    class Dog:IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Bark");
        }

        public void MakeSound(Dog d)
        {
            Console.WriteLine("Dog interacting with a dog");
        }

        public void MakeSound(Cat c)
        {
            Console.WriteLine("Dog interacting with a cat");
        }
        public void MakeSound(IAnimal a)
        {
            Console.WriteLine("Dog interacting with an animal");
        }
    }
}
