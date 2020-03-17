using BenchmarkDotNet.Attributes;
using JetBrains.Annotations;

namespace DailyCodingProblem._5.Tests.Benchmarks
{
	[MemoryDiagnoser]
	public class Problem5Benchmarks
	{
		private readonly Problem5 _problem = new Problem5();
		private readonly Problem5Span _problemSpan = new Problem5Span();
		private readonly Problem5SpanCache _problemSpanCache = new Problem5SpanCache();

		[UsedImplicitly]
		[Params("127589623153453", "21408799411236805823401923123053")]
		public string Sequence { get; set; }

		[Benchmark]
		public void Recursion() => _problem.Run(Sequence);
		
		[Benchmark]
		public void RecursionSpan() => _problemSpan.Run(Sequence);
		
		[Benchmark]
		public void RecursionSpanPath() => _problemSpanCache.Run(Sequence);
	}
}