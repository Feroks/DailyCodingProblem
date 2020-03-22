using DailyCodingProblem._11.Tests.Data;
using FluentAssertions;
using Xunit;

namespace DailyCodingProblem._11.Tests
{
    public class Problem11ForRunShould
    {
        [Theory]
        [ClassData(typeof(Problem11TestData))]
        public void ReturnCorrectValue(string[] data, string input, string[] expectedResult)
        {
            var fixture = CreateClass(data);

            fixture
                .Run(input)
                .Should()
                .ContainInOrder(expectedResult);
        }

        private static Problem11For CreateClass(string[] data)
        {
            return new Problem11For(data);
        }
    }
}