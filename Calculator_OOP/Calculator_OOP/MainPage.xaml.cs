using Xamarin.Forms;
using System;

namespace Calculator_OOP
{
    public partial class MainPage : ContentPage
    {
        private Calculator Calculator { get; set; }

        private Expression Expression { get; set; }

        private bool _isResult;

        public MainPage()
        {
            InitializeComponent();

            Calculator = new Calculator();
            Expression = new Expression();
            _isResult = false;
        }

        private bool IsOperator(char c)
        {
            var match = "+-x/^";
            return match.Contains(c.ToString());
        }

        private void AddOperator(object s, EventArgs e)
        {
            if (displayLabel.Text.Length == 0)
            {
                displayLabel.Text = "0";
            }
            if (_isResult)
            {
                displayLabel.Text = Expression.Result.ToString();
            }

            var text = displayLabel.Text;

            if (IsOperator(text[text.Length - 1])) return;

            var btn = s as Button;

            displayLabel.Text += ' ' + btn.Text + ' ';
        }

        private void AddNumber(object s, EventArgs e)
        {
            if (_isResult)
            {
                displayLabel.Text = Expression.Result.ToString();
                _isResult = false;
            }

            var btn = s as Button;
            displayLabel.Text += btn.Text;
        }

        private void GetResult(object s, EventArgs e)
        {
            try
            {
                Expression.Input = displayLabel.Text;
                Calculator.Handle(Expression);
            }
            catch (Exception ex)
            {
                displayLabel.Text = ex.Message;
                _isResult = false;
                return;
            }

            _isResult = true;
            displayLabel.Text += " н = " + Expression.Result.ToString();
        }

        private void ClearSymbol(object s, EventArgs e)
        {
            if (displayLabel.Text.Length == 0) return;

            if (_isResult)
            {
                ClearAll(s, e);
            }
            else
            {
                displayLabel.Text =
                    displayLabel.Text.TrimEnd(displayLabel.Text[displayLabel.Text.Length - 1]);
            }
        }

        private void ClearAll(object s, EventArgs e)
        {
            displayLabel.Text = "";
            _isResult = false;
        }
    }
}
