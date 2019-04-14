using System;
using System.Collections.Generic;
using System.Text;

namespace Kata
{
    public class ArrayMath
    {
        public static int Product(int[] values)
        {
            if (values == null)
                throw new ArgumentNullException();
            if (values.Length == 0)
                throw new InvalidOperationException();

            var result = 1;
            foreach (var item in values)
            {
                result *= item;
            }

            return result;
        }
    }
}
