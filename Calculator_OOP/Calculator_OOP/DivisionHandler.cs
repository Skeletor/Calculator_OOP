namespace Calculator_OOP
{
    public class DivisionHandler : Handler
    {
        public override void Handle(Expression expr)
        {
            if (expr.Operation == Operation.Division)
            {
                var result = expr.A / expr.B;
                expr.Result = result;
            }
            else
            {
                Next.Handle(expr);
            }
        }
    }
}
