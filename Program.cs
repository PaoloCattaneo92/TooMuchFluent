









using PaoloCattaneo.TooMuchFluent;

var boringValue = 2438;

var smartValue = new NumberFactory()
    .Thousands(2)
    .Hundreds(4)
    .Decimals(3)
    .Units(8)
    .Build();

Console.WriteLine($"Boring value: {boringValue}");
Console.WriteLine($"Smart value: {smartValue}");