namespace DailyCodingProblem._2.Tests
{
	public abstract class Problem2TestsBase
	{
		protected static Problem2 CreateClass(uint[] numbers)
		{
			return new Problem2(numbers);
		}
	}
}