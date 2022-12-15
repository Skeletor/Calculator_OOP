namespace Calculator_OOP
{
    public abstract class Handler
    {
        public Handler Next { get; set; }

        public abstract void Handle(Expression expr);
    }
}
