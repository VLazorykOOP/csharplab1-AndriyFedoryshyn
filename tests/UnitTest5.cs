namespace tests;

using Lab1Charp;
public class UnitTest5 
{ 
    [Fact]
    public void SquareOfSum_5_5_100()
    {
        //Arrange
        double a = 5;
        double b = 5;
        double expected = 100;
        //Act
        double actual = Lab1Charp.SquareOfSum(a, b);
        //Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void SquareOfSum_0_0_0()
    {
        //Arrange
        double a = 0;
        double b = 0;
        double expected = 0;
        //Act
        double actual = Lab1Charp.SquareOfSum(a, b);
        //Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void SquareOfSum_0_5_25()
    {
        //Arrange
        double a = 0;
        double b = 5;
        double expected = 25;
        //Act
        double actual = Lab1Charp.SquareOfSum(a, b);
        //Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void SquareOfSum_5_0_25()
    {
        //Arrange
        double a = 5;
        double b = 0;
        double expected = 25;
        //Act
        double actual = Lab1Charp.SquareOfSum(a, b);
        //Assert
        Assert.Equal(expected, actual);
    }
    

    [Fact]
    public void CalculateExpression_0_0_0()
    {
        //Arrange
        double a = 0;
        double b = 0;
        double expected = 0;
        //Act
        double actual = Lab1Charp.SquareOfSum(a, b);
        //Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void CalculateExpression_minus3_minus3_0()
    {
        //Arrange
        double a = -3;
        double b = -3;
        double expected = 36;
        //Act
        double actual = Lab1Charp.SquareOfSum(a, b);
        //Assert
        Assert.Equal(expected, actual);
    }
}