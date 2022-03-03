namespace design_patterns_lightning_talks.Behaviorals.Strategy.Taxes.Old.Entities
{
    public class Order
    {
        public Order(Guid bankId)
        {
            Id = Guid.NewGuid();
            ItemsPrice = new();
            BankId = bankId;
        }

        public Guid Id { get; set; }
        public List<double> ItemsPrice { get; set; }
        public Guid BankId { get; set; }

        public double Total => ItemsPrice.Sum();
    }
}
