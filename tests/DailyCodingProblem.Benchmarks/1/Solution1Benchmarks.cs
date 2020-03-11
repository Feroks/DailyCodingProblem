using System.Linq;
using BenchmarkDotNet.Attributes;
using DailyCodingProblem._1;
using JetBrains.Annotations;

namespace DailyCodingProblem.Benchmarks._1
{
	[MemoryDiagnoser]
	public class Solution1Benchmarks
	{
		private readonly Solution1 _solution1;

		public Solution1Benchmarks()
		{
			var numbers = Enumerable
				.Range(0, 1000000)
				.ToArray();

			_solution1 = new Solution1(numbers);
		}

		[UsedImplicitly]
		[Params(546, 11239)]
		public int Number { get; set; }

		[Benchmark]
		public void Linq() => _solution1.Linq(Number);
		
		[Benchmark]
		public void LinqParallel() => _solution1.LinqParallel(Number);
		
		[Benchmark]
		public void For() => _solution1.For(Number);
	}
}