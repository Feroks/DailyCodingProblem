﻿using System;

namespace DailyCodingProblem._7
{
	public abstract class Problem7SpanBase : Problem7Base
	{
		protected static ReadOnlySpan<char> MaxSymbolSpan => MaxSymbol.AsSpan();

		protected static bool TryGetNextSpan(ReadOnlySpan<char> input, int length, out ReadOnlySpan<char> value,
			out ReadOnlySpan<char> rest)
		{
			value = Span<char>.Empty;
			rest = Span<char>.Empty;

			if (input.Length < length)
				return false;

			value = input.Slice(0, length);
			rest = input.Slice(length);

			return true;
		}
	}
}