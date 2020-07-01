using System;
using VisitorPatternDemo.Credits;
using VisitorPatternDemo.SingleDoubleDispatchExample;
using VisitorPatternDemo.Visitors;

namespace VisitorPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //IAnimal dog = new Dog();
            //IAnimal cat = new Cat();
            //dog.MakeSound(cat);


            IOfferVisitor visitor = new HotelOfferVisitor();
            IOfferVisitor visitor2 = new GasOfferVisitor();

            ICreditCard bronze = new BronzeCreditCard();
            ICreditCard silver = new SilverCreditCard();
            ICreditCard gold   = new GoldCreditCard();
            bronze.Accept(visitor2);
            silver.Accept(visitor2);
            gold.Accept(visitor2);

            Console.ReadLine();
        }
    }
}
