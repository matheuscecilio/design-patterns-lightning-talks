using design_patterns_lightning_talks.Behaviorals.Strategy.Voltage.Interfaces.Solution;

namespace design_patterns_lightning_talks.Behaviorals.Strategy.Voltage.Entities.Solution
{
    public class Disconnector : Equipment, IVoltageEquipmentStrategy
    {
        public double GetVoltage()
            => Power * 20;
    }
}
