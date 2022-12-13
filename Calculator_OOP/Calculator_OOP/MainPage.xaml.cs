using Xamarin.Forms;
using System.Windows.Input;

namespace Calculator_OOP
{
    public partial class MainPage : ContentPage
    {
        private Calculator _calculator;
        private Expression _expression;

        public MainPage()
        {
            InitializeComponent();

            _calculator = new Calculator();
            _expression = new Expression();

            _calculator.Handle(_expression);
        }
    }
}
