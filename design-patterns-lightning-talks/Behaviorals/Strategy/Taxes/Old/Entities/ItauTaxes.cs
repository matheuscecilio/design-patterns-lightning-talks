using design_patterns_lightning_talks.Behaviorals.Strategy.Taxes.Old.Enums;

namespace design_patterns_lightning_talks.Behaviorals.Strategy.Taxes.Old.Entities
{
    public class ItauTaxes : BankTaxes
    {
        public ItauTaxes(Order order)
        {
            Id = BankIds.Itau;
            Order = order;
        }

        public Guid Id { get; private set; }
        public Order Order { get; set; }

        public override double GetTax()
            => Order.Total * 1.07;
    }
}
