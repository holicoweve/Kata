using System;
using System.Collections.Generic;
using System.Text;
using Kata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KataTests
{
	[TestClass]
	public class LongestSubstringWithoutRepeatTest
	{
		private LongestSubstringWithoutRepeat _kata;

		[TestInitialize]
		public void Init()
		{
			_kata = new LongestSubstringWithoutRepeat();
		}

		[TestMethod]
		public void SameChars()
		{
			var input = "bbbbb";
			var expected = 1;
			var actual = _kata.Length(input);

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void AnswerInBeginning()
		{
			var input = "abcabcbb";
			var expected = 3;
			var actual = _kata.Length(input);

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void AnswerInMiddle()
		{
			var input = "pwwkew";
			var expected = 3;
			var actual = _kata.Length(input);

			Assert.AreEqual(expected, actual);
		}

	}
}
