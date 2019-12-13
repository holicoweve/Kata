using System;
using System.Linq;
using Kata;
using NUnit;
using NUnit.Framework;

namespace KataTests
{
	[TestFixture]
	public class FormingMagicSquareTest
	{
		private FormingMagicSquare _kata;

		[SetUp]
		public void Setup()
		{
			_kata = new FormingMagicSquare();
		}

		[Test]
		public void ValidMagicSquareCanPassValidator()
		{
			var validMagicSquareSequence = new[] { 4, 9, 2, 3, 5, 7, 8, 1, 6 };
			var isMagicSquare = _kata.IsMagicSquare(_kata.ParseArrayToSquare(validMagicSquareSequence));

			Assert.IsTrue(isMagicSquare);
		}

		[Test]
		public void InvalidMagicSquareCannotPassValidator()
		{
			var invalidMagicSquareSequence = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
			var isMagicSquare = _kata.IsMagicSquare(_kata.ParseArrayToSquare(invalidMagicSquareSequence));

			Assert.IsFalse(isMagicSquare);
		}

		[Test]
		public void SameMagicSquaresCostEqualsZero()
		{
			var targetSquare = _kata.ParseArrayToSquare( new[] { 4, 9, 2, 3, 5, 7, 8, 1, 6 });
			var inputSquare = _kata.ParseArrayToSquare( new[] { 4, 9, 2, 3, 5, 7, 8, 1, 6 });

			var expected = 0;
			var actual = _kata.CalculateCost(inputSquare, targetSquare);
			
			Assert.AreEqual(expected,actual);
		}

		[Test]
		public void MagicSquaresOffByOneCostEqualsOne()
		{
			var targetSquare = _kata.ParseArrayToSquare( new[] { 4, 9, 2, 3, 5, 7, 8, 1, 6 });
			var inputSquare = _kata.ParseArrayToSquare( new[] { 5, 9, 2, 3, 5, 7, 8, 1, 6 });

			var expected = 1;
			var actual = _kata.CalculateCost(inputSquare, targetSquare);
			
			Assert.AreEqual(expected,actual);
		}
	}
}
