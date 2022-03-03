using design_patterns_lightning_talks.Behaviorals.Strategy.Taxes.Solution.Entities;
using design_patterns_lightning_talks.Behaviorals.Strategy.Taxes.Solution.Interfaces;

namespace design_patterns_lightning_talks.Behaviorals.Strategy.Taxes.Solution
{
    public class TaxesCalculator
    {
        private readonly ITaxesCalculatorStrategy _taxesCalculatorStrategy;

        public TaxesCalculator(ITaxesCalculatorStrategy taxesCalculatorStrategy)
        {
            _taxesCalculatorStrategy = taxesCalculatorStrategy;
        }

        public double CalculateTax(Order order)
            => _taxesCalculatorStrategy.GetTax(order);
    }
}
