using System.Text;

namespace BisectionMethod
{
    public sealed class Function
    {
        private readonly List<SignedVariable> _expression;

        public Function()
        {
            _expression = new();
        }

        public void AddVariable(double constant, double power, Sign sign = Sign.PLUS)
        {
            Guard.AgainstZero(power, "Power");
            Guard.AgainstZeroOrLess(constant, "Constant");

            SignedVariable variable = new(constant, power, sign);
            _expression.Add(variable);
        }

        public void AddConstant(double value, Sign sign)
        {
            Guard.AgainstNegative(value, "Constant");

            SignedVariable variable = new(value, 0, sign);
            _expression.Add(variable);
        }

        public double Evaluate(double value)
        {
            double result = 0;

            foreach (var variable in _expression)
            {
                result = variable.Sign switch
                {
                    Sign.PLUS => result + variable.GetResult(value),
                    Sign.MINUS => result - variable.GetResult(value),
                    Sign.MULTIPLY => result * variable.GetResult(value),
                    Sign.DIVIDE => result / variable.GetResult(value),
                    _ => result,
                };
            }

            return result;
        }

        public void EvaluateAndDisplay(double value)
        {
            var result = Evaluate(value);

            Console.WriteLine($"For x = {value}; f({value}) = {result}");
        }

        public Sign GetSignOfTwoFunctionInputs(double a, double b)
        {
            double x = Evaluate(a),
                y = Evaluate(b);

            //Console.WriteLine($"For {a}; {x} --- For {b}; {y}");

            return x < 0 || y < 0 ? Sign.MINUS : Sign.PLUS;
        }

        public override string ToString()
        {
            StringBuilder stringExpression = new();

            for (int i = 0; i < _expression.Count; i++)
            {
                var variable = _expression[i];

                if (i > 0 || variable.Sign == Sign.MINUS)
                    stringExpression.Append($" {variable.SignSymbol} {variable}");
                else
                    stringExpression.Append(variable.ToString());
            }

            return $"f(x) = {stringExpression}";
        }
    }
}
