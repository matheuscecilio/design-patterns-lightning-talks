using design_patterns_lightning_talks.Behaviorals.Strategy.Taxes.Solution.Enums;
using design_patterns_lightning_talks.Behaviorals.Strategy.Taxes.Solution.Interfaces;

namespace design_patterns_lightning_talks.Behaviorals.Strategy.Taxes.Solution.Entities
{
    public class BankOfAmericaTaxes : ITaxesCalculatorStrategy
    {
        public BankOfAmericaTaxes()
        {
            Id = BankIds.BankOfAmerica;
        }

        public Guid Id { get; private set; }

        public double GetTax(Order order)
            => order.Total * 1.01;
    }
}
