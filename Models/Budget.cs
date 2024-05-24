using ExpenseTrackingAndBudgetingSoftware.Utils;

namespace ExpenseTrackingAndBudgetingSoftware.Models;

public class Budget
{
    private double _amount;

    private DateOnly _startDate;

    private DateOnly _endDate;

    private Category? _category;

    private List<Transaction> _transactions;

    private Double _transactionsTotal;

    private Double _balance = 0;

    public Budget(double amount, DateOnly startDate, DateOnly endDate, Category? category)
    {
        //TODO: Correct Budget Exception
        if (category is { CategoryType: CategoryType.Income })
        {
            throw new Exception("Cannot have a budget for Income");
        }

        _amount = amount;
        _startDate = startDate;
        _endDate = endDate;
        _category = category;

        _transactions = new List<Transaction>();

        foreach (var transaction in _category?.Transactions!)
        {
            if (transaction.Date >= _startDate && transaction.Date <= _endDate)
            {
                _transactions.Add(transaction);
            }
        }

        _transactionsTotal = _transactions.Sum(transaction => transaction.Amount);
        _balance = _amount - _transactionsTotal;
    }

    public double Amount
    {
        get => _amount;
        set => _amount = value;
    }

    public DateOnly StartDate
    {
        get => _startDate;
        set => _startDate = value;
    }

    public DateOnly EndDate
    {
        get => _endDate;
        set => _endDate = value;
    }


    public Category? Category
    {
        get => _category;
        set => _category = value;
    }

    public List<Transaction> GetTransactions()
    {
        _transactions = new List<Transaction>();

        foreach (var transaction in _category?.Transactions!)
        {
            if (transaction.Date >= _startDate && transaction.Date <= _endDate)
            {
                _transactions.Add(transaction);
            }
        }

        return _transactions;
    }

    public Double GetTransactionsTotal()
    {
        return _transactions.Sum(transaction => transaction.Amount);
    }

    public Double GetBalance()
    {
        return _amount - GetTransactionsTotal();
    }

    public void Display(int? count)
    {
        if (count != null)
        {
            Console.WriteLine(
                $"{count + ")",-5}{_category!.CategoryName,-30}{"Amount Budgeted: " + CurrencyFormat.CurrencyValue(_amount),-5}");
            Console.WriteLine(
                $"{"",-5}{"Budget Period",-30}{MyDateFormat.ToStringFormat(_startDate),-5} - {MyDateFormat.ToStringFormat(_endDate),-5}");
            Console.WriteLine(
                $"{"",-5}{"Total Amount Spent",-30}{CurrencyFormat.CurrencyValue(GetTransactionsTotal()),-5}");
            Console.WriteLine(
                $"{"",-5}{"Balance",-30}{CurrencyFormat.CurrencyValue(GetBalance()),-5}");
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine(
                $"{"",-5}{_category!.CategoryName,-30}{"Amount Budgeted: " + CurrencyFormat.CurrencyValue(_amount),-5}");
            Console.WriteLine(
                $"{"",-5}{"Budget Period",-30}{MyDateFormat.ToStringFormat(_startDate),-5} - {MyDateFormat.ToStringFormat(_endDate),-5}");
            Console.WriteLine(
                $"{"",-5}{"Total Amount Spent",-30}{CurrencyFormat.CurrencyValue(GetTransactionsTotal()),-5}");
            Console.WriteLine(
                $"{"",-5}{"Balance",-30}{CurrencyFormat.CurrencyValue(GetBalance()),-5}");
        }

        if (GetTransactions().Count == 0) {
            
            Console.WriteLine();

            Console.Write($"{"",-5}{new string('-', 10)}");
            Console.Write("No transaction within this period");
            Console.Write($"{new string('-', 10)}");

            Console.WriteLine();
            
        }
        else {
            Console.WriteLine();

            Console.Write($"{"",-5}{new string('-', 10)}");
            Console.Write("Transactions Carried Out");
            Console.Write($"{new string('-', 10)}");

            Console.WriteLine();

            int transactionsCount = 1;

            foreach (var transaction in _transactions)
            {
                Console.WriteLine(
                    $"{"",-5}{transactionsCount + ")",-5}{transaction.Category.CategoryName,-30}{CurrencyFormat.CurrencyValue(transaction.Amount),-5}");

                Console.WriteLine($"{"",-10}{MyDateFormat.ToStringFormat(transaction.Date),-30}{_category.CategoryType}");
                if (!string.IsNullOrEmpty(transaction.Description))
                {
                    Console.WriteLine($"{"",-10}{"Description: ",-1}{transaction.Description}");
                }

                transactionsCount++;
            }
        }

        Console.WriteLine();
    }
}