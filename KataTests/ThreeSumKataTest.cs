using System.Collections.Generic;
using System.Linq;
using Kata;
using NUnit.Framework;

namespace KataTests
{
	[TestFixture]
	public class ThreeSumKataTest
    {
        private ThreeSumKata _kata;

        [SetUp]
        public void Setup()
        {
            _kata = new ThreeSumKata();
        }

        [Test]
        public void SimpleTest()
        {
            var expected = Flatten(new List<IList<int>> { new List<int> { -1, 0, 1 }, new List<int>() { -1, -1, 2 } });
            var actual = Flatten(_kata.ThreeSum(new int[] { -1, 0, 1, 2, -1, -4 }));

            Assert.AreEqual(expected, actual);
        }

        public List<string> Flatten(IList<IList<int>> nestedList)
        {
            List<string> result = new List<string>();
            foreach (var innerList in nestedList)
            {
                var list = innerList.ToList();
                list.Sort();
                result.Add(list.ToString());
            }

            return result;
        }
    }
}
