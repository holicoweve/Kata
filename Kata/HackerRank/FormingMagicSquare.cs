using System;
using System.Linq;

namespace Kata.HackerRank
{
	/// <summary>
	/// Forming a Magic Square
	/// 
	/// https://www.hackerrank.com/challenges/magic-square-forming/problem
	/// </summary>
	class FormingMagicSquare
	{
		//TODO: unfinished
		private int _validArraySize = 9;

		public int[,] ParseArrayToSquare(int[] input)
		{
			if (input.Length != _validArraySize)
			{
				throw new ArgumentException("Input must be 9 integers");
			}

			var result = new int[3, 3];
			var enumerator = input.AsEnumerable().GetEnumerator();
			enumerator.MoveNext();
			for (var i = 0; i < 3; i++)
			{
				for (var j = 0; j < 3; j++)
				{
					result[i, j] = enumerator.Current;
					enumerator.MoveNext();
				}
			}
			enumerator.Dispose();

			return result;
		}

		private int[,] RotateSquareClockwise(int[,] inputSquare)
		{
			var size = inputSquare.GetLength(0);

			var result = new int[size, size];

			for (var i = 0; i < size; i++)
			{
				result[0, i] = inputSquare[i, 2];
				result[2, i] = inputSquare[i, 2];
			}
			return result;
		}

		internal bool IsMagicSquare(int[,] inputSquare)
		{
			var size = inputSquare.GetLength(0);
			for (var i = 0; i < size; i++)
			{
				if (ColumnSum(inputSquare, i) != 15)
				{
					return false;
				}

				if (RowSum(inputSquare, i) != 15)
				{
					return false;
				}
			}

			if (DiagonalSum(inputSquare, true) != 15 || DiagonalSum(inputSquare, false) != 15)
			{
				return false;
			}

			return true;
		}

		private int RowSum(int[,] inputSquare, int rowNumber)
		{
			if (rowNumber < 0 || rowNumber >= 3)
			{
				throw new ArgumentException();
			}

			var rowSum = inputSquare[rowNumber, 0] + inputSquare[rowNumber, 1] + inputSquare[rowNumber, 2];
			return rowSum;
		}

		private int ColumnSum(int[,] inputSquare, int columnNumber)
		{
			if (columnNumber < 0 || columnNumber >= 3)
			{
				throw new ArgumentException();
			}

			var columnSum = inputSquare[0, columnNumber] + inputSquare[1, columnNumber] + inputSquare[2, columnNumber];
			return columnSum;
		}

		private int DiagonalSum(int[,] inputSquare, bool direction)
		{
			var offSet = direction ? 1 : -1;
			var diagonalSum = inputSquare[0, 1 + offSet] + inputSquare[1, 1] + inputSquare[2, 1 - offSet];
			return diagonalSum;
		}

		internal int CalculateCost(int[,] inputSquare, int[,] targetSquare)
		{
			if (inputSquare.GetLength(0) != targetSquare.GetLength(0) || inputSquare.GetLength(1) != targetSquare.GetLength(1))
			{
				throw new ArgumentException("The magic squares are not the same size");
			}

			var result = 0;
			for (var i = 0; i < inputSquare.GetLength(0); i++)
			{
				for (var j = 0; j < inputSquare.GetLength(1); j++)
				{
					result += Math.Abs(targetSquare[i, j] - inputSquare[i, j]);
				}
			}

			return result;
		}
	}
}
