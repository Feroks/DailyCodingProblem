using System;
using System.Collections;
using System.Collections.Generic;

namespace DailyCodingProblem._8.Tests.Data
{
	public class Problem8TestData : IEnumerable<object[]>
	{
		private Node[] EmptyNodes => Array.Empty<Node>();
		
		public IEnumerator<object[]> GetEnumerator()
		{
			yield return new object[] {CreateTree1(), 5};
			yield return new object[] {CreateTree2(), 6};
			yield return new object[] {CreateTree3(), 4};
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		/// <summary>
		/// <code>
		///    0
		///   / \
		/// 1   0
		///    / \
		///   1   0
		///  / \
		/// 1   1
		/// </code>
		/// </summary>
		private Node CreateTree1()
		{
			return new Node(
				0,
				new[]
				{
					new Node(1, Array.Empty<Node>()),
					new Node(
						0,
						new[]
						{
							new Node(0, EmptyNodes),
							new Node(
								1,
								new[]
								{
									new Node(1, EmptyNodes),
									new Node(1, EmptyNodes),
								}),
						}),
				});
		}

		/// <summary>
		/// <code>
		///       0
		///     / \
		///    0   0
		///  / \    \
		/// 0   0    0
		/// </code>
		/// </summary>
		private Node CreateTree2()
		{
			return new Node(
				0,
				new[]
				{
					new Node(
						0,
						new[]
						{
							new Node(0, EmptyNodes)
						}),
					new Node(
						0,
						new[]
						{
							new Node(0, EmptyNodes),
							new Node(0, EmptyNodes)
						}),
				});
		}
		
		/// <summary>
		/// <code>
		///       0
		///     / \
		///    1   0
		///  / \    \
		/// 0   0    0
		/// </code>
		/// </summary>
		private Node CreateTree3()
		{
			return new Node(
				0,
				new[]
				{
					new Node(
						0,
						new[]
						{
							new Node(0, EmptyNodes)
						}),
					new Node(
						1,
						new[]
						{
							new Node(0, EmptyNodes),
							new Node(0, EmptyNodes)
						}),
				});
		}
	}
}