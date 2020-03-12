using BenchmarkDotNet.Running;
using DailyCodingProblem._1.Benchmarks;
using DailyCodingProblem._2.Benchmarks;

namespace DailyCodingProblem
{
	internal static class Program
	{
		private static void Main()
		{
			// BenchmarkRunner.Run<Problem1Benchmarks>();
			BenchmarkRunner.Run<Problem2Benchmarks>();
		}
	}
}