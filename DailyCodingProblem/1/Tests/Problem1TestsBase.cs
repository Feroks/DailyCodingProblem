namespace DailyCodingProblem._1.Tests
{
	public abstract class Problem1TestsBase
	{
		protected static Problem1 CreateClass()
		{
			var numbers = new[] {10, 15, 3, 7};
			return new Problem1(numbers);
		}
	}
}