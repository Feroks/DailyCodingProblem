using System.Collections;
using System.Collections.Generic;

namespace DailyCodingProblem.Tests._1.Data
{
	public class Solution1FailTestData : IEnumerable<object[]>
	{
		public IEnumerator<object[]> GetEnumerator()
		{
			yield return new object[] {2};
			yield return new object[] {20};
			yield return new object[] {50};
			yield return new object[] {100};
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}