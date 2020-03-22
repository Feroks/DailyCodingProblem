using System.Collections.Generic;
using System.Linq;

namespace DailyCodingProblem._11
{
    public class Problem11Linq : IProblem11
    {
        private readonly string[] _data;

        public Problem11Linq(string[] data)
        {
            _data = data;
        }

        public IReadOnlyCollection<string> Run(string input)
        {
            return _data
                .Where(x => x.StartsWith(input))
                .ToArray();
        }
    }
}