using Xunit;
using Session09_Assignment;
namespace Session09Tests

{

    public class FineCalculatorTests

    {

        private readonly FineCalculator _calculator;



        public FineCalculatorTests()

        {

            _calculator = new FineCalculator();

        }





        // 1. Add - Correct Result

        [Fact]

        public void Add_ShouldReturnCorrectSum()

        {

            // Arrange

            int a = 5;

            int b = 3;



            // Act

            var result = _calculator.Add(a, b);



            // Assert

            Assert.Equal(8, result);

        }





        // 2. Add - Not Equal

        [Fact]

        public void Add_ShouldReturnNotEqual()

        {

            // Arrange

            int a = 5;

            int b = 3;



            // Act

            var result = _calculator.Add(a, b);



            // Assert

            Assert.NotEqual(3, result);

        }





        // 3. Subtract - Correct Result

        [Fact]

        public void Subtract_ShouldReturnCorrectDifference()

        {

            // Arrange

            int a = 10;

            int b = 5;



            // Act

            var result = _calculator.Subtract(a, b);



            // Assert

            Assert.Equal(5, result);

        }





        // 4. Multiply - Correct Result

        [Theory]

        [InlineData(2, 3, 6)]

        [InlineData(4, 5, 20)]

        [InlineData(-2, 3, -6)]

        public void Multiply_ShouldReturnCorrectResult(

        int a,

        int b,

        int expected)

        {

            // Arrange



            // Act

            var result = _calculator.Multiply(a, b);



            // Assert

            Assert.Equal(expected, result);

        }





        // 5. Multiply - Not Equal

        [Theory]

        [InlineData(2, 3, 2)]

        [InlineData(4, 5, 120)]

        [InlineData(-2, 3, 6)]

        public void Multiply_ShouldReturnNotEqual(

        int a,

        int b,

        int expected)

        {

            // Arrange



            // Act

            var result = _calculator.Multiply(a, b);



            // Assert

            Assert.NotEqual(expected, result);

        }





        // 6. Divide by Zero

        [Fact]

        public void Divide_ByZero_ShouldThrowException()

        {

            // Arrange

            int a = 12;

            int b = 0;



            // Act & Assert

            Assert.Throws<DivideByZeroException>(() =>

            {

                _calculator.Divide(a, b);

            });

        }

    }

}