using design_patterns_lightning_talks.Behaviorals.Strategy.Voltage.Interfaces.Solution;

namespace design_patterns_lightning_talks.Behaviorals.Strategy.Voltage.Entities.Solution
{
    public class CircuitBreaker : Equipment, IVoltageEquipmentStrategy
    {
        public double Power2 { get; set; }

        public double GetVoltage()
            => Power * Power2 * 15;
    }
}
