using design_patterns_lightning_talks.Behaviorals.Strategy.Shipping.Solution.Interfaces;

namespace design_patterns_lightning_talks.Behaviorals.Strategy.Shipping.Solution.Shipping
{
    public class NormalShipping : IShipping
    {
        public double CalculateShipping(double totalOrder)
            => totalOrder * .05;
    }
}
