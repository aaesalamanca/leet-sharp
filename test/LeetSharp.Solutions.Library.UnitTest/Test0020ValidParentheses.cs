namespace LeetSharp.Solutions.Library.UnitTest;

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
        Assert.Equal(expected, Problem0020ValidParentheses.IsValid(s));
}
