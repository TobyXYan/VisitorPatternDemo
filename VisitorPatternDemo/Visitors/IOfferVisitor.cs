using System;
using System.Collections.Generic;
using System.Text;
using VisitorPatternDemo.Credits;

namespace VisitorPatternDemo.Visitors
{
    interface IOfferVisitor
    {
        void VisitBronzeCreditCard(BronzeCreditCard bronze);
        void VisitSilverCreditCard(SilverCreditCard bronze);
        void VisitGoldCreditCard(GoldCreditCard bronze);
    }
}
