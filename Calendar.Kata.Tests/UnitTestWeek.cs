using System;
using NUnit.Framework;

namespace Calendar.Kata.Tests
{
	[TestFixture]
	public class UnitTestWeek
	{
		[Test]
		public void NewWeek_ReturnsWeek_ReturnValidWeek()
		{
			// Arrange
			var week = new Data.Week();

			// Assert
			Assert.IsNotNull(week);
			Assert.IsNotNull(week.Days);
			Assert.IsTrue(week.Days.Count == 7);

		}
		

	}
}
