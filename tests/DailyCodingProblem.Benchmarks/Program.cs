using BenchmarkDotNet.Running;
using DailyCodingProblem.Benchmarks._1;

namespace DailyCodingProblem.Benchmarks
{
	internal static class Program
	{
		private static void Main()
		{
			BenchmarkRunner.Run<Solution1Benchmarks>();
		}
	}
}