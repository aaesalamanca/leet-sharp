namespace LeetSharp.Solutions.Library.UnitTest;

public class Test0013RomanToInteger
{
    [Theory]
    [InlineData("III", 3)]
    [InlineData("LVIII", 58)]
    [InlineData("MCMXCIV", 1994)]
    public void RomanToInteger_ReturnsTarget(string s, int expected) =>
        Assert.Equal(expected, Problem0013RomanToInteger.RomanToInt(s));
}
