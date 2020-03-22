using System.Linq;
using System.Security.Cryptography;
using BenchmarkDotNet.Attributes;
using JetBrains.Annotations;

namespace DailyCodingProblem._11.Benchmarks
{
    [MemoryDiagnoser]
    public class Problem11Benchmarks
    {
        private Problem11Linq _problem11Linq;
        private Problem11For _problem11For;
        private Problem11ForSpan _problem11ForSpan;

        [GlobalSetup]
        public void IterationSetup()
        {
            var data = Enumerable
                .Range(0, StringCount)
                .Select(_ => Enumerable
                    .Range(0, StringLength)
                    .Select(__ => (char) RandomNumberGenerator.GetInt32(65, 122)))
                .Select(x => new string(x.ToArray()))
                .ToArray();
            
            _problem11Linq = new Problem11Linq(data);
            _problem11For = new Problem11For(data);
            _problem11ForSpan = new Problem11ForSpan(data);
        }

        [UsedImplicitly] 
        [Params(1000)]
        public int StringCount { get; set; }

        [UsedImplicitly]
        [Params(100)]
        public int StringLength { get; set; }

        [UsedImplicitly]
        [Params("de", "dema")]
        public string SearchText { get; set; }

        [Benchmark]
        public void Linq() => _problem11Linq.Run(SearchText);
        
        [Benchmark]
        public void For() => _problem11For.Run(SearchText);
        
        [Benchmark]
        public void ForSpan() => _problem11ForSpan.Run(SearchText);
    }
}