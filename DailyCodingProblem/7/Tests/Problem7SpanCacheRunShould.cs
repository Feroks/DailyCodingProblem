using DailyCodingProblem._7.Tests.Data;
using FluentAssertions;
using Xunit;

namespace DailyCodingProblem._7.Tests
{
	public class Problem7SpanCacheRunShould
	{
		[Theory]
		[ClassData(typeof(Problem5TestData))]
		public void ReturnCorrectValue(string value, int expectedResult)
		{
			var fixture = new Problem7SpanCache();

			fixture
				.Run(value)
				.Should()
				.Be(expectedResult);
		} 
	}
}