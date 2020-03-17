using System;
using System.Collections.Generic;

namespace DailyCodingProblem._7
{
	public class Problem7SpanCache : Problem7SpanBase
	{
		private readonly Dictionary<int, int> _paths = new Dictionary<int, int>();

		public override int Run(string input)
		{
			return RunInternal(input.AsSpan(), 0);
		}

		private int RunInternal(ReadOnlySpan<char> input, int index)
		{
			// Sequence has ended
			if (input.Length == 0)
				return 1;
			
			// Check if count was already checked
			if (_paths.TryGetValue(index, out var pathCount))
				return pathCount;

			var combinationCount = GetCombinationCountForNextSymbol(input, index) +
									GetCombinationCountForNextTwoSymbols(input, index);

			// Cache how many paths are available for rest of string, if it repeats
			_paths.Add(index, combinationCount);
			return combinationCount;
		}

		private int GetCombinationCountForNextSymbol(ReadOnlySpan<char> input, int index)
		{
			return TryGetNextSpan(input, 1, out _, out var rest)
				? RunInternal(rest, index + 1)
				: 0;
		}

		private int GetCombinationCountForNextTwoSymbols(ReadOnlySpan<char> input, int index)
		{
			return TryGetNextSpan(input, 2, out var next, out var rest)
					&& next.CompareTo(MaxSymbolSpan, StringComparison.OrdinalIgnoreCase) <= 0
				? RunInternal(rest, index + 2)
				: 0;
		}
	}
}