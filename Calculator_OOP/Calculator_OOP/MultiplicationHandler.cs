namespace Calculator_OOP
{
    public class MultiplicationHandler : Handler
    {
        public override void Handle(Expression expr)
        {
            if (expr.Operation == Operation.Multiplication)
            {
                var result = expr.A * expr.B;
                expr.Result = result;
            }
            else
            {
                Next.Handle(expr);
            }
        }
    }
}
