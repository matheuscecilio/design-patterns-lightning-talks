using design_patterns_lightning_talks.Behaviorals.Strategy.Voltage.Old.Entities;

namespace design_patterns_lightning_talks.Behaviorals.Strategy.Voltage.Old
{
    public static class VoltageCalculator
    {
        public static double GetVoltage(Equipment equipment)
        {
            if (equipment is Transformer)
            {
                Transformer transformer = (Transformer)equipment;
                return transformer.Power
                    * transformer.Power2
                    * transformer.Power3
                    * 10;
            }
            else if (equipment is CircuitBreaker)
            {
                CircuitBreaker circuitBreaker = (CircuitBreaker)equipment;
                return circuitBreaker.Power
                    * circuitBreaker.Power2
                    * 15;
            }
            else
            {
                Disconnector disconnector = (Disconnector)equipment;
                return disconnector.Power * 20;
            }
        }
    }
}
