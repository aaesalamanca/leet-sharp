namespace LeetSharp.Solutions.Library.UnitTest;

public class Test2235AddTwoIntegers
{
    [Theory]
    [InlineData(12, 5, 17)]
    [InlineData(-10, 4, -6)]
    public void AddTwoIntegers_ReturnsTarget(int num1, int num2, int expected) =>
        Assert.Equal(expected, Problem2235AddTwoIntegers.Sum(num1, num2));
}
