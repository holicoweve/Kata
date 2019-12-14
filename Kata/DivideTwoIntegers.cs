using System;

namespace Kata
{
    public class DivideTwoIntegers
    {
        public int Divide(int dividend, int divisor)
        {
            if (dividend == int.MinValue && divisor == -1) return int.MaxValue;
            var negate = dividend < 0 != divisor < 0;
            dividend = Math.Abs(dividend);
            divisor = Math.Abs(divisor);

            var quotient = 0;
            while (dividend >= divisor)
            {
	            var multiplier = 1;
	            var deduction = divisor;
	            while (dividend > deduction<<1)
	            {
		            multiplier <<= 1;
		            deduction <<= 1;
	            }

	            quotient += multiplier;
	            dividend -= deduction;
            }

            return negate ? -quotient : quotient;
        }
    }
}