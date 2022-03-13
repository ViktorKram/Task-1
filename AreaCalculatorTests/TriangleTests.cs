using System;
using Xunit;
using AreaCalculator.Classes;

namespace AreaCalculatorTests
{
    public class TriangleTests
    {
        [Fact]
        void TriangleCreation_WhenSideIsPositiveInfinity_ShouldThrowArgumentException()
        {
            // Act
            Action act = () => new Triangle(1, 2, Double.PositiveInfinity);
            ArgumentException exception = Assert.Throws<ArgumentException>(act);

            // Assert
            Assert.Equal("Side is positive infinity.", exception.Message);
        }

        [Fact]
        void TriangleCreation_WhenSideIsNaN_ShouldThrowArgumentException()
        {
            // Act
            Action act = () => new Triangle(1, 2, Double.NaN);
            ArgumentException exception = Assert.Throws<ArgumentException>(act);

            // Assert
            Assert.Equal("Side is NaN.", exception.Message);
        }

        [Fact]
        void TriangleCreation_WhenSideIsZero_ShouldThrowArgumentOutOfRangeException()
        {
            // Act
            Action act = () => new Triangle(0, 4, 5);
            ArgumentOutOfRangeException exception = Assert.Throws<ArgumentOutOfRangeException>(act);

            // Assert
            Assert.Equal("Side must be over 0. (Parameter 'Side')", exception.Message);
        }

        [Fact]
        void TriangleCreation_WhenSideIsLessThanZero_ShouldThrowArgumentOutOfRangeException()
        {
            // Act
            Action act = () => new Triangle(Double.NegativeInfinity, 4, 5);
            ArgumentOutOfRangeException exception = Assert.Throws<ArgumentOutOfRangeException>(act);

            // Assert
            Assert.Equal("Side must be over 0. (Parameter 'Side')", exception.Message);
        }

        [Fact]
        void TriangleCreation_WhenTriangleWithSideValuesCannotExist_ShouldThrowArgumentOutOfRangeException()
        {
            // Act
            Action act = () => new Triangle(10, 3, 2);
            ArgumentOutOfRangeException exception = Assert.Throws<ArgumentOutOfRangeException>(act);

            // Assert
            Assert.Equal("Triangle with these sides cannot exist. (Parameter 'Side')", exception.Message);
        }

        [Fact]
        void HasRightAngle_WithValidTriangleSideValues_ReturnsTrue()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 5);

            // Act
            var result = triangle.HasRightAngle();

            // Assert
            Assert.True(result);
        }

        [Fact]
        void HasRightAngle_WithValidTriangleSideValues_ReturnsFalse()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 6);

            // Act
            var result = triangle.HasRightAngle();

            // Assert
            Assert.False(result);
        }

        [Fact]
        void CalculateSquare_WithValidTriangleSideValues_CalculatesTriangleSquare()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 5);
            var expected = 6;

            // Act
            var result = triangle.CalculateArea();

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
