using System.Linq;
using BenchmarkDotNet.Attributes;
using JetBrains.Annotations;

namespace DailyCodingProblem._4.Benchmarks
{
	[MemoryDiagnoser]
	public class Problem4Benchmarks
	{
		private Problem4 _problem;

		[IterationSetup]
		public void IterationSetup()
		{
			var numbers = Enumerable
				.Range(1, ElementCount)
				.ToArray();
			
			_problem = new Problem4(numbers);
		}

		[UsedImplicitly]
		[Params(5, 500, 5000)]
		public int ElementCount { get; set; }

		[Benchmark]
		public void For() => _problem.For();
	}
}