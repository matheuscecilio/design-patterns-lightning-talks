using design_patterns_lightning_talks.Behaviorals.Strategy.Shipping.Solution.Interfaces;

namespace design_patterns_lightning_talks.Behaviorals.Strategy.Shipping.Solution.Entities
{
    public class EletronicOrder : Order
    {
        public EletronicOrder(IShipping shipping) : base("Eletronic Order", shipping) 
        { }
    }
}

