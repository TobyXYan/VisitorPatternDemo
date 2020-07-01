using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPatternDemo.SingleDoubleDispatchExample
{
    class Cat : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Meow");
        }

        public void MakeSound(Dog d)
        {
            Console.WriteLine("Cat interacting with a dog");
        }

        public void MakeSound(Cat c)
        {
            Console.WriteLine("Cat interacting with a dog");
        }

        public void MakeSound(IAnimal a)
        {
            Console.WriteLine("Cat interacting with an animal");
        }
    }
}
