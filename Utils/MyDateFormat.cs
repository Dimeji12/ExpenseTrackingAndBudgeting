using System;
namespace ExpenseTrackingAndBudgetingSoftware.Utils
{
	public static class MyDateFormat
	{
		public static string Format= "dd/MM/yyyy";

		public static string ToStringFormat(DateOnly date)
		{
			return date.ToString("dddd, dd MMM yyyy");
		}
		
		public static string ToYearStringFormat(DateOnly date)
		{
			return date.ToString("yyyy");
		}
		
		public static string ToMonthYearStringFormat(DateOnly date)
		{
			return date.ToString("MMMM, yyyy");
		}
		public static string ToDayMonthYearStringFormat(DateOnly date)
		{
			return date.ToString("dddd, MMMM, yyyy");
		}
	}
}

