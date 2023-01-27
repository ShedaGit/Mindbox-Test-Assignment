using ShapesLibrary;
namespace ShapesLibrary.Tests;

public class TriangleTests
{
    [Fact]
    public void Area_SidesAre3_4_5_Returns6()
    {
        //Arrange
        var triangle = new Triangle(3, 4, 5);

        //Act
        var result = triangle.Area();

        //Assert
        Assert.Equal(6, result);
    }

    [Theory]
    [InlineData(3, 4, 5, true)]
    [InlineData(3, 4, 6, false)]
    public void IsRightAngled_Sides3_4_5_ReturnsExpectedResult(int a, int b, int c, bool expected)
    {
        //Arrange
        var triangle = new Triangle(a, b, c);

        //Act
        var result = triangle.IsRightAngled();

        //Assert
        Assert.Equal(expected, result);
    }
}