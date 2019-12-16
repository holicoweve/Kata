namespace Kata.CodeWars
{
	/// <summary>
	///     Kata - Sum Strings as Numbers
	///     Given the string representations of two integers, return the string representation of the sum of those integers.
	///     For example:
	///     sumStrings('1','2') // => '3'
	///     A string representation of an integer will contain no characters besides the ten numerals "0" to "9".
	///     https://www.codewars.com/kata/sum-strings-as-numbers/train/csharp
	/// </summary>
	public class SumStringsAsNumbers
	{
		public string Sum(string inputA, string inputB)
		{
			var newLength = inputA.Length > inputB.Length ? inputA.Length + 1 : inputB.Length + 1;
			var result = new string('0', newLength).ToCharArray();
			var a = inputA.PadLeft(newLength, '0').ToCharArray();
			var b = inputB.PadLeft(newLength, '0').ToCharArray();

			for (var i = newLength - 1; i > 0; i--)
			{
				var sum = ToInt(a[i]) + ToInt(b[i]) + ToInt(result[i]);
				result[i] = ToChar(sum, out var carry);
				result[i - 1] = carry;
			}

			return new string(result).TrimStart('0');
		}

		private static int ToInt(char a)
		{
			return int.Parse(a.ToString());
		}

		private static char ToChar(int a, out char carry)
		{
			char result;
			carry = '0';
			if (a >= 10)
			{
				result = a.ToString()[1];
				carry = '1';
			}
			else
			{
				result = a.ToString()[0];
			}

			return result;
		}
	}
}