namespace design_patterns_lightning_talks.Behaviorals.Strategy.Shipping.Old.Entities
{
    public abstract class Order
    {
        public Order(string name)
        {
            Name = name;
        }

        public Guid Id { get; set; }
        public double Total { get; set; }
        public string? Name { get; set; }

        public virtual double CalculateNormalShipping()
            => Total * .05;

        public virtual double CalculateExpressShipping()
            => Total * .15;

        public virtual double CalculateMasterShipping()
            => Total * .3;
    }
}
