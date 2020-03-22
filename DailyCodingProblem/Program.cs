using BenchmarkDotNet.Running;
using DailyCodingProblem._1.Benchmarks;
using DailyCodingProblem._11.Benchmarks;
using DailyCodingProblem._2.Benchmarks;
using DailyCodingProblem._4.Benchmarks;
using DailyCodingProblem._7.Benchmarks;
using DailyCodingProblem._8.Benchmarks;

namespace DailyCodingProblem
{
	internal static class Program
	{
		private static void Main()
		{
			// BenchmarkRunner.Run<Problem1Benchmarks>();
			// BenchmarkRunner.Run<Problem2Benchmarks>();
			// BenchmarkRunner.Run<Problem4Benchmarks>();
			// BenchmarkRunner.Run(typeof(Problem7Benchmarks));
			// BenchmarkRunner.Run(typeof(Problem8Benchmarks));
			BenchmarkRunner.Run(typeof(Problem11Benchmarks));
		}
	}
}