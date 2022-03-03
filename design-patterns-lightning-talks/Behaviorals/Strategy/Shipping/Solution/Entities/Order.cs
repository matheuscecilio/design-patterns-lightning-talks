using design_patterns_lightning_talks.Behaviorals.Strategy.Shipping.Solution.Interfaces;

namespace design_patterns_lightning_talks.Behaviorals.Strategy.Shipping.Solution.Entities
{
    public abstract class Order
    {
        public Order(
            string name,
            IShipping shipping
        )
        {
            Name = name;
            Shipping = shipping;
        }

        public Guid Id { get; set; }
        public double Total { get; set; }
        public string? Name { get; set; }
        public IShipping Shipping { get; set; }

        public double CalculateShipping()
            => Shipping.CalculateShipping(Total);
    }
}
