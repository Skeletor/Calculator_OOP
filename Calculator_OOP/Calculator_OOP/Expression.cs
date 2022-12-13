using System;

namespace Calculator_OOP
{
    public class Expression
    {
        public string Input { get; private set; }

        public double A { get; private set; }

        public double B { get; private set; }

        public Operation Operation { get; private set; }

        public double Result { get; set; }

        public Expression(string input = "")
        {
            if (string.IsNullOrEmpty(input)) return;

            var expr = input.Split(' ');

            A = double.Parse(expr[0]);
            B = double.Parse(expr[2]);

            switch (expr[1])
            {
                default: throw new InvalidOperationException("[ERROR]: Unknown operation.");

                case "+":
                    Operation = Operation.Addition;
                    break;

                case "-":
                    Operation = Operation.Substraction;
                    break;

                case "*":
                    Operation = Operation.Multiplication;
                    break;

                case "/":
                    Operation = Operation.Division;
                    break;

                case "^":
                    Operation = Operation.Pow;
                    break;
            }
        }
    }
}
