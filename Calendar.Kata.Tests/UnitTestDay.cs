using System;
using NUnit.Framework;

namespace Calendar.Kata.Tests
{
	[TestFixture]
	public class UnitTestDay
	{

		[Test]
		public void InstantiateDay_TestNullability_NotNull()
		{
			// Arrange
			var day = new Data.Day();
			// Act

			// Assert
			Assert.IsNotNull(day);
			Assert.IsTrue(day.Activity == Data.eActivity.Unallocated);
			Assert.IsTrue(day.Order == 1);
		}

	}
}
