using System;
using System.Collections.Generic;
using System.Text;
using VisitorPatternDemo.Credits;

namespace VisitorPatternDemo.Visitors
{
    class GasOfferVisitor : IOfferVisitor
    {
        public void VisitBronzeCreditCard(BronzeCreditCard bronze)
        {
            Console.WriteLine("We are computing the cash back for a bronze card buying gas");
        }

        public void VisitGoldCreditCard(GoldCreditCard bronze)
        {
            Console.WriteLine("We are computing the cash back for a gold card buying gas");
        }

        public void VisitSilverCreditCard(SilverCreditCard bronze)
        {
            Console.WriteLine("We are computing the cash back for a silver card buying gas");
        }
    }
}
