namespace ExpenseTrackingAndBudgetingSoftware.Models;

public static class TransactionSorter
{

    public static List<Transaction> Sort(List<Transaction> transactions, SortType sortType)
    {
        
        switch (sortType)
        {
            case SortType.AmountAscending:
                return transactions.OrderBy(t => t.Amount).ToList();
            case SortType.AmountDescending:
                return transactions.OrderByDescending(t => t.Amount).ToList();
            case SortType.DateAscending:
                return transactions.OrderBy(t => t.Date).ToList();
            case SortType.DateDescending:
                return transactions.OrderByDescending(t => t.Date).ToList();
            case SortType.CategoryNameAscending:
                return transactions.OrderBy(t => t.Category.CategoryName).ToList();
            case SortType.CategoryNameDescending:
                return transactions.OrderByDescending(t => t.Category.CategoryName).ToList();
            default:
                return transactions.OrderBy(t => t.Date).ToList();
        }
        
    }

}