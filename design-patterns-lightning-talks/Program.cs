using ShippingOld = design_patterns_lightning_talks.Behaviorals.Strategy.Shipping.Old;
using TaxesOld = design_patterns_lightning_talks.Behaviorals.Strategy.Taxes.Old;
using VoltageOld = design_patterns_lightning_talks.Behaviorals.Strategy.Voltage.Old;
using ShippingSolution = design_patterns_lightning_talks.Behaviorals.Strategy.Shipping.Solution;
using TaxesSolution = design_patterns_lightning_talks.Behaviorals.Strategy.Taxes.Solution;
using VoltageSolution = design_patterns_lightning_talks.Behaviorals.Strategy.Voltage.Solution;

#region VOLTAGE 
// OLD
var transformerOld = new VoltageOld.Entities.Transformer
{
    Id = Guid.NewGuid(),
    Name = "TF1",
    Power = 12,
    Power2 = 12,
    Power3 = 12,
};

var voltageOld = VoltageOld.VoltageCalculator.GetVoltage(transformerOld);

Console.WriteLine($"Voltage [OLD]: {voltageOld}");

//Solution
var transformerSolution = new VoltageSolution.Entities.Transformer
{
    Id = Guid.NewGuid(),
    Name = "TF1",
    Power = 12,
    Power2 = 12,
    Power3 = 12,
};

var voltageSolution = VoltageSolution.VoltageCalculator.GetVoltage(transformerSolution);

Console.WriteLine($"Voltage [SOLUTION]: {voltageSolution}");

#endregion

#region TAXES
// Old
var orderOld = new TaxesOld.Entities.Order(
    TaxesOld.Enums.BankIds.Bradesco
);

orderOld.ItemsPrice = new List<double> { 1, 2, 5, 6, 7 };

var taxesOld = TaxesOld.TaxesCalculator.CalculateTax(orderOld);

Console.WriteLine($"Taxes [OLD]: {taxesOld}");

// Solution
var orderSolution = new TaxesSolution.Entities.Order(
    TaxesSolution.Enums.BankIds.Bradesco
);

orderSolution.ItemsPrice = new List<double> { 1, 2, 5, 6, 7 };

var bankSolution = new TaxesSolution.Entities.BradescoTaxes();

var taxesCalculatorSolution = new TaxesSolution.TaxesCalculator(bankSolution);

var taxesSolution = taxesCalculatorSolution.CalculateTax(orderSolution);

Console.WriteLine($"Taxes [SOLUTION]: {taxesSolution}");
#endregion

#region SHIPPING
// Old
var eletronicOrderOld = new ShippingOld.Entities.EletronicOrder();
eletronicOrderOld.Total = 1000;

var eletronicOrderExpressShippingOld = eletronicOrderOld.CalculateExpressShipping();

Console.WriteLine($"Shipping [OLD]: {eletronicOrderExpressShippingOld}");

// Solution
var normalShipping = new ShippingSolution.Shipping.ExpressShipping();

var eletronicOrderSolution = new ShippingSolution.Entities.EletronicOrder(
    normalShipping
);

eletronicOrderSolution.Total = 1000;

var eletronicOrderExpressShippingSolution = eletronicOrderSolution.CalculateShipping();

Console.WriteLine($"Shipping [SOLUTION]: {eletronicOrderExpressShippingSolution}");
#endregion
