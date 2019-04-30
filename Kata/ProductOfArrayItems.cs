using System;
using System.Collections.Generic;
using System.Text;

namespace Kata
{
    /// <summary>
    /// Kata -Product of Array Items
    /// 
    /// Calculate the product of all elements in an array.
    ///
    /// If the array is null, you should throw ArgumentNullException and if the array is empty, you should throw InvalidOperationException.
    ///
    /// As a challenge, try writing your method in just one line of code. It's possible to have only 36 characters within your method.
    ///
    /// https://www.codewars.com/kata/product-of-array-items/train/csharp
    /// </summary>
    public static class ProductOfArrayItems
    {
        public static int Product(int[] values)
        {
            if (values == null)
                throw new ArgumentNullException(nameof(values),"Input cannot be null");
            if (values.Length == 0)
                throw new InvalidOperationException("Input cannot be empty");

            var result = 1;
            foreach (var item in values)
            {
                result *= item;
            }

            return result;
        }
    }
}
