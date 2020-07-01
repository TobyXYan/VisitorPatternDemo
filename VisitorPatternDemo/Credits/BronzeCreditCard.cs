using VisitorPatternDemo.Visitors;

namespace VisitorPatternDemo.Credits
{
    class BronzeCreditCard : ICreditCard
    {
        public void Accept(IOfferVisitor v)
        {
            v.VisitBronzeCreditCard(this);
        }

        public string GetName()
        {
            throw new System.NotImplementedException();
        }
    }
}