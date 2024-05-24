namespace ExpenseTrackingAndBudgetingSoftware.Models;

public static class BudgetSorter
{
    public static List<Budget> Sort(List<Budget> budgets, SortType sortType)
    {
        
        switch (sortType)
        {
            case SortType.DateDescending:
                return budgets.OrderByDescending(t => t.EndDate).ToList();
            default:
                return budgets.OrderByDescending(t => t.EndDate).ToList();
        }
        
    }
}