namespace LeetSharp.Solutions.Library.UnitTest;

public class Test0001TwoSum
{
    [Theory]
    [InlineData(new[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 })]
    [InlineData(new[] { 3, 2, 4 }, 6, new[] { 1, 2 })]
    [InlineData(new[] { 3, 3 }, 6, new[] { 0, 1 })]
    public void TwoSum_ReturnsTarget(int[] nums, int target, int[] expected)
    {
        Assert.Equal(expected, Problem0001TwoSum.TwoSumBruteForce(nums, target));
        Assert.Equal(expected, Problem0001TwoSum.TwoSumTwoPassDictionary(nums, target));
        Assert.Equal(expected, Problem0001TwoSum.TwoSumOnePassDictionary(nums, target));
    }
}
