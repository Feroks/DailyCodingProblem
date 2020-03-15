using DailyCodingProblem._4.Tests.Data;
using FluentAssertions;
using Xunit;

namespace DailyCodingProblem._4.Tests
{
	public class Problem4ForShould : Problem4TestsBase
	{
		[Theory]
		[ClassData(typeof(Problem4TestData))]
		public void ReturnCorrectValue(int[] input, int expectedResult)
		{
			var fixture = CreateClass(input);

			fixture
				.For()
				.Should()
				.Be(expectedResult);
		} 
	}
}