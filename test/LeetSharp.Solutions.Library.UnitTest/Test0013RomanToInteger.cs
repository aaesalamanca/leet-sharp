using LeetSharp.Solutions.Library.Implementations;
using LeetSharp.Solutions.Library.Interfaces;

namespace LeetSharp.Solutions.Library.UnitTest;

public class Test0013RomanToInteger
{
    [Theory]
    [InlineData("III", 3)]
    [InlineData("LVIII", 58)]
    [InlineData("MCMXCIV", 1994)]
    public void RomanToInteger_ReturnsTarget(string s, int expected)
    {
        // Arrange.
        IProblem0013RomanToInteger sut = new Problem0013RomanToInteger();

        // Act.
        var actual = sut.RomanToInt(s);

        // Assert.
        Assert.Equal(expected, actual);
    }
}
