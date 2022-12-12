using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator_OOP
{
    class Calculator
    {
        private Expression _context;
        private IOperator _oper;
       
        public Calculator(Expression context, IOperator oper)
        {
            _context = context;
            _oper = oper;
        }


    }
}
