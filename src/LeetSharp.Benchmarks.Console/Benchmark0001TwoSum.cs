using BenchmarkDotNet.Attributes;
using static LeetSharp.Solutions.Library.Problem0001TwoSum;

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
    public int[] Bench_TwoSumBruteForce(int[] nums, int target) => TwoSumBruteForce(nums, target);

    [Benchmark]
    [ArgumentsSource(nameof(Data))]
    public int[] Bench_TwoSumTwoPassDictionary(int[] nums, int target) =>
        TwoSumTwoPassDictionary(nums, target);

    [Benchmark]
    [ArgumentsSource(nameof(Data))]
    public int[] Bench_TwoSumOnePassDictionary(int[] nums, int target) =>
        TwoSumOnePassDictionary(nums, target);
}
