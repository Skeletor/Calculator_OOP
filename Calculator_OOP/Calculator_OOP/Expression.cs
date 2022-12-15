using System;

namespace Calculator_OOP
{
    public class Expression
    {
        private string _input;

        public double A { get; private set; }

        public double B { get; private set; }

        public Operation Operation { get; private set; }

        public double Result { get; set; }

        public string Input
        {
            get => _input;
            set
            {
                _input = value.Trim();

                var expr = _input.Split(' ');

                A = double.Parse(expr[0]);
                B = double.Parse(expr[2]);

                switch (expr[1])
                {
                    default: throw new InvalidOperationException("[ERROR]: Unknow/Invalid operation");

                    case "+":
                        Operation = Operation.Addition;
                        break;

                    case "-":
                        Operation = Operation.Substraction;
                        break;

                    case "x":
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

        public Expression() { }
    }
}
