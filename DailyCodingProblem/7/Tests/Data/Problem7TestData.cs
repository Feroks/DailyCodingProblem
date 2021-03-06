﻿using System.Collections;
using System.Collections.Generic;

namespace DailyCodingProblem._7.Tests.Data
{
	public class Problem7TestData : IEnumerable<object[]>
	{
		public IEnumerator<object[]> GetEnumerator()
		{
			yield return new object[] {"111", 3};
			yield return new object[] {"1234", 3};
			yield return new object[] {"121315", 10};
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}