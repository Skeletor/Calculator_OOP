namespace Calculator_OOP
{
    public class SubstractionHandler : Handler
    {
        public override void Handle(Expression expr)
        {
            if (expr.Operation == Operation.Substraction)
            {
                var result = expr.A - expr.B;
                expr.Result = result;
            }
            else
            {
                Next.Handle(expr);
            }
        }
    }
}
