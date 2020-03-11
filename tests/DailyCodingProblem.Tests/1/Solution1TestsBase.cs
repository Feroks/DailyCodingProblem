using DailyCodingProblem._1;

namespace DailyCodingProblem.Tests._1
{
	public abstract class Solution1TestsBase
	{
		protected static Solution1 CreateClass()
		{
			var numbers = new[] {10, 15, 3, 7};
			return new Solution1(numbers);
		}
	}
}