using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator_OOP
{
    public abstract class Handler
    {
        private Handler Next { get; set; }

        public Handler(Handler handler)
        {
            Next = handler;
        }

        public void Handle(Expression expr) => Next?.Handle(expr);
    }
}
