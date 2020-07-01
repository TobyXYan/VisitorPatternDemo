using VisitorPatternDemo.Visitors;

namespace VisitorPatternDemo.Credits
{
    class SilverCreditCard : ICreditCard
    {
        public void Accept(IOfferVisitor v)
        {
            v.VisitSilverCreditCard(this);
        }

        public string GetName()
        {
            return "Silver";
        }
    }
}
