namespace Calculator_OOP
{
    public class AdditionHandler : Handler
    {
        public override void Handle(Expression expr)
        {
            if (expr.Operation == Operation.Addition)
            {
                var result = expr.A + expr.B;
                expr.Result = result;
            }
            else
            {
                Next.Handle(expr);
            }
        }
    }
}
