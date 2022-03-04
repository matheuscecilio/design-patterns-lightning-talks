using Voltage = design_patterns_lightning_talks.Behaviorals.Strategy.Voltage;
using Taxes = design_patterns_lightning_talks.Behaviorals.Strategy.Taxes;
using Shipping = design_patterns_lightning_talks.Behaviorals.Strategy.Shipping;
using design_patterns_lightning_talks.Behaviorals.Strategy.Taxes.Old.Enums;

#region VOLTAGE 
// OLD
var transformerOld = new Voltage.Old.Entities.Transformer
{
    Id = Guid.NewGuid(),
    Name = "TF1",
    Power = 12,
    Power2 = 12,
    Power3 = 12,
};

var voltageOld = Voltage.Old.VoltageCalculator.GetVoltage(transformerOld);

Console.WriteLine(voltageOld);

//Solution
var transformerSolution = new Voltage.Solution.Entities.Transformer
{
    Id = Guid.NewGuid(),
    Name = "TF1",
    Power = 12,
    Power2 = 12,
    Power3 = 12,
};

var voltageSolution = Voltage.Solution.VoltageCalculator.GetVoltage(transformerSolution);

Console.WriteLine(voltageSolution);

#endregion


#region TAXES
// Old
var orderOld = new Taxes.Old.Entities.Order(
    Taxes.Old.Enums.BankIds.Bradesco
);

var taxesOld = Taxes.Old.TaxesCalculator.CalculateTax(orderOld);

Console.WriteLine(taxesOld);

// Solution
var orderSolution = new Taxes.Solution.Entities.Order(
    Taxes.Solution.Enums.BankIds.Bradesco
);

var bankSolution = new Taxes.Solution.Entities.BradescoTaxes();

var taxesCalculatorSolution = new Taxes.Solution.TaxesCalculator(bankSolution);

var taxesSolution = taxesCalculatorSolution.CalculateTax(orderSolution);

Console.WriteLine(taxesSolution);
#endregion

#region SHIPPING
// Old
var shippingOld = new Shipping.Old.Entities.EletronicOrder();

var taxesOld = Taxes.Old.TaxesCalculator.CalculateTax(orderOld);

Console.WriteLine(taxesOld);

// Solution
var orderSolution = new Taxes.Solution.Entities.Order(
    Taxes.Solution.Enums.BankIds.Bradesco
);

var bankSolution = new Taxes.Solution.Entities.BradescoTaxes();

var taxesCalculatorSolution = new Taxes.Solution.TaxesCalculator(bankSolution);

var taxesSolution = taxesCalculatorSolution.CalculateTax(orderSolution);

Console.WriteLine(taxesSolution);
#endregion
