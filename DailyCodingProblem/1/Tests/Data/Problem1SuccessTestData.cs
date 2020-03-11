using System.Collections;
using System.Collections.Generic;

namespace DailyCodingProblem._1.Tests.Data
{
	public class Problem1SuccessTestData : IEnumerable<object[]>
	{
		public IEnumerator<object[]> GetEnumerator()
		{
			yield return new object[] {10};
			yield return new object[] {17};
			yield return new object[] {25};
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}