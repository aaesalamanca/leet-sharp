namespace LeetSharp.Solutions.Library;

public static class Problem0001TwoSum
{
    public static int[] TwoSumBruteForce(int[] nums, int target)
    {
        int complement;
        for (int i = 0; i < nums.Length - 1; i++)
        {
            complement = target - nums[i];
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[j] == complement)
                {
                    return [i, j];
                }
            }
        }

        return [];
    }

    public static int[] TwoSumTwoPassDictionary(int[] nums, int target)
    {
        var indexes = new Dictionary<int, int>(nums.Length);

        for (int i = 0; i < nums.Length; i++)
        {
            indexes[nums[i]] = i;
        }

        int complement;
        for (int i = 0; i < nums.Length; i++)
        {
            complement = target - nums[i];
            if (indexes.TryGetValue(complement, out var index) && index != i)
            {
                return [i, index];
            }
        }

        return [];
    }

    public static int[] TwoSumOnePassDictionary(int[] nums, int target)
    {
        var indexes = new Dictionary<int, int>(nums.Length);

        int complement;
        for (int i = 0; i < nums.Length; i++)
        {
            complement = target - nums[i];
            if (indexes.TryGetValue(complement, out var index))
            {
                return [index, i];
            }

            indexes[nums[i]] = i;
        }

        return [];
    }
}
