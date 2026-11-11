namespace BisectionMethod
{
    public class Variable
    {
        protected readonly double _constant;
        protected readonly double _power;

        public Variable(double constant, double power)
        {
            _constant = constant;
            _power = power;
        }

        public double GetResult(double value) => _constant * Math.Pow(value, _power);

        public override string ToString()
        {
            if (_power == 0)
            {
                return $"{_constant}";
            }
            else if (_power == 1)
            {
                return _constant == 1 ? "x" : $"{_constant}x";
            }

            return _constant == 1 ? $"x^{_power}" : $"{_constant}x^{_power}";
        }
    }

    public sealed class SignedVariable : Variable
    {
        public readonly Sign Sign;

        public SignedVariable(double constant, double power, Sign sign = Sign.PLUS)
            : base(constant, power)
        {
            Sign = sign;
        }

        public char SignSymbol =>
            Sign switch
            {
                Sign.PLUS => '+',
                Sign.MINUS => '-',
                Sign.MULTIPLY => '*',
                Sign.DIVIDE => '/',
                _ => '?',
            };
    }
}
