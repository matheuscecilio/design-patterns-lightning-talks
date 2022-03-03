using design_patterns_lightning_talks.Behaviorals.Strategy.Taxes.Old.Entities;
using design_patterns_lightning_talks.Behaviorals.Strategy.Taxes.Old.Enums;

namespace design_patterns_lightning_talks.Behaviorals.Strategy.Taxes.Old
{
    public static class TaxesCalculator
    {
        public static double CalculateTax(Order order)
        {
            BankTaxes bankTaxes;

            if (order.BankId == BankIds.Bradesco)
            {
                bankTaxes = new BradescoTaxes(order);
            }
            else if (order.BankId == BankIds.BankOfAmerica)
            {
                bankTaxes = new BankOfAmericaTaxes(order);
            }
            else if (order.BankId == BankIds.Itau)
            {
                bankTaxes = new ItauTaxes(order);
            }
            else
            {
                bankTaxes = new SantanderTaxes(order);
            }

            return bankTaxes.GetTax();
        }
    }
}
