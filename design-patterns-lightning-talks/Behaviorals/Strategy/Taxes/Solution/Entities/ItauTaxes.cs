using design_patterns_lightning_talks.Behaviorals.Strategy.Taxes.Solution.Enums;
using design_patterns_lightning_talks.Behaviorals.Strategy.Taxes.Solution.Interfaces;

namespace design_patterns_lightning_talks.Behaviorals.Strategy.Taxes.Solution.Entities
{
    public class ItauTaxes : ITaxesCalculatorStrategy
    {
        public ItauTaxes()
        {
            Id = BankIds.Itau;
        }

        public Guid Id { get; private set; }

        public double GetTax(Order order)
            => order.Total * 1.07;
    }
}
