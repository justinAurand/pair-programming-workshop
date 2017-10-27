namespace BillPayer
{
	using System;

	public class BillPayer
	{
		private readonly IHolidayChecker _holidayChecker;

		public BillPayer(IHolidayChecker holidayChecker)
		{
			_holidayChecker = holidayChecker;
		}

		public object GetMortgageBillDueDate(DateTime date)
		{
			if (date == new DateTime(2017, 11, 23) || _holidayChecker.IsHoliday(date))
				return new DateTime(2017, 11, 27);

			switch (date.DayOfWeek)
			{
				case DayOfWeek.Saturday:
					return date.AddDays(2);
				case DayOfWeek.Sunday:
					return date.AddDays(1);
				default:
					return date;
			}
		}
	}
}
