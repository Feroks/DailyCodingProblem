﻿using DailyCodingProblem._7.Tests.Data;
using FluentAssertions;
using Xunit;

namespace DailyCodingProblem._7.Tests
{
	public class Problem7RunShould
	{
		[Theory]
		[ClassData(typeof(Problem7TestData))]
		public void ReturnCorrectValue(string value, int expectedResult)
		{
			var fixture = new Problem7();

			fixture
				.Run(value)
				.Should()
				.Be(expectedResult);
		}
	}
}