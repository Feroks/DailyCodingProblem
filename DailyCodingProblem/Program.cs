using BenchmarkDotNet.Running;
using DailyCodingProblem._1.Benchmarks;

namespace DailyCodingProblem
{
	internal static class Program
	{
		private static void Main()
		{
			BenchmarkRunner.Run<Problem1Benchmarks>();
		}
	}
}