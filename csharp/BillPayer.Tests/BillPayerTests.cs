namespace BillyPayer.Tests
{
	using System;
	using BillPayer;
	using Moq;
	using NUnit.Framework;

	[TestFixture]
	public class BillPayerTests
	{
		private readonly BillPayer _sut;
		private readonly Mock<IHolidayChecker> holidayChecker;

		public BillPayerTests()
		{
			holidayChecker = new Mock<IHolidayChecker>();
			_sut = new BillPayer(holidayChecker.Object);
		}

		[Test]
		public void MortgageBill_GetDueDate_WhenDueDateIsABusinessDay_ShouldReturnDueDate()
		{
			var expectedDueDate = new DateTime(2017, 10, 26);

			var actualDueDate = _sut.GetMortgageBillDueDate(expectedDueDate);

			Assert.AreEqual(expectedDueDate, actualDueDate);
		}

		[Test]
		public void MortgageBill_GetDueDate_WhenDueDateBlackFridayIn2017_ShouldReturnTheNextMondayIn2017()
		{
			var holiday = new DateTime(2017, 11, 24);
			var expectedDueDate = new DateTime(2017, 11, 27);
			holidayChecker.Setup(checker => checker.IsHoliday(holiday)).Returns(true);

			var actualDueDate = _sut.GetMortgageBillDueDate(holiday);

			Assert.AreEqual(expectedDueDate, actualDueDate);
		}

		[Test]
		public void MortgageBill_GetDueDate_WhenDueDateIsSaturday_ShouldReturnTheNextMonday()
		{
			var nonBusinessDay = new DateTime(2017, 10, 28);
			var expectedDueDate = new DateTime(2017, 10, 30);

			var actualDueDate = _sut.GetMortgageBillDueDate(nonBusinessDay);

			Assert.AreEqual(expectedDueDate, actualDueDate);
		}

		[Test]
		public void MortgageBill_GetDueDate_WhenDueDateIsSunday_ShouldReturnTheNextMonday()
		{
			var nonBusinessDay = new DateTime(2017, 10, 29);
			var expectedDueDate = new DateTime(2017, 10, 30);

			var actualDueDate = _sut.GetMortgageBillDueDate(nonBusinessDay);

			Assert.AreEqual(expectedDueDate, actualDueDate);
		}

		[Test]
		public void MortgageBill_GetDueDate_WhenDueDateIsThanksgivingIn2017_ShouldReturnTheNextMondayIn2017()
		{
			var holiday = new DateTime(2017, 11, 23);
			var expectedDueDate = new DateTime(2017, 11, 27);

			var actualDueDate = _sut.GetMortgageBillDueDate(holiday);

			Assert.AreEqual(expectedDueDate, actualDueDate);
		}
	}
}