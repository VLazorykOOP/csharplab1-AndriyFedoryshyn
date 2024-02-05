namespace tests;

using Lab1Charp;
public class UnitTest1
{
    [Fact]
    public void CalculateCircleRadius_ValidLength_ReturnsRadius()
    {
        // Arrange
        double length = 10; 

        // Act
        double result = Lab1Charp.CalculateCircleRadius(length);

        // Assert
        Assert.Equal(1.5915, result, 4); 
    }

    [Fact]
    public void CalculateCircleRadius_NegativeLength_ReturnsZero()
    {
        // Arrange
        double length = -10; 

        // Act
        double result = Lab1Charp.CalculateCircleRadius(length);

        // Assert
        Assert.Equal(0, result); 
    }

    [Fact]
    public void CalculateCircleRadius_ZeroLength_ReturnsZero()
    {
        // Arrange
        double length = 0; 

        // Act
        double result = Lab1Charp.CalculateCircleRadius(length);

        // Assert
        Assert.Equal(0, result); 
    }
}