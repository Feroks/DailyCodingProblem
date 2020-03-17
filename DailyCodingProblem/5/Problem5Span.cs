using System;

namespace DailyCodingProblem._5
{
	public class Problem5Span : Problem5SpanBase
	{
		public override int Run(string input)
		{
			return RunInternal(input.AsSpan());
		}

		private int RunInternal(ReadOnlySpan<char> input)
		{
			// Sequence has ended
			if (input.Length == 0)
				return 1;

			return GetCombinationCountForNextSymbol(input) + GetCombinationCountForNextTwoSymbols(input);
		}

		private int GetCombinationCountForNextSymbol(ReadOnlySpan<char> input)
		{
			return TryGetNextSpan(input, 1, out _, out var rest) 
				? RunInternal(rest) 
				: 0;
		}
		
		private int GetCombinationCountForNextTwoSymbols(ReadOnlySpan<char> input)
		{
			return TryGetNextSpan(input, 2, out var next, out var rest)
					&& next.CompareTo(MaxSymbolSpan, StringComparison.OrdinalIgnoreCase) <= 0
				? RunInternal(rest)
				: 0;
		}
	}
}