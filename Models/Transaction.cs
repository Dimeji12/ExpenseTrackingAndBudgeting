using ExpenseTrackingAndBudgetingSoftware.Utils;

namespace ExpenseTrackingAndBudgetingSoftware.Models;

public class Transaction
{

    private DateOnly _date;

    private double _amount;

    private Category? _category;

    private string? _description;

    private TransactionType _transactionType;

    public Transaction(double amount, Category? category, 
        TransactionType transactionType, DateOnly date, string? description) {
        
        _description = description;
        _amount = amount;
        _category = category;
        _transactionType = transactionType;
        _date = date;
        
        //Bi-directional. Add transaction to the category
        category?.AddTransaction(this);

    }
    
    public double Amount
    {
        get => _amount;
        set => _amount = value;
    }

    public TransactionType TransactionType
    {
        get => _transactionType;
        set => _transactionType = value;
    }

    public string? Description
    {
        get => _description;
        set => _description = value;
    }

    public DateOnly Date
    {
        get => _date;
        set => _date = value;
    }

    public Category Category => _category!;

    public void ChangeCategory(Category? newCategory)
    {
        //Remove this transaction fro old category
        _category?.RemoveTransaction(this);
        
        //Change this category
        _category = newCategory!;
        
        //This transaction has changed, so add it to new category
        _category.AddTransaction(this);
        
    }

    public void Display(int? count)
    {
        
        Console.WriteLine();

        if (count != null)
        {
            Console.WriteLine(
                $"{count + ")",-5}{_category!.CategoryName,-35}{CurrencyFormat.CurrencyValue(_amount),-5}");

        }else {
            
            Console.WriteLine(
                $"{"",-5}{_category!.CategoryName,-30}{CurrencyFormat.CurrencyValue(_amount),-5}");
            
        }
        Console.WriteLine($"{"",-5}{MyDateFormat.ToStringFormat(_date),-35}{_category.CategoryType}");
        if (!string.IsNullOrEmpty(_description))
        {
            Console.WriteLine($"{"",-5}{"Description: ", -1}{_description}");
        }
        
        Console.WriteLine();

    }
}