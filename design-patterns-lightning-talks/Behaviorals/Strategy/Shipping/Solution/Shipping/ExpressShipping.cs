using design_patterns_lightning_talks.Behaviorals.Strategy.Shipping.Solution.Interfaces;

namespace design_patterns_lightning_talks.Behaviorals.Strategy.Shipping.Solution.Shipping
{
    public class ExpressShipping : IShipping
    {
        public double CalculateShipping(double totalOrder)
            => totalOrder * .15;
    }
}
