using DailyCodingProblem._2.Tests.Data;
using FluentAssertions;
using Xunit;

namespace DailyCodingProblem._2.Tests
{
	public class Problem2For3LoopsShould : Problem2TestsBase
	{
		[Theory]
		[ClassData(typeof(Problem2TestData))]
		public void ProcessElementsCorrectly(uint[] input, uint[] expectedResult)
		{
			var fixture = CreateClass(input);

			fixture
				.For3Loops()
				.Should()
				.ContainInOrder(expectedResult);
		} 
	}
}