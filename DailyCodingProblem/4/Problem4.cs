using System;

namespace DailyCodingProblem._4
{
	public class Problem4
	{
		private readonly int[] _numbers;

		public Problem4(int[] numbers)
		{
			_numbers = numbers;
		}

		public int For()
		{
			Array.Sort(_numbers);
			
			var numbersCount = _numbers.Length;
			for (var i = 0; i < numbersCount; i++)
			{
				var number = _numbers[i];

				// Ignore negative values
				if (number < 1)
					continue;

				// If first element is greater 1, then first missing positive integer is 1
				if (i == 0 && number > 1)
					return 1;

				// If we reached and end then there is no missing integer in between, then take current number +1
				if (i == numbersCount - 1)
					return number + 1;

				// If difference between current number and next is greater than 1, then integer is skipped
				if (_numbers[i + 1] - number > 1)
					return number + 1;
			}

			// Array has no elements
			return 1;
		}

	}
}