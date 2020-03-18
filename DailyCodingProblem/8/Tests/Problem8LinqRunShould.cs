using DailyCodingProblem._8.Tests.Data;
using FluentAssertions;
using Xunit;

namespace DailyCodingProblem._8.Tests
{
	public class Problem8LinqRunShould
	{
		[Theory]
		[ClassData(typeof(Problem8TestData))]
		public void ReturnCorrectValue(Node node, int expectedResult)
		{
			var fixture = CreateClass();

			fixture
				.Run(node)
				.Should()
				.Be(expectedResult);
		}

		private static Problem8Linq CreateClass()
		{
			return new Problem8Linq();
		}
	}
}