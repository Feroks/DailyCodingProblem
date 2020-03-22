using System;
using System.Collections.Generic;

namespace DailyCodingProblem._11
{
    public class Problem11ForSpan : IProblem11
    {
        private readonly string[] _data;

        public Problem11ForSpan(string[] data)
        {
            _data = data;
        }

        public IReadOnlyCollection<string> Run(string input)
        {
            var output = new string[0];
            var inputSpan = input.AsSpan();

            for (var i = 0; i < _data.Length; i++)
            {
                var item = _data[i];
                var itemSpan = item.AsSpan();

                if (!itemSpan.StartsWith(inputSpan))
                    continue;

                Array.Resize(ref output, output.Length + 1);
                output[^1] = item;
            }

            return output;
        }
    }
}