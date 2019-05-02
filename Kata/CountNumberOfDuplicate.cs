using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic.CompilerServices;

namespace Kata
{

    public class CountNumberOfDuplicate
    {
        public int DuplicateCount(string input)
        {
            return input.ToLower().GroupBy(c => c).Count(g => g.Count() > 1);
        }
    }
}