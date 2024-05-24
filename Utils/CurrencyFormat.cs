namespace ExpenseTrackingAndBudgetingSoftware.Utils;

public static class CurrencyFormat
{
    public static string Format= "£";

    public static string CurrencyValue(Double value)
    {
        var s = value.ToString("F2");

        return Format + s;
    }
}