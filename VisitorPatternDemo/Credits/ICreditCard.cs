using VisitorPatternDemo.Visitors;

namespace VisitorPatternDemo.Credits
{
    interface ICreditCard
    {
        string GetName();
        void Accept(IOfferVisitor v);
    }
}
