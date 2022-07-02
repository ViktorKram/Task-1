using System;
using Xunit;
using AreaCalculator.Classes;

namespace AreaCalculatorTests
{
    public class CircleTests
    {
        [Fact]
        void CircleCreation_WhenRadiusIsPositiveInfinity_ShouldThrowArgumentException()
        {
            // Act
            Action act = () => new Circle(Double.PositiveInfinity);
            ArgumentException exception = Assert.Throws<ArgumentException>(act);

            //Assert
            Assert.Equal($"Parameter is positive infinity. (Parameter '{exception.ParamName}')", exception.Message);
        }

        [Fact]
        void CircleCreation_WhenRadiusIsNaN_ShouldThrowArgumentException()
        {
            // Act
            Action act = () => new Circle(Double.NaN);
            ArgumentException exception = Assert.Throws<ArgumentException>(act);

            // Assert
            Assert.Equal($"Parameter is NaN. (Parameter '{exception.ParamName}')", exception.Message);
        }

        [Fact]
        void CircleCreation_WhenRadiusIsZero_ShouldThrowArgumentOutOfRangeException()
        {
            // Act
            Action act = () => new Circle(0);
            ArgumentOutOfRangeException exception = Assert.Throws<ArgumentOutOfRangeException>(act);

            // Assert
            Assert.Equal($"Parameter equals or less than 0. (Parameter '{exception.ParamName}')", exception.Message);
        }

        [Fact]
        void CircleCreation_WhenRadiusIsLessThanZero_ShouldThrowArgumentOutOfRangeException()
        {
            // Act
            Action act = () => new Circle(Double.NegativeInfinity);
            ArgumentOutOfRangeException exception = Assert.Throws<ArgumentOutOfRangeException>(act);

            // Assert
            Assert.Equal($"Parameter equals or less than 0. (Parameter '{exception.ParamName}')", exception.Message);
        }

        [Fact]
        void CalculateSquare_WithValidRadius_ReturnsCircleSquareNumber()
        {
            // Arrange
            var circle = new Circle(1);
            var expected = Math.PI;

            // Act
            var result = circle.CalculateArea();

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
