namespace design_patterns_lightning_talks.Behaviorals.Strategy.Shipping.Old.Entities
{
    public class EletronicOrder : Order
    {
        public EletronicOrder() : base("Eletronic Order") { }

          public override double CalculateMasterShipping()
            => Total * .4;
    }
}

