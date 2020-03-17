using System;

namespace DailyCodingProblem._7
{
	public class Problem7 : Problem7Base
	{
		public override int Run(string input)
		{
			return RunInternal(input);
		}

		private int RunInternal(string input)
		{
			// Sequence has ended
			if (input.Length == 0)
				return 1;

			return GetCombinationCountForNextSymbol(input) + GetCombinationCountForNextTwoSymbols(input);
		}

		private int GetCombinationCountForNextSymbol(string input)
		{
			return TryGetNext(input, 1, out _, out var rest)
				? RunInternal(rest)
				: 0;
		}
		
		private int GetCombinationCountForNextTwoSymbols(string input)
		{
			return TryGetNext(input, 2, out var next, out var rest)
					&& string.Compare(next, MaxSymbol, StringComparison.Ordinal) <= 0
				? RunInternal(rest)
				: 0;
		}

		private static bool TryGetNext(string input, int length, out string value, out string rest)
		{
			value = string.Empty;
			rest = string.Empty;

			if (input.Length < length)
				return false;

			value = input.Substring(0, length);
			rest = input.Substring(length);
			return true;
		}
	}
}