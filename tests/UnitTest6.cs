namespace tests;

using Lab1Charp;
public class UnitTest6
{
    [Fact]
    public void Test2()
    {
        double x = 1;
        double y = 1;
        double expected = 1.625;
        double actual = Lab1Charp.CalculateExpression(x, y);
        Assert.Equal(expected, actual);
    }
}