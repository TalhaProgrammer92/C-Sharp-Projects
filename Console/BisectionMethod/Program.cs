using BisectionMethod;

while (true)
{
    Console.Clear();

    // Get choice from user
    Console.WriteLine("1-Enter own function");
    Console.WriteLine("2-Use example function");
    Console.WriteLine("3-Exit the program");
    Console.Write("\nEnter your choice: ");

    int choice = int.TryParse(Console.ReadLine() ?? "0", out int parsedChoice) ? parsedChoice : 0;

    // User input
    if (choice == 1)
    {
        Console.Clear();

        // Building the function
        Function func = new();

        Console.Write("Enter number of variables (including constants): ");
        int numVariables = int.TryParse(Console.ReadLine() ?? "0", out int parsedNumVariables)
            ? parsedNumVariables
            : 0;

        for (int i = 0; i < numVariables; i++)
        {
            Console.Write("\nEnter the constant with variable (Leave blank for 1): ");
            int constant = int.TryParse(Console.ReadLine() ?? "1", out int parsedConstant)
                ? parsedConstant
                : 1;

            Console.Write(
                "Enter the power of the variable (Leave blank for 0, making it a constant value): "
            );
            int power = int.TryParse(Console.ReadLine() ?? "0", out int parsedPower)
                ? parsedPower
                : 0;

            Console.Write(
                "Enter the sign of the variable (1-Plus, 2-Minus, 3-Multiply, 4-Divide): "
            );
            int sign = int.TryParse(Console.ReadLine() ?? "1", out int parsedSign) ? parsedSign : 1;

            if (power == 0)
            {
                func.AddConstant(
                    constant,
                    sign switch
                    {
                        1 => Sign.PLUS,
                        2 => Sign.MINUS,
                        3 => Sign.MULTIPLY,
                        4 => Sign.DIVIDE,
                        _ => Sign.PLUS,
                    }
                );
            }
            else
            {
                func.AddVariable(
                    constant,
                    power,
                    sign switch
                    {
                        1 => Sign.PLUS,
                        2 => Sign.MINUS,
                        3 => Sign.MULTIPLY,
                        4 => Sign.DIVIDE,
                        _ => Sign.PLUS,
                    }
                );
            }
        }

        // Building the interval
        Console.Write("\nEnter starting value for the interval: ");
        double a = double.TryParse(Console.ReadLine() ?? "0", out double parsedA) ? parsedA : 1;

        Console.Write("Enter ending value for the interval: ");
        double b = double.TryParse(Console.ReadLine() ?? "0", out double parsedB) ? parsedB : 2;

        Interval interval = new(a, b);

        // Getting tolerance
        Console.Write("Enter tolerance (Leave blank for none): ");
        double? tolerance = double.TryParse(Console.ReadLine() ?? "0", out double parsedTolerance)
            ? parsedTolerance
            : null;

        // Show steps choice
        Console.Write("Do you want to see the steps? (Y/n): ");
        bool showSteps = Console.ReadLine()?.ToLower() == "y";

        // Evaluate root precision
        Console.Clear();

        if (tolerance.HasValue)
        {
            Console.WriteLine(
                $"Evaluating root precision for function: {func}, Interval: {interval.StrValue()}, Tolerance: {tolerance.Value}\n"
            );
        }
        else
        {
            Console.WriteLine(
                $"Evaluating root precision for function: {func}, Interval: {interval.StrValue()}\n"
            );
        }

        double? rootPrecision = tolerance.HasValue
            ? Bisection.EvaluateRootPrecision(func, interval, tolerance.Value, showSteps)
            : Bisection.EvaluateRootPrecision(func, interval, showSteps);

        if (rootPrecision.HasValue)
        {
            Console.WriteLine($"Root Precision is {rootPrecision:0.#####}");
        }

        // Hold the console output
        Misc.Hold();
    }
    // Examples
    else if (choice == 2)
    {
        Console.Clear();
        Console.WriteLine("1-Without Tolerance");
        Console.WriteLine("2-With Tolerance");
        Console.Write("\nEnter your choice: ");

        choice = int.TryParse(Console.ReadLine() ?? "0", out parsedChoice) ? parsedChoice : 0;

        if (choice == 1)
        {
            Console.Clear();
            Examples.WithoutTolerance();
        }
        else if (choice == 2)
        {
            Console.Clear();
            Examples.WithTolerance();
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
        }

        // Hold the console output
        Misc.Hold();
    }
    // Exit
    else if (choice == 3)
    {
        Console.WriteLine("Exiting the program...");
        break;
    }
    else
    {
        Console.WriteLine("Invalid choice. Please try again.");
    }
}
