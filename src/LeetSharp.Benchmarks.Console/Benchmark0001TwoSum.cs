using BenchmarkDotNet.Attributes;
using LeetSharp.Solutions.Library;

namespace LeetSharp.Benchmarks.Console;

[MemoryDiagnoser]
public class Benchmark0001TwoSum
{
    private readonly Random _random = new();

    // Uncomment the data set to run the benchmark against.
    public IEnumerable<object[]> Data()
    {
        yield return [new[] { 3, 2, 4 }, 6];
        // yield return [new[] { 1 }.Concat(Enumerable.Range(2, 500)).Concat([1]).ToArray(), 2];
        // yield return [Enumerable.Range(2, 500).Concat([1, 1]).ToArray(), 2];
        // yield return
        // [
        //     Enumerable.Range(2, 500).Concat([1, 1]).OrderBy(_ => _random.Next()).ToArray(),
        //     2,
        // ];
    }

    [Benchmark(Baseline = true)]
    [ArgumentsSource(nameof(Data))]
    public int[] TwoSumBruteForce(int[] nums, int target) =>
        Problem0001TwoSum.TwoSumBruteForce(nums, target);

    [Benchmark]
    [ArgumentsSource(nameof(Data))]
    public int[] TwoSumTwoPassDictionary(int[] nums, int target) =>
        Problem0001TwoSum.TwoSumTwoPassDictionary(nums, target);

    [Benchmark]
    [ArgumentsSource(nameof(Data))]
    public int[] TwoSumOnePassDictionary(int[] nums, int target) =>
        Problem0001TwoSum.TwoSumOnePassDictionary(nums, target);
}
