using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPatternDemo.SingleDoubleDispatchExample
{
    interface IAnimal
    {
        void MakeSound();
        void MakeSound(Dog d);
        void MakeSound(Cat c);
        void MakeSound(IAnimal a);
    }
}
