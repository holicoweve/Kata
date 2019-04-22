using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kata
{
    public class ContainsDuplicateTwo
    {
        public bool ContainsNearbyDuplicate(int[] inputs, int k)
        {
            var groups = inputs
                .Select((value, index) => new { value = value, index = index })
                .GroupBy(item => item.value, item => item.index)
                .Where(group=>group.Count()>=2);

            foreach (var group in groups)
            {
                var groupenum = group.AsEnumerable();
                for (var i = 0; i < groupenum.Count() - 1; i++)
                {
                    if (groupenum.ElementAt(i+1) - groupenum.ElementAt(i) <= k)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
