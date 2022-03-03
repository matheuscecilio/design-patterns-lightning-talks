using design_patterns_lightning_talks.Behaviorals.Strategy.Taxes.Solution.Enums;
using design_patterns_lightning_talks.Behaviorals.Strategy.Taxes.Solution.Interfaces;

namespace design_patterns_lightning_talks.Behaviorals.Strategy.Taxes.Solution.Entities
{
    public class BradescoTaxes : ITaxesCalculatorStrategy
    {
        public BradescoTaxes()
        {
            Id = BankIds.Bradesco;
        }

        public Guid Id { get; private set; }

        public double GetTax(Order order)
            => order.Total * 1.1;
    }
}
