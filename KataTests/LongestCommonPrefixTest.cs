using System;
using System.Collections.Generic;
using System.Text;
using Kata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KataTests
{
	[TestClass]
	public class LongestCommonPrefixTest
	{
		private LongestCommonPrefix _kata;

		[TestInitialize]
		public void Init()
		{
			_kata = new LongestCommonPrefix();
		}

		[TestMethod]
		public void OneItem()
		{
			var input = new[] { "flower" };
			var expected = "flower";
			var actual = _kata.FindLongestCommonPrefix(input);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void OneCharLength()
		{
			var input = new[] { "a","b" };
			var expected = "";
			var actual = _kata.FindLongestCommonPrefix(input);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void RepeatingItems()
		{
			var input = new[] { "flowerflower","flower" };
			var expected = "flower";
			var actual = _kata.FindLongestCommonPrefix(input);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void SimpleTest()
		{
			var input = new[] { "flower", "flow", "flight" };
			var expected = "fl";
			var actual = _kata.FindLongestCommonPrefix(input);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void NoSolution()
		{
			var input = new[] { "dog", "racecar", "car" };
			var expected = "";
			var actual = _kata.FindLongestCommonPrefix(input);
			Assert.AreEqual(expected, actual);
		}
	}
}
