using System.Collections;
using System.Collections.Generic;

namespace DailyCodingProblem._2.Tests.Data
{
	public class Problem2TestData : IEnumerable<object[]>
	{
		public IEnumerator<object[]> GetEnumerator()
		{
			yield return new object[] {new[] {1, 2, 3, 4, 5}, new[] {120, 60, 40, 30, 24}};
			yield return new object[] {new[] {3, 2, 1}, new[] {2, 3, 6}};
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}