using ShapesLibrary;
namespace ShapesLibrary.Tests;

public class AreaCalculatorTests
{
    [Theory]
    [InlineData(5, 25 * Math.PI)]
    [InlineData(3, 9 * Math.PI)]
    public void CalculateArea_Circle_ReturnsCorrectArea(double radius, double expected)
    {
        // Arrange
        Circle circle = new Circle(radius);

        // Act
        double result = AreaCalculator.CalculateArea(circle);

        // Assert
        Assert.Equal(expected, result, 4);
    }

    [Theory]
    [InlineData(3, 4, 5, 6)]
    [InlineData(5, 12, 13, 30)]
    public void CalculateArea_Triangle_ReturnsCorrectArea(double a, double b, double c, double expected)
    {
        // Arrange
        Triangle triangle = new Triangle(a, b, c);

        // Act
        double result = AreaCalculator.CalculateArea(triangle);

        // Assert
        Assert.Equal(expected, result, 4);
    }
}