using design_patterns_lightning_talks.Behaviorals.Strategy.Shipping.Solution.Interfaces;

namespace design_patterns_lightning_talks.Behaviorals.Strategy.Shipping.Solution.Entities
{
    public class FurnitureOrder : Order
    {
        public FurnitureOrder(IShipping shipping) : base("Furniture Order", shipping)
        { }
    }
}
