using NUnit.Framework;

namespace Calculator_OOP.Tests
{
    [TestFixture]
    public class Test
    {
        private Expression _expression;
        private Calculator _calcuator;

        public void Init()
        {
            _expression = new Expression();
            _calcuator = new Calculator();
        }

        [Test(Description = "Тест на сложение")]
        public void TestAddition()
        {
            Init();

            var a = 1;
            var b = 5;

            var expected = 6;

            _expression.Input = $"{a} + {b}";

            var actual = _expression.Result;

            Assert.AreEqual(expected, actual, "Неверное сложение");
        }

        [Test(Description = "Тест на вычитание")]
        public void TestSubstraction()
        {
            Init();

            var a = 7;
            var b = 3;

            var expected = 4;

            _expression.Input = $"{a} - {b}";

            var actual = _expression.Result;

            Assert.AreEqual(expected, actual, "Неверное вычитание");
        }

        [Test(Description = "Тест на умножение")]
        public void TestMultiplication()
        {
            Init();

            var a = 5;
            var b = 2;

            var expected = 10;

            _expression.Input = $"{a} x {b}";

            var actual = _expression.Result;

            Assert.AreEqual(expected, actual, "Неверное умножение");
        }

        [Test(Description = "Неверное деление")]
        public void TestDivision()
        {
            Init();

            var a = 6;
            var b = 3;

            var expected = 2;

            _expression.Input = $"{a} / {b}";

            var actual = _expression.Result;

            Assert.AreEqual(expected, actual, "Неверное деление");
        }

        [Test(Description = "Тест возведения в степень")]
        public void TestPow()
        {
            Init();

            var a = 2;
            var b = 4;

            var expected = 16;

            _expression.Input = $"{a} ^ {b}";

            var actual = _expression.Result;

            Assert.AreEqual(expected, actual, "Неверное возведение в степень");
        }
    }
}
