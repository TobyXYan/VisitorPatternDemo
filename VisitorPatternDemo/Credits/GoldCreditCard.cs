using VisitorPatternDemo.Visitors;

namespace VisitorPatternDemo.Credits
{
    class GoldCreditCard : ICreditCard
    {
        public void Accept(IOfferVisitor v)
        {
            v.VisitGoldCreditCard(this);
        }

        public string GetName()
        {
            throw new System.NotImplementedException();
        }
    }
}