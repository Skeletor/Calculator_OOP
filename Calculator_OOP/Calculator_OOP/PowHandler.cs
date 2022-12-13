using System;

namespace Calculator_OOP
{
    public class PowHandler : Handler
    {
        public override void Handle(Expression expr)
        {
            if (expr.Operation == Operation.Pow)
            {
                var result = Math.Pow(expr.A, expr.B);
                expr.Result = result;
            }
            else
            {
                Next.Handle(expr);
            }
        }
    }
}
