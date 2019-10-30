using System;
using System.Linq;
using Kata;
using Xunit;

namespace KataTests
{
	public class FormingMagicSquareTest
	{
		private FormingMagicSquare _kata;

		public FormingMagicSquareTest()
		{
			_kata = new FormingMagicSquare();
		}

		[Fact]
		public void ValidMagicSquareCanPassValidator()
		{
			var validMagicSquareSequence = new[] { 4, 9, 2, 3, 5, 7, 8, 1, 6 };
			var isMagicSquare = _kata.IsMagicSquare(_kata.ParseArrayToSquare(validMagicSquareSequence));

			Assert.True(isMagicSquare);
		}

		[Fact]
		public void InvalidMagicSquareCannotPassValidator()
		{
			var invalidMagicSquareSequence = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
			var isMagicSquare = _kata.IsMagicSquare(_kata.ParseArrayToSquare(invalidMagicSquareSequence));

			Assert.False(isMagicSquare);
		}

		[Fact]
		public void SameMagicSquaresCostEqualsZero()
		{
			var targetSquare = _kata.ParseArrayToSquare( new[] { 4, 9, 2, 3, 5, 7, 8, 1, 6 });
			var inputSquare = _kata.ParseArrayToSquare( new[] { 4, 9, 2, 3, 5, 7, 8, 1, 6 });

			var expected = 0;
			var actual = _kata.CalculateCost(inputSquare, targetSquare);
			
			Assert.Equal(expected,actual);
		}

		[Fact]
		public void MagicSquaresOffByOneCostEqualsOne()
		{
			var targetSquare = _kata.ParseArrayToSquare( new[] { 4, 9, 2, 3, 5, 7, 8, 1, 6 });
			var inputSquare = _kata.ParseArrayToSquare( new[] { 5, 9, 2, 3, 5, 7, 8, 1, 6 });

			var expected = 1;
			var actual = _kata.CalculateCost(inputSquare, targetSquare);
			
			Assert.Equal(expected,actual);
		}
	}
}
