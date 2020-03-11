using System.Linq;

namespace DailyCodingProblem._1
{
	public class Solution1
	{
		private readonly int[] _numbers;

		public Solution1(int[] numbers)
		{
			_numbers = numbers;
		}

		public bool Linq(int number)
		{
			return _numbers
				.Select((x, index) => _numbers
					// Filter out previous and yourself
					.Skip(index + 1)
					.Any(y => y + x == number))
				.Any(x => x);
		}
		
		public bool LinqParallel(int number)
		{
			return _numbers
				.AsParallel()
				.Select((x, index) => _numbers
					// Filter out previous and yourself
					.Skip(index + 1)
					.Any(y => y + x == number))
				.Any(x => x);
		}

		public bool For(int number)
		{
			for (var i = 0; i < _numbers.Length; i++)
			{
				for (var j = i + 1; j < _numbers.Length; j++)
				{
					var sum = _numbers[i] + _numbers[j];
					if (sum == number)
						return true;
				}
			}

			return false;
		}
	}
}