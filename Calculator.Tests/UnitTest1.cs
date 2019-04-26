using System;
using Xunit;

namespace CalculatorWithTests.Tests
{
    public class CalculateTests
    {
        [Theory]
        [InlineData(100, 10, 110)]
        [InlineData(25, 30, 55)]
        [InlineData(-5, 5, 0)]

        public void ShouldAddData(double num1, double num2, double expected)
        {
            //Arrange

            //Act

            //Assert
        }

        [Theory]
        [InlineData(100, 10, 90)]
        [InlineData(30, 50, -20)]
        [InlineData(0, 0, 0)]
       
        public void ShouldSubtractData(double num1, double num2, double expected)
        { 
            //Arrange

            //Act

            //Assert
        }

        [Theory]
        [InlineData(7, 7, 49)]
        [InlineData(-3, -3, 9)]
        [InlineData(2, -4, -8)]
        [InlineData(0, 0, 0)]

        public void ShouldMultiplyData(double num1, double num2, double expected)
        { 
            //Arrange

            //Act

            //Assert
        }

        [Theory]
        [InlineData(7, 7, 1)]
        [InlineData(-24, 3, 8)]
        [InlineData(24, -3, -8)]
        [InlineData(0, 7, 0)]
        [InlineData(15, 0, 0]
       

        public void ShouldDivideData(double num1, double num2, double expected)
        { 
            //Arrange

            //Act

            //Assert
        }

        [Theory]
        [InlineData(6, 720)]
        [InlineData(5, 120)]
        [InlineData(1, 1)]
        [InlineData(0, 1)]

        public void ShouldFactorialData(double num1, double expected)
        { 
            //Arrange

            //Act 

            //Assert
        }


    }
}
