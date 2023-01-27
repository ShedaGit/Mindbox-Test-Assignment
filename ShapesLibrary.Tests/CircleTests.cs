using ShapesLibrary;
namespace ShapesLibrary.Tests;

public class CircleTests
{
    [Theory]
    [InlineData(1, 3.14)]
    [InlineData(5, 78.54)]
    [InlineData(10, 314.16)]
    public void Area_ReturnsExpectedResult(double radius, double expected)
    {
        //Arrange
        var circle = new Circle(radius);

        //Act
        var result = circle.Area();

        //Assert
        Assert.Equal(expected, result, 2);
    }
}