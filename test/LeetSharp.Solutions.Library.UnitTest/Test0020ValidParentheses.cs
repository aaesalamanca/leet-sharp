using LeetSharp.Solutions.Library.Interfaces;
using Solution = LeetSharp.Solutions.Library.Implementations.Problem0020ValidParentheses;

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
    public void ValidParentheses_ReturnsTarget(string s, bool expected)
    {
        // Arrange.
        IProblem0020ValidParentheses sut = new Solution();

        // Act.
        var actual = sut.IsValid(s);

        // Assert.
        Assert.Equal(expected, actual);
    }
}
