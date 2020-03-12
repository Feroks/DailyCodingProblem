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
		
		/// <summary>
		/// Copied from the internet
		/// </summary>
		/// <returns></returns>
		public IReadOnlyCollection<uint> For3Loops()
		{
			var length = _numbers.Length;
			
			var cumulativeLeft = new uint[length];
			var cumulativeRight = new uint[length];
			var output = new uint[length];

			cumulativeLeft[0] = 1;
			cumulativeRight[^1] = 1;

			for (var i = 1; i < length; i++)
			{
				cumulativeLeft[i] = cumulativeLeft[i - 1] * _numbers[i - 1];
			}
			
			for (var i = length - 2; i > -1; i--)
			{
				cumulativeRight[i] = cumulativeRight[i + 1] * _numbers[i + 1];
			}

			for (var i = 0; i < length; i++)
			{
				output[i] = cumulativeLeft[i] * cumulativeRight[i];
			}

			return output;
		}
		
		public IReadOnlyCollection<uint> For2Loops()
		{
			var length = _numbers.Length;
			
			var cumulativeLeft = new uint[length];
			var cumulativeRight = new uint[length];
			var output = new uint[length];

			cumulativeLeft[0] = 1;
			cumulativeRight[^1] = 1;

			for (var i = 1; i < length; i++)
			{
				cumulativeLeft[i] = cumulativeLeft[i - 1] * _numbers[i - 1];
				cumulativeRight[^(i + 1)] = cumulativeRight[^i] * _numbers[^i];
			}

			for (var i = 0; i < length; i++)
			{
				output[i] = cumulativeLeft[i] * cumulativeRight[i];
			}

			return output;
		}
	}
}