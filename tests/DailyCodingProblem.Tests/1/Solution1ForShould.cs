using DailyCodingProblem.Tests._1.Data;
using FluentAssertions;
using Xunit;

namespace DailyCodingProblem.Tests._1
{
	public class Solution1ForShould : Solution1TestsBase
	{
		[Theory]
		[ClassData(typeof(Solution1SuccessTestData))]
		public void ReturnTrueIfElementsInCollectionFormNumber(int number)
		{
			var fixture = CreateClass();

			fixture
				.For(number)
				.Should()
				.BeTrue();
		}
		
		[Theory]
		[ClassData(typeof(Solution1FailTestData))]
		public void ReturnFalseIfElementsInCollectionDoNotFormNumber(int number)
		{
			var fixture = CreateClass();

			fixture
				.For(number)
				.Should()
				.BeFalse();
		}
	}
}