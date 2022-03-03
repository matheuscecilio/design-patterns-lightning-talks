using design_patterns_lightning_talks.Behaviorals.Strategy.Voltage.Interfaces.Solution;

namespace design_patterns_lightning_talks.Behaviorals.Strategy.Voltage.Solution
{
    public static class VoltageCalculator
    {
        public static double GetVoltage(IVoltageEquipmentStrategy equipment)
            => equipment.GetVoltage();
    }
}
