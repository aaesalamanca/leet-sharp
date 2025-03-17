namespace LeetSharp.Solutions.Library.UnitTest;

using static Problem0013RomanToInteger;

public class Test0013RomanToInteger
{
    [Theory]
    [InlineData("III", 3)]
    [InlineData("LVIII", 58)]
    [InlineData("MCMXCIV", 1994)]
    public void RomanToInt_ReturnsTarget(string s, int expected) =>
        Assert.Equal(expected, RomanToInt(s));
}
