using LeetSharp.Solutions.Library.Interfaces;
using Solution = LeetSharp.Solutions.Library.Implementations.Problem2235AddTwoIntegers;

namespace LeetSharp.Solutions.Library.UnitTest;

public class Test2235AddTwoIntegers
{
    [Theory]
    [InlineData(12, 5, 17)]
    [InlineData(-10, 4, -6)]
    public void AddTwoIntegers_ReturnsTarget(int num1, int num2, int expected)
    {
        // Arrange.
        IProblem2235AddTwoIntegers sut = new Solution();

        // Act.
        var actual = sut.Sum(num1, num2);

        // Assert.
        Assert.Equal(expected, actual);
    }
}
