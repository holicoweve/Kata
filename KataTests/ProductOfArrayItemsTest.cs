using Kata.CodeWars;
using NUnit.Framework;
using System;

namespace KataTests
{
	[TestFixture]
	public class ProductOfArrayItemsTest
	{
		private ProductOfArrayItems _kata;

		[SetUp]
		public void Setup()
		{
			_kata = new ProductOfArrayItems();
		}

		[Test]
		public void NegativeInputTest()
		{
			Assert.AreEqual(-672, _kata.Product(new int[] { -2, 6, 7, 8 }));
		}

		[Test]
		public void ZeroInInputTest()
		{
			Assert.AreEqual(0, _kata.Product(new int[] { 0, 2, 9, 7 }));
		}

		[Test]
		public void SingleInputTest()
		{
			Assert.AreEqual(10, _kata.Product(new int[] { 10 }));
		}

		[Test]
		public void PositiveInputTest()
		{
			Assert.AreEqual(540, _kata.Product(new int[] { 5, 4, 1, 3, 9 }));
		}

		[Test]
		public void TestNullArray()
		{
			Assert.Throws<ArgumentNullException>(() => _kata.Product(null));
		}

		[Test]
		public void TestEmptyArray()
		{
			Assert.Throws<InvalidOperationException>(() => _kata.Product(new int[0]));
		}
	}
}