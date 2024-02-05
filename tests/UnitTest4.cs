namespace tests;

using Lab1Charp;
public class UnitTest4
{
    [Fact]
    public void EvaluateTest_100_Excellent()
    {
        //Arrange
        int mark = 100;
        string expected = "Excellent";
        //Act
        string actual = Lab1Charp.EvaluateTest(mark);
        //Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void EvaluateTest_89_Good()
    {
        //Arrange
        int mark = 89;
        string expected = "Good";
        //Act
        string actual = Lab1Charp.EvaluateTest(mark);
        //Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void EvaluateTest_69_Satisfactory()
    {
        //Arrange
        int mark = 69;
        string expected = "Satisfactory";
        //Act
        string actual = Lab1Charp.EvaluateTest(mark);
        //Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void EvaluateTest_49_Unsatisfactory()
    {
        //Arrange
        int mark = 49;
        string expected = "Unsatisfactory";
        //Act
        string actual = Lab1Charp.EvaluateTest(mark);
        //Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void EvaluateTest_101_InvalidInput()
    {
        //Arrange
        int mark = 101;
        string expected = "Invalid Input";
        //Act
        string actual = Lab1Charp.EvaluateTest(mark);
        //Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void EvaluateTest_Error_Error()
    {
        //Arrange
        int mark = -1;
        string expected = "Invalid Input";
        //Act
        string actual = Lab1Charp.EvaluateTest(mark);
        //Assert
        Assert.Equal(expected, actual);
    }
}