namespace BillPayer
{
	using System;

	public interface IHolidayChecker
	{
		bool IsHoliday(DateTime holiday);
	}
}