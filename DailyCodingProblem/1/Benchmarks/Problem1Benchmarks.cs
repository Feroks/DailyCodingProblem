using System.Linq;
using BenchmarkDotNet.Attributes;
using JetBrains.Annotations;

namespace DailyCodingProblem._1.Benchmarks
{
	[MemoryDiagnoser]
	public class Problem1Benchmarks
	{
		private readonly Problem1 _problem1;

		public Problem1Benchmarks()
		{
			var numbers = Enumerable
				.Range(0, 1000000)
				.ToArray();

			_problem1 = new Problem1(numbers);
		}

		[UsedImplicitly]
		[Params(546, 11239)]
		public int Number { get; set; }

		[Benchmark]
		public void Linq() => _problem1.Linq(Number);
		
		[Benchmark]
		public void LinqParallel() => _problem1.LinqParallel(Number);
		
		[Benchmark]
		public void For() => _problem1.For(Number);
	}
}