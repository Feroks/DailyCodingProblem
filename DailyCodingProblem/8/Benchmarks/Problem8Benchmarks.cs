using System;
using System.IO;
using System.Reflection;
using BenchmarkDotNet.Attributes;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace DailyCodingProblem._8.Benchmarks
{
	[MemoryDiagnoser]
	public class Problem8Benchmarks
	{
		private readonly Problem8Linq _problemLinq = new Problem8Linq();
		private readonly Problem8For _problemFor = new Problem8For();

		private Node _testData;

		[UsedImplicitly]
		[Params("tree1.json", "tree2.json", "tree3.json")]
		public string InputFile { get; set; }

		[IterationSetup]
		public void IterationSetup()
		{
			using var stream = Assembly
				.GetExecutingAssembly()
				.GetManifestResourceStream($"DailyCodingProblem._8.Benchmarks.Data.{InputFile}");

			if (stream == null)
				throw new ArgumentNullException(nameof(stream));

			using var textReader = new StreamReader(stream);
			using var reader = new JsonTextReader(textReader);
			var serializer = new JsonSerializer();
			_testData = serializer.Deserialize<Node>(reader);
		}

		[Benchmark]
		public void Linq() => _problemLinq.Run(_testData);
		
		[Benchmark]
		public void For() => _problemFor.Run(_testData);
	}
}