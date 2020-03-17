using BenchmarkDotNet.Attributes;
using JetBrains.Annotations;

namespace DailyCodingProblem._7.Benchmarks
{
	[MemoryDiagnoser]
	public class Problem7Benchmarks
	{
		private readonly Problem7 _problem = new Problem7();
		private readonly Problem7Span _problemSpan = new Problem7Span();
		private readonly Problem7SpanCache _problemSpanCache = new Problem7SpanCache();

		[UsedImplicitly]
		[Params("127589623153453", "21408799411236805823401923123053")]
		public string Sequence { get; set; }

		[Benchmark]
		public void Recursion() => _problem.Run(Sequence);
		
		[Benchmark]
		public void RecursionSpan() => _problemSpan.Run(Sequence);
		
		[Benchmark]
		public void RecursionSpanCache() => _problemSpanCache.Run(Sequence);
	}
}