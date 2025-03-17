namespace LeetSharp.Solutions.Library.UnitTest;

using static Problem2235AddTwoIntegers;

public class Test2235AddTwoIntegers
{
    [Theory]
    [InlineData(12, 5, 17)]
    [InlineData(-10, 4, -6)]
    public void AddTwoIntegers_ReturnsTarget(int num1, int num2, int expected) =>
        Assert.Equal(expected, Sum(num1, num2));
}
