namespace DailyCodingProblem._4.Tests
{
	public abstract class Problem4TestsBase
	{
		protected static Problem4 CreateClass(int[] numbers)
		{
			return new Problem4(numbers);
		}
	}
}