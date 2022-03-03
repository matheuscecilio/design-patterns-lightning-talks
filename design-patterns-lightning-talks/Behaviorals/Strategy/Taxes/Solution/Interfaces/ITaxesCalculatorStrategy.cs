using design_patterns_lightning_talks.Behaviorals.Strategy.Taxes.Solution.Entities;

namespace design_patterns_lightning_talks.Behaviorals.Strategy.Taxes.Solution.Interfaces
{
    public interface ITaxesCalculatorStrategy
    {
        double GetTax(Order order);
    }
}
