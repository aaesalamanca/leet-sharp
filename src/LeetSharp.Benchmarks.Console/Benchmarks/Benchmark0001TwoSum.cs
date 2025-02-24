using BenchmarkDotNet.Attributes;
using LeetSharp.Solutions.Library.Implementations.Problem0001TwoSum;

namespace LeetSharp.Benchmarks.Console.Benchmarks;

[MemoryDiagnoser]
public class Benchmark0001TwoSum
{
    private readonly Random _random = new();
    private readonly BruteForce _bruteForce = new();
    private readonly TwoPassDictionary _twoPassDictionary = new();
    private readonly OnePassDictionary _onePassDictionary = new();

    // Uncomment the data set to run the benchmark against.
    public IEnumerable<object[]> Data()
    {
        // yield return [new[] { 3, 2, 4 }, 6];
        // yield return [new[] { 1 }.Concat(Enumerable.Range(2, 500)).Concat([1]).ToArray(), 2];
        // yield return [Enumerable.Range(2, 500).Concat([1, 1]).ToArray(), 2];
        yield return
        [
            Enumerable.Range(2, 500).Concat([1, 1]).OrderBy(_ => _random.Next()).ToArray(),
            2,
        ];
    }

    [Benchmark(Baseline = true)]
    [ArgumentsSource(nameof(Data))]
    public int[] BruteForce(int[] nums, int target) => _bruteForce.TwoSum(nums, target);

    [Benchmark]
    [ArgumentsSource(nameof(Data))]
    public int[] TwoPassDictionary(int[] nums, int target) =>
        _twoPassDictionary.TwoSum(nums, target);

    [Benchmark]
    [ArgumentsSource(nameof(Data))]
    public int[] OnePassDictionary(int[] nums, int target) =>
        _onePassDictionary.TwoSum(nums, target);
}
