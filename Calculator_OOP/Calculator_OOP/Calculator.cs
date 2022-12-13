namespace Calculator_OOP
{
    class Calculator
    {
        private Handler Chain { get; set; }

        public Calculator()
        {
            BuildChain();
        }

        private void BuildChain() => Chain = new AdditionHandler
        {
            Next = new SubstractionHandler
            {
                Next = new MultiplicationHandler()
                {
                    Next = new DivisionHandler()
                    {
                        Next = new PowHandler()
                        {
                            Next = null
                        }
                    }
                }
            }
        };

        public void Handle(Expression expr) => Chain.Handle(expr);
    }
}
