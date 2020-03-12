using System;
using System.Linq;
using System.Security.Cryptography;
using BenchmarkDotNet.Attributes;
using JetBrains.Annotations;

namespace DailyCodingProblem._2.Benchmarks
{
	[MemoryDiagnoser]
	public class Problem2Benchmarks
	{
		private Problem2 _problem;

		[IterationSetup]
		public void IterationSetup()
		{
			var numbers = Enumerable
				.Range(1, ElementCount)
				.Select(_ => RandomNumberGenerator.GetInt32(1, 9))
				.Select(Convert.ToUInt32)
				.ToArray();
			
			_problem = new Problem2(numbers);
		}

		[UsedImplicitly]
		[Params(5, 50, 500)]
		public int ElementCount { get; set; }

		[Benchmark]
		public void Linq() => _problem.Linq();
		
		[Benchmark]
		public void For() => _problem.For();
		
		[Benchmark]
		public void For3Loops() => _problem.For3Loops();
	}
}