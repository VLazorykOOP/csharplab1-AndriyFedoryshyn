namespace tests;

using Lab1Charp;
public class UnitTest2
{
    [Fact]
    public void CheckDigits_ThreeDigitNumber_ReturnsFirstDigitIsBigger()
    {
        // Arrange
        int number = 123;

        // Act
        string result = Lab1Charp.CheckDigits(number);

        // Assert
        Assert.Equal("Last digit is bigger", result);
    }

    [Fact]
    public void CheckDigits_ThreeDigitNumber_ReturnsLastDigitIsBigger()
    {
        // Arrange
        int number = 321;

        // Act
        string result = Lab1Charp.CheckDigits(number);

        // Assert
        Assert.Equal("First digit is bigger", result);
    }

    [Fact]
    public void CheckDigits_ThreeDigitNumber_ReturnsFirstAndLastDigitsAreEqual()
    {
        // Arrange
        int number = 111;

        // Act
        string result = Lab1Charp.CheckDigits(number);

        // Assert
        Assert.Equal("First and last digits are equal", result);
    }

    [Fact]
    public void CheckDigits_NotThreeDigitNumber_ReturnsNumberIsNotThreeDigit()
    {
        // Arrange
        int number = 12;

        // Act
        string result = Lab1Charp.CheckDigits(number);

        // Assert
        Assert.Equal("Number is not three-digit", result);
    }

}