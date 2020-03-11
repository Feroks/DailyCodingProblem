using DailyCodingProblem._1.Tests.Data;
using FluentAssertions;
using Xunit;

namespace DailyCodingProblem._1.Tests
{
	public class Problem1LinqShould : Problem1TestsBase
	{
		[Theory]
		[ClassData(typeof(Problem1SuccessTestData))]
		public void ReturnTrueIfElementsInCollectionFormNumber(int number)
		{
			var fixture = CreateClass();

			fixture
				.Linq(number)
				.Should()
				.BeTrue();
		}
		
		[Theory]
		[ClassData(typeof(Problem1FailTestData))]
		public void ReturnFalseIfElementsInCollectionDoNotFormNumber(int number)
		{
			var fixture = CreateClass();

			fixture
				.Linq(number)
				.Should()
				.BeFalse();
		}
	}
}