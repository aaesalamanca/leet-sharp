namespace LeetSharp.Solutions.Library.UnitTest;

using static Problem0020ValidParentheses;

public class Test0020ValidParentheses
{
    [Theory]
    [InlineData("()", true)]
    [InlineData("()[]{}", true)]
    [InlineData("(]", false)]
    [InlineData("([])", true)]
    [InlineData("]", false)]
    [InlineData("){", false)]
    [InlineData("(])", false)]
    public void ValidParentheses_ReturnsTarget(string s, bool expected) =>
        Assert.Equal(expected, IsValid(s));
}
