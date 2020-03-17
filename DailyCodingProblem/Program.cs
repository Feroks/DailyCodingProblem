using BenchmarkDotNet.Running;
using DailyCodingProblem._1.Benchmarks;
using DailyCodingProblem._2.Benchmarks;
using DailyCodingProblem._4.Benchmarks;
using DailyCodingProblem._5.Tests.Benchmarks;

namespace DailyCodingProblem
{
	internal static class Program
	{
		private static void Main()
		{
			// BenchmarkRunner.Run<Problem1Benchmarks>();
			// BenchmarkRunner.Run<Problem2Benchmarks>();
			// BenchmarkRunner.Run<Problem4Benchmarks>();
			BenchmarkRunner.Run(typeof(Problem5Benchmarks));
		}
	}
}