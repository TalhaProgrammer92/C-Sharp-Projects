using BisectionMethod;

// Without tolerance
Function f1 = new();

f1.AddVariable(1, 2);
f1.AddConstant(3, Sign.MINUS);

Interval i1 = new(1, 2);

Console.WriteLine($"{f1}, {i1.StrValue()}");

//Console.WriteLine($"Sign: {f1.GetSignOfTwoFunctionInputs(i1.Start, i1.End)}");
Console.WriteLine($"Root Precision: {Bisection.EvaluateRootPrecision(f1, i1)}");
