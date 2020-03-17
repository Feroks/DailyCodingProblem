using DailyCodingProblem._5.Tests.Data;
using FluentAssertions;
using Xunit;

namespace DailyCodingProblem._5.Tests
{
	public class Problem5SpanRunShould
	{
		[Theory]
		[ClassData(typeof(Problem5TestData))]
		public void ReturnCorrectValue(string value, int expectedResult)
		{
			var fixture = new Problem5Span();

			fixture
				.Run(value)
				.Should()
				.Be(expectedResult);
		} 
	}
}