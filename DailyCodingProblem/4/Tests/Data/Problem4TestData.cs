using System;
using System.Collections;
using System.Collections.Generic;

namespace DailyCodingProblem._4.Tests.Data
{
	public class Problem4TestData : IEnumerable<object[]>
	{
		public IEnumerator<object[]> GetEnumerator()
		{
			yield return new object[] {new[] {3, 4, -1, 1}, 2};
			yield return new object[] {new[] {1, 2, 0}, 3};
			yield return new object[] {new[] {2, 3}, 1};
			yield return new object[] {new[] {2, 5}, 1};
			yield return new object[] {new[] {-1, -5}, 1};
			yield return new object[] {Array.Empty<object>(), 1};
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}