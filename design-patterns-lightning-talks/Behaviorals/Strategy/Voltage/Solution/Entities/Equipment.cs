using design_patterns_lightning_talks.Behaviorals.Strategy.Voltage.Interfaces.Solution;

namespace design_patterns_lightning_talks.Behaviorals.Strategy.Voltage.Entities.Solution
{
    public abstract class Equipment
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public double Power { get; set; }
    }
}
