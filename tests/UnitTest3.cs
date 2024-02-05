namespace tests;

using Lab1Charp;
public class UnitTest3
{
    [Fact]
    public void CheckPointLocation_PointIsInRectangle_ReturnsYes()
    {
        //Arrange
        double x = 2;
        double y = 1;
        string expected = "Yes";
        //Act
        string actual = Lab1Charp.CheckPointLocation(x, y);
        //Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void CheckPointLocation_PointIsOnTheBorder_ReturnsOnTheBorder()
    {
        //Arrange
        double x = 70;
        double y = 70;
        string expected = "On the border";
        //Act
        string actual = Lab1Charp.CheckPointLocation(x, y);
        //Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void CheckPointLocation_PointIsOutsideTheRectangle_ReturnsNo()
    {
        //Arrange
        double x = 71;
        double y = 71;
        string expected = "No";
        //Act
        string actual = Lab1Charp.CheckPointLocation(x, y);
        //Assert
        Assert.Equal(expected, actual);
    }
    
}