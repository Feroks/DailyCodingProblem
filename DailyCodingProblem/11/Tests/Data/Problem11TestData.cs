using System.Collections;
using System.Collections.Generic;

namespace DailyCodingProblem._11.Tests.Data
{
    public class Problem11TestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] {new[] {"dog", "deer", "deal"}, "de", new[] {"deer", "deal"}};
            yield return new object[] {new[] {"dog", "deer", "deal"}, "do", new[] {"dog"}};
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}