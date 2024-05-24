namespace ExpenseTrackingAndBudgetingSoftware.Models;

public class Category
{

    private string _categoryName;

    private string? _categoryDescription;

    private readonly List<Transaction> _transactions;
    
    private CategoryType _categoryType;

    public Category(string categoryName, CategoryType categoryType)
    {
        _categoryName = categoryName;

        _categoryType = categoryType;

        _transactions = new List<Transaction>();
    }

    public string CategoryName
    {
        get => _categoryName;
        set => _categoryName = value;
    }

    public CategoryType CategoryType
    {
        get => _categoryType;
        set => _categoryType = value;
    }

    public string? CategoryDescription
    {
        get => _categoryDescription;
        set => _categoryDescription = value;
    }

    
    public List<Transaction> Transactions => _transactions;

    public void AddTransaction(Transaction transaction)
    {
        _transactions.Add(transaction);
        
    }

    // Method to remove a transaction from the category
    public void RemoveTransaction(Transaction transaction)
    {
        _transactions.Remove(transaction);
        
    }
    

    public void Display(int? count)
    {
        
        Console.WriteLine();

        if (count != null)
        {

            Console.WriteLine(
                $"{count + ")",-5}{CategoryName,-30}{CategoryType.ToString(),-5}");

        }else {
            
            Console.WriteLine(
                $"{"",-5}{CategoryName,-30}{CategoryType.ToString(),-5}");
        }
        Console.WriteLine();
    }
    

}