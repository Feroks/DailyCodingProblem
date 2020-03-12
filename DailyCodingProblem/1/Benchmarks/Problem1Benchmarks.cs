using System.Linq;
using BenchmarkDotNet.Attributes;
using JetBrains.Annotations;

namespace DailyCodingProblem._1.Benchmarks
{
	[MemoryDiagnoser]
	public class Problem1Benchmarks
	{
		private readonly Problem1 _problem;

		public Problem1Benchmarks()
		{
			var numbers = Enumerable
				.Range(0, 1000000)
				.ToArray();

			_problem = new Problem1(numbers);
		}

		[UsedImplicitly]
		[Params(546, 11239)]
		public int Number { get; set; }

		[Benchmark]
		public void Linq() => _problem.Linq(Number);
		
		[Benchmark]
		public void LinqParallel() => _problem.LinqParallel(Number);
		
		[Benchmark]
		public void For() => _problem.For(Number);
	}
}