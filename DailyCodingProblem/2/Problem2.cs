using System.Collections.Generic;
using System.Linq;

namespace DailyCodingProblem._2
{
	public class Problem2
	{
		private readonly uint[] _numbers;

		public Problem2(uint[] numbers)
		{
			_numbers = numbers;
		}

		public IReadOnlyCollection<uint> Linq()
		{
			return _numbers
				.Select((number, index) => _numbers
					.Select((x, i) => i == index
						? 1
						: x)
					.Aggregate((result, item) => result * item))
				.ToList();
		}

		public IReadOnlyCollection<uint> For()
		{
			var output = new uint[_numbers.Length];

			for (var i = 0; i < _numbers.Length; i++)
			{
				uint result = 1;
				for (var j = 0; j < _numbers.Length; j++)
				{
					var number = j == i
						? 1
						: _numbers[j];

					result *= number;
				}

				output[i] = result;
			}

			return output;
		}
	}
}