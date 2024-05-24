namespace ExpenseTrackingAndBudgetingSoftware.Models;

public static class CategorySorter
{
    public static List<Category> Sort(List<Category> categories, SortType sortType)
    {
        
        switch (sortType)
        {
            case SortType.Name:
                return categories.OrderBy(t => t.CategoryName).ToList();
            case SortType.FrequentlyUsed:
                return categories.OrderByDescending(t => t.Transactions.Count).ToList();
            default:
                return categories.OrderBy(t => t.CategoryName).ToList();
        }
        
    }
}