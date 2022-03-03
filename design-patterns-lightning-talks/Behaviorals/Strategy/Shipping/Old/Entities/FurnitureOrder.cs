namespace design_patterns_lightning_talks.Behaviorals.Strategy.Shipping.Old.Entities
{
    public class FurnitureOrder : Order
    {
        public FurnitureOrder() : base("Furniture Order") { }

        public override double CalculateNormalShipping()
          => Total * .17;

        public override double CalculateMasterShipping()
          => throw new Exception("Shipping not allowed for this category.");
    }
}
