using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(-6, 3, -1, -4)] 
        [InlineData(2, 3, -4, 1)] 
        [InlineData(1, -1, 0, 0)] 
        [InlineData(0, 0, 0, 0)] 
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var m = new Calculator();

            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual
                var actual = m.Add(num1, num2, num3);

            //Assert
                Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(2, 3, -1)] //Add test data <-------
        [InlineData(2, -6, 8)]
        [InlineData(2, -3, 5)]
        [InlineData(0, 0, 0)]
        [InlineData(-6, -6, 0)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var m = new Calculator();
            //Act
            var actual = m.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(6, 6, 36)]//Add test data <-------
        [InlineData(3, -6, -18)]
        [InlineData(11, -4, -44)]
        [InlineData(-22, -1, 22)]
        [InlineData(0, 0, 0)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var m = new Calculator();
            //Act
            var actual = m.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(24, 3, 8)]//Add test data <-------
        [InlineData(6, 3, 2)]
        [InlineData(10, -1, -10)]
        [InlineData(-15, -3, 5)]
        [InlineData(30, 0, 0)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var m = new Calculator();
            //Act
            var actual = m.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
