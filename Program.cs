using ExpenseTrackingAndBudgetingSoftware.Models;
using ExpenseTrackingAndBudgetingSoftware.Utils;

namespace ExpenseTrackingAndBudgetingSoftware;

using System;

class Program
{
    private static List<Transaction> transactions;

    private static List<Category> categories;

    private static List<Budget> budgets;

    private static double balance = 0;

    private static bool promptUserToAddTransactionExit = false;

    private static bool promptUserForMenuExit = false;

    private static bool promptUserForChangeDisplay = false;

    private static bool promptUserToAddCategoryExit = false;

    private static bool promptUserForCategoryTypeExit = false;

    private static bool promptUserForChangeDisplayCategories = false;

    private static bool promptUserToAddBudgetExit = false;

    static void Main(string[] args)
    {
        transactions = new List<Transaction>();

        categories = new List<Category>();

        budgets = new List<Budget>();

        //Generate some categories
        PreGenerateCategories();
        PreGenerateTransactions();
        PreGenerateBudgets();

        PromptUserForMenu();
    }

    private static void PreGenerateBudgets() {
        budgets.Add(new Budget(5000, DateConverter.ToDateOnly("05/05/1994")!.Value,
            DateConverter.ToDateOnly("05/05/2025")!.Value, categories[8]));
        budgets.Add(new Budget(5000, DateConverter.ToDateOnly("01/01/2024")!.Value,
            DateConverter.ToDateOnly("15/03/2024")!.Value, categories[1]));
        budgets.Add(new Budget(5000, DateConverter.ToDateOnly("01/01/2024")!.Value,
            DateConverter.ToDateOnly("15/03/2024")!.Value, categories[2]));

    }

    private static void PreGenerateCategories()
    {
        //Expense Categories
        categories.Add(new Category("Fuel", CategoryType.Expense));
        categories.Add(new Category("Eating Out", CategoryType.Expense));
        categories.Add(new Category("General", CategoryType.Expense));
        categories.Add(new Category("Kids", CategoryType.Expense));
        categories.Add(new Category("Clothes", CategoryType.Expense));
        categories.Add(new Category("Entertainment", CategoryType.Expense));
        categories.Add(new Category("Gifts", CategoryType.Expense));
        categories.Add(new Category("Holiday", CategoryType.Expense));
        categories.Add(new Category("Shopping", CategoryType.Expense));

        //Income Categories
        categories.Add(new Category("Salary", CategoryType.Income));
        categories.Add(new Category("Sales Profit", CategoryType.Income));
    }

    private static void PreGenerateTransactions()
    {
        //Expense Transactions
        transactions.Add(new Transaction(233.00, categories[3], TransactionType.Expense,
            DateConverter.ToDateOnly("02/01/2024")!.Value, "Bought From Lidl"));
        transactions.Add(new Transaction(233.00, categories[1], TransactionType.Expense,
            DateConverter.ToDateOnly("15/02/2024")!.Value, "Bought From Lidl"));
        transactions.Add(new Transaction(233.00, categories[5], TransactionType.Expense,
            DateConverter.ToDateOnly("27/01/2024")!.Value, "Bought From Lidl"));
        transactions.Add(new Transaction(233.00, categories[8], TransactionType.Expense,
            DateConverter.ToDateOnly("08/03/2024")!.Value, "Bought From Lidl"));
        transactions.Add(new Transaction(233.00, categories[2], TransactionType.Expense,
            DateConverter.ToDateOnly("19/01/2024")!.Value, "Bought From Lidl"));
        transactions.Add(new Transaction(233.00, categories[0], TransactionType.Expense,
            DateConverter.ToDateOnly("12/02/2024")!.Value, "Bought From Lidl"));
        transactions.Add(new Transaction(233.00, categories[4], TransactionType.Expense,
            DateConverter.ToDateOnly("05/01/2024")!.Value, "Bought From Lidl"));
        transactions.Add(new Transaction(233.00, categories[7], TransactionType.Expense,
            DateConverter.ToDateOnly("22/02/2024")!.Value, "Bought From Lidl"));
        transactions.Add(new Transaction(233.00, categories[6], TransactionType.Expense,
            DateConverter.ToDateOnly("16/03/2024")!.Value, "Bought From Lidl"));
        transactions.Add(new Transaction(233.00, categories[1], TransactionType.Expense,
            DateConverter.ToDateOnly("11/01/2024")!.Value, "Bought From Lidl"));
        transactions.Add(new Transaction(233.00, categories[3], TransactionType.Expense,
            DateConverter.ToDateOnly("21/02/2024")!.Value, "Bought From Lidl"));
        transactions.Add(new Transaction(233.00, categories[5], TransactionType.Expense,
            DateConverter.ToDateOnly("13/01/2024")!.Value, "Bought From Lidl"));
        transactions.Add(new Transaction(233.00, categories[8], TransactionType.Expense,
            DateConverter.ToDateOnly("28/03/2024")!.Value, "Bought From Lidl"));
        transactions.Add(new Transaction(233.00, categories[0], TransactionType.Expense,
            DateConverter.ToDateOnly("03/02/2024")!.Value, "Bought From Lidl"));
        transactions.Add(new Transaction(233.00, categories[2], TransactionType.Expense,
            DateConverter.ToDateOnly("17/01/2024")!.Value, "Bought From Lidl"));
        transactions.Add(new Transaction(233.00, categories[4], TransactionType.Expense,
            DateConverter.ToDateOnly("24/02/2024")!.Value, "Bought From Lidl"));
        transactions.Add(new Transaction(233.00, categories[7], TransactionType.Expense,
            DateConverter.ToDateOnly("06/03/2024")!.Value, "Bought From Lidl"));
        transactions.Add(new Transaction(233.00, categories[6], TransactionType.Expense,
            DateConverter.ToDateOnly("08/01/2024")!.Value, "Bought From Lidl"));
        transactions.Add(new Transaction(233.00, categories[1], TransactionType.Expense,
            DateConverter.ToDateOnly("25/02/2024")!.Value, "Bought From Lidl"));
        transactions.Add(new Transaction(233.00, categories[3], TransactionType.Expense,
            DateConverter.ToDateOnly("14/03/2024")!.Value, "Bought From Lidl"));
        transactions.Add(new Transaction(233.00, categories[0], TransactionType.Expense,
            DateConverter.ToDateOnly("05/05/2024")!.Value, "Bought From Lidl"));
        transactions.Add(new Transaction(233.00, categories[0], TransactionType.Expense,
            DateConverter.ToDateOnly("05/05/2024")!.Value, "Bought From Lidl"));
        transactions.Add(new Transaction(233.00, categories[1], TransactionType.Expense,
            DateConverter.ToDateOnly("05/06/2024")!.Value, "Bought From Lidl"));
        transactions.Add(new Transaction(233.00, categories[1], TransactionType.Expense,
            DateConverter.ToDateOnly("05/06/2024")!.Value, "Bought From Lidl"));
        transactions.Add(new Transaction(233.00, categories[2], TransactionType.Expense,
            DateConverter.ToDateOnly("05/07/2024")!.Value, "Bought From Lidl"));
        transactions.Add(new Transaction(233.00, categories[2], TransactionType.Expense,
            DateConverter.ToDateOnly("05/07/2024")!.Value, "Bought From Lidl"));
        transactions.Add(new Transaction(233.00, categories[3], TransactionType.Expense,
            DateConverter.ToDateOnly("05/08/2024")!.Value, "Bought From Lidl"));
        transactions.Add(new Transaction(233.00, categories[3], TransactionType.Expense,
            DateConverter.ToDateOnly("05/08/2024")!.Value, "Bought From Lidl"));
        transactions.Add(new Transaction(233.00, categories[4], TransactionType.Expense,
            DateConverter.ToDateOnly("06/09/2024")!.Value, "Bought From Lidl"));
        transactions.Add(new Transaction(233.00, categories[4], TransactionType.Expense,
            DateConverter.ToDateOnly("05/09/2024")!.Value, "Bought From Lidl"));
        transactions.Add(new Transaction(233.00, categories[4], TransactionType.Expense,
            DateConverter.ToDateOnly("06/03/2024")!.Value, "Bought From Lidl"));
        transactions.Add(new Transaction(233.00, categories[4], TransactionType.Expense,
            DateConverter.ToDateOnly("05/03/2024")!.Value, "Bought From Lidl"));

        //Income Transactions
        transactions.Add(new Transaction(15000.00, categories[9], TransactionType.Income,
            DateConverter.ToDateOnly("05/03/2024")!.Value, "Business Returns"));
        transactions.Add(new Transaction(20000.00, categories[10], TransactionType.Income,
            DateConverter.ToDateOnly("05/02/2024")!.Value, "Developer Salary"));
        transactions.Add(new Transaction(15000.00, categories[9], TransactionType.Income,
            DateConverter.ToDateOnly("05/01/2024")!.Value, "Business Returns"));
        transactions.Add(new Transaction(20000.00, categories[10], TransactionType.Income,
            DateConverter.ToDateOnly("05/03/2024")!.Value, "Developer Salary"));
    }


    private static void PromptUserForMenu()
    {
        while (!promptUserForMenuExit)
        {
            Console.WriteLine("\nSelect an option:");
            Console.WriteLine("a) Spending Menu");
            Console.WriteLine("b) Transactions Menu");
            Console.WriteLine("c) Categories Menu");
            Console.WriteLine("d) Budget Menu");
            Console.WriteLine("e) Exit App");

            Console.Write("Enter your choice: ");
            char choice = char.ToLower(Console.ReadKey().KeyChar);
            Console.WriteLine();

            switch (choice)
            {
                case 'a':
                    Console.WriteLine("\nOption 'Spending' selected");
                    DisplaySpendingByDisplayType(transactions, SpendingDisplayType.ThisMonth);
                    break;
                case 'b':
                    Console.WriteLine("Option 'Transactions' selected");
                    DisplayTransactionsMenu(SortType.DateDescending);
                    break;
                case 'c':
                    Console.WriteLine("Option 'Categories' selected");
                    DisplayCategoriesMenu(SortType.Name, "Name - Ascending");
                    break;
                case 'd':
                    Console.WriteLine("Option 'Budget Menu' selected");
                    DisplayBudgetsMenu(SortType.DateDescending, "End Date - Descending");
                    break;
                case 'e':
                    Console.WriteLine("Exiting the application...");
                    ExitApp();
                    break;
                default:
                    Console.WriteLine("Invalid option. Please select a valid option.");
                    break;
            }

            Console.WriteLine();
        }
    }

    private static void PromptUserForChangeDisplay(bool isTransactionMenu)
    {
        if (!isTransactionMenu)
        {
            while (!promptUserForChangeDisplay)
            {
                Console.WriteLine("\nSelect an option:");
                Console.WriteLine("a) This Day (Today)");
                Console.WriteLine("b) This Week");
                Console.WriteLine("c) This Month");
                Console.WriteLine("d) This Year");
                Console.WriteLine("e) Main Menu");
                Console.WriteLine("f) Exit");

                Console.Write("Enter your choice: ");
                char choice = char.ToLower(Console.ReadKey().KeyChar);
                Console.WriteLine();

                switch (choice)
                {
                    case 'a':
                        Console.WriteLine("\nOption 'This Day' selected");
                        DisplaySpendingByDisplayType(transactions, SpendingDisplayType.ThisDay);
                        break;
                    case 'b':
                        Console.WriteLine("Option 'This Week' selected");
                        DisplaySpendingByDisplayType(transactions, SpendingDisplayType.ThisWeek);
                        break;
                    case 'c':
                        Console.WriteLine("Option 'This Month' selected");
                        DisplaySpendingByDisplayType(transactions, SpendingDisplayType.ThisMonth);
                        break;
                    case 'd':
                        Console.WriteLine("Option 'This Year' selected");
                        DisplaySpendingByDisplayType(transactions, SpendingDisplayType.ThisYear);
                        break;
                    case 'e':
                        Console.WriteLine("Option 'Main Menu' selected");
                        PromptUserForMenu();
                        break;
                    case 'f':
                        Console.WriteLine("Exit");
                        ExitApp();
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please select a valid option.");
                        break;
                }

                Console.WriteLine();
            }
        }
        else
        {
            while (!promptUserForChangeDisplay)
            {
                const int spacing = -30;

                Console.WriteLine("\nSelect an option:");
                Console.WriteLine($"{"a) Daily",spacing} {"b) Monthly",spacing} {"c) Yearly",spacing}");
                Console.WriteLine(
                    $"{"d) Date - Ascending",spacing} {"e) Date - Descending",spacing} {"f) Amount - Ascending",spacing}");
                Console.WriteLine(
                    $"{"g) Amount - Descending",spacing} {"h) Category Name - Ascending",spacing} {"i) Category Name - Descending",spacing}");
                Console.WriteLine($"{"j) Main Menu",spacing} {"k) Exit",spacing}");


                Console.Write("Enter your choice: ");
                char choice = char.ToLower(Console.ReadKey().KeyChar);
                Console.WriteLine();

                switch (choice)
                {
                    case 'a':
                        Console.WriteLine("\nOption 'Daily' selected");
                        DisplayTransactionsMenu(SortType.Daily);
                        break;
                    case 'b':
                        Console.WriteLine("Option 'Monthly' selected");
                        DisplayTransactionsMenu(SortType.Monthly);
                        break;
                    case 'c':
                        Console.WriteLine("Option 'Yearly' selected");
                        DisplayTransactionsMenu(SortType.Yearly);
                        break;
                    case 'd':
                        Console.WriteLine("Option 'Date - Ascending' selected");
                        DisplayTransactionsMenu(SortType.DateAscending);
                        break;
                    case 'e':
                        Console.WriteLine("Option 'Date - Descending' selected");
                        DisplayTransactionsMenu(SortType.DateDescending);
                        break;
                    case 'f':
                        Console.WriteLine("Option 'Amount - Ascending' selected");
                        DisplayTransactionsMenu(SortType.AmountAscending);
                        break;
                    case 'g':
                        Console.WriteLine("Option 'Amount - Descending' selected");
                        DisplayTransactionsMenu(SortType.AmountDescending);
                        break;
                    case 'h':
                        Console.WriteLine("Option 'Category Name - Ascending' selected");
                        DisplayTransactionsMenu(SortType.CategoryNameAscending);
                        break;
                    case 'i':
                        Console.WriteLine("Option 'Category Name - Descending' selected");
                        DisplayTransactionsMenu(SortType.CategoryNameDescending);
                        break;
                    case 'j':
                        Console.WriteLine("Option 'Main Menu' selected");
                        PromptUserForMenu();
                        break;
                    case 'k':
                        Console.WriteLine("Exiting...");
                        ExitApp();
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please select a valid option.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }

    private static void PromptUserForChangeDisplayCategories()
    {
        while (!promptUserForChangeDisplayCategories)
        {
            //TODO
            Console.WriteLine("\nSelect an option:");
            Console.Write($"{"a) Name - Ascending",-10}");
            Console.Write($"{"",-10}");
            Console.Write($"{"b) Frequently Used",-10}");
            Console.Write($"{"",-10}");
            Console.Write($"{"c) Main Menu",-10}");
            Console.Write($"{"",-10}");
            Console.Write($"{"d) Exit",-10}");
            Console.Write($"{"",-10}");

            Console.WriteLine();

            Console.Write("Enter your choice: ");
            char choice = char.ToLower(Console.ReadKey().KeyChar);
            Console.WriteLine();

            switch (choice)
            {
                case 'a':
                    Console.WriteLine("\nOption 'Name - Ascending' selected");
                    DisplayCategoriesMenu(SortType.Name, "Name - Ascending");
                    break;
                case 'b':
                    Console.WriteLine("Option 'Frequently Used' selected");
                    DisplayCategoriesMenu(SortType.FrequentlyUsed, "Frequently Used");
                    break;
                case 'c':
                    Console.WriteLine("Option 'Main Menu' selected");
                    PromptUserForMenu();
                    break;
                case 'd':
                    Console.WriteLine("Exit");
                    ExitApp();
                    break;
                default:
                    Console.WriteLine("Invalid option. Please select a valid option.");
                    break;
            }

            Console.WriteLine();
        }
    }

    private static void PromptUserForTransactionsSubMenu(bool isTransactionMenu, List<Transaction>? sortedTransactions)
    {
        while (!promptUserToAddTransactionExit)
        {
            const int spacing = -30;

            Console.Write($"{"\n",spacing}");
            Console.WriteLine("Select an option:");
            Console.WriteLine($"{"a) Add Expense",spacing} {"b) Add Income",spacing} {"c) Edit Transaction",spacing}");
            Console.WriteLine(
                $"{"d) Delete Transaction",spacing} {"e) Change Display",spacing} {"f) Main Menu",spacing}");
            Console.WriteLine($"{"g) Exit",spacing}");


            Console.Write("\n\nEnter your choice: ");
            char choice = char.ToLower(Console.ReadKey().KeyChar);
            Console.WriteLine();

            switch (choice)
            {
                case 'a':
                    Console.WriteLine("\nOption 'Add Expense' selected");
                    CreateNewTransaction(TransactionType.Expense);
                    break;
                case 'b':
                    Console.WriteLine("Option 'Add Income' selected");
                    CreateNewTransaction(TransactionType.Income);
                    break;
                case 'c':
                    Console.WriteLine("Option 'Edit Transaction' selected");
                    EditTransaction(sortedTransactions!);
                    break;
                case 'd':
                    Console.WriteLine("Option 'Delete Transaction' selected");
                    DeleteTransaction(sortedTransactions!);
                    break;
                case 'e':
                    Console.WriteLine("Option 'Change Display' selected");
                    PromptUserForChangeDisplay(isTransactionMenu);
                    break;
                case 'f':
                    Console.WriteLine("Option 'Main Menu' selected");
                    PromptUserForMenu();
                    break;
                case 'g':
                    Console.WriteLine("Exiting...");
                    ExitApp();
                    break;
                default:
                    Console.WriteLine("\nInvalid option. Please select a valid option.");
                    break;
            }

            Console.WriteLine();
        }
    }


    private static void PromptUserForSpendingSubMenu(bool isTransactionMenu)
    {
        while (!promptUserToAddTransactionExit)
        {
            const int spacing = -30;

            Console.Write($"{"\n",spacing}");
            Console.WriteLine("Select an option:");
            Console.WriteLine($"{"a) Add Expense",spacing} {"b) Add Income",spacing} {"c) Change Display",spacing}");
            Console.WriteLine($"{"d) Main Menu",spacing} {"e) Exit",spacing}");


            Console.Write("\n\nEnter your choice: ");
            char choice = char.ToLower(Console.ReadKey().KeyChar);
            Console.WriteLine();

            switch (choice)
            {
                case 'a':
                    Console.WriteLine("\nOption 'Add Expense' selected");
                    CreateNewTransaction(TransactionType.Expense);
                    break;
                case 'b':
                    Console.WriteLine("Option 'Add Income' selected");
                    CreateNewTransaction(TransactionType.Income);
                    break;
                case 'c':
                    Console.WriteLine("Option 'Change Display' selected");
                    PromptUserForChangeDisplay(isTransactionMenu);
                    break;
                case 'd':
                    Console.WriteLine("Option 'Main Menu' selected");
                    PromptUserForMenu();
                    break;
                case 'e':
                    Console.WriteLine("Exiting...");
                    ExitApp();
                    break;
                default:
                    Console.WriteLine("\nInvalid option. Please select a valid option.");
                    break;
            }

            Console.WriteLine();
        }
    }

    private static void EditTransaction(List<Transaction> sortedTransactions)
    {
        Dictionary<int, Transaction> indexedTransactions = new Dictionary<int, Transaction>();

        int count = 1; // Initialize count to 1
        foreach (var transaction in sortedTransactions)
        {
            indexedTransactions.Add(count, transaction);
            count++; // Increment count inside the loop
        }

        Transaction? selectedTransaction = null;

        while (selectedTransaction == null)
        {
            Console.WriteLine("Enter the number of the transaction you wish to edit:");
            if (int.TryParse(Console.ReadLine(), out int transactionIndex) &&
                indexedTransactions.TryGetValue(transactionIndex, out var transaction))
            {
                selectedTransaction = transaction;
            }
            else
            {
                Console.WriteLine("Invalid selection. Please try again.");
            }
        }

        //TODO
        PromptForEditTransaction(selectedTransaction);
    }

    private static void EditBudget(List<Budget> sortedBudgets)
    {
        Dictionary<int, Budget> indexedBudgets = new Dictionary<int, Budget>();

        int count = 1; // Initialize count to 1
        foreach (var budget in sortedBudgets)
        {
            indexedBudgets.Add(count, budget);
            count++; // Increment count inside the loop
        }

        Budget? selectedBudget = null;

        while (selectedBudget == null)
        {
            Console.WriteLine("Enter the number of the Budget you wish to edit:");
            if (int.TryParse(Console.ReadLine(), out int budgetIndex) &&
                indexedBudgets.TryGetValue(budgetIndex, out var budget))
            {
                selectedBudget = budget;
            }
            else
            {
                Console.WriteLine("Invalid selection. Please try again.");
            }
        }

        //TODO
        PromptForEditBudget(selectedBudget);
    }

    private static void EditCategory(List<Category> sortedCategories)
    {
        Dictionary<int, Category> indexedCategories = new Dictionary<int, Category>();

        int count = 1; // Initialize count to 1
        foreach (var category in sortedCategories)
        {
            indexedCategories.Add(count, category);
            count++; // Increment count inside the loop
        }

        Category? selectedCategory = null;

        while (selectedCategory == null)
        {
            Console.WriteLine("Enter the number of the transaction you wish to edit:");
            if (int.TryParse(Console.ReadLine(), out int categoryIndex) &&
                indexedCategories.TryGetValue(categoryIndex, out var category))
            {
                selectedCategory = category;
            }
            else
            {
                Console.WriteLine("Invalid selection. Please try again.");
            }
        }

        //TODO
        PromptForEditCategory(selectedCategory);
    }


    private static void DeleteTransaction(List<Transaction> sortedTransactions)
    {
        Dictionary<int, Transaction> indexedTransactions = new Dictionary<int, Transaction>();

        int count = 1; // Initialize count to 1
        foreach (var transaction in sortedTransactions)
        {
            indexedTransactions.Add(count, transaction);
            count++; // Increment count inside the loop
        }

        Transaction? selectedTransaction = null;

        while (selectedTransaction == null)
        {
            Console.WriteLine("Enter the number of the transaction you wish to edit:");
            if (int.TryParse(Console.ReadLine(), out int transactionIndex) &&
                indexedTransactions.ContainsKey(transactionIndex))
            {
                selectedTransaction = indexedTransactions[transactionIndex];
            }
            else
            {
                Console.WriteLine("Invalid selection. Please try again.");
            }
        }

        //TODO

        try
        {
            transactions.Remove(selectedTransaction);

            Console.WriteLine();

            Console.Write($"{"",-5}{new string('-', 10)}");
            Console.Write("Deleted Successfully. Deleted Transaction:");
            Console.Write($"{new string('-', 10)}");

            selectedTransaction.Display(null);

            DisplayTransactionsMenu(SortType.DateDescending);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }


    private static void DeleteCategory(List<Category> sortedCategories)
    {
        Dictionary<int, Category> indexedCategories = new Dictionary<int, Category>();

        int count = 1; // Initialize count to 1
        foreach (var category in sortedCategories)
        {
            indexedCategories.Add(count, category);
            count++; // Increment count inside the loop
        }

        Category? selectedCategory = null;

        while (selectedCategory == null)
        {
            Console.WriteLine("Enter the number of the category you wish to edit:");
            if (int.TryParse(Console.ReadLine(), out int categoryIndex) &&
                indexedCategories.TryGetValue(categoryIndex, out var category))
            {
                selectedCategory = category;
            }
            else
            {
                Console.WriteLine("Invalid selection. Please try again.");
            }
        }

        //TODO

        try
        {
            categories.Remove(selectedCategory);

            Console.WriteLine();

            Console.Write($"{"",-5}{new string('-', 10)}");
            Console.Write("Deleted Successfully. Deleted Category:");
            Console.Write($"{new string('-', 10)}");

            selectedCategory.Display(null);

            DisplayCategoriesMenu(SortType.DateAscending, "Date - Ascending");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }


    private static void DeleteBudget(List<Budget> sortedBudgets)
    {
        Dictionary<int, Budget> indexedBudgets = new Dictionary<int, Budget>();

        int count = 1; // Initialize count to 1
        foreach (var budget in sortedBudgets)
        {
            indexedBudgets.Add(count, budget);
            count++; // Increment count inside the loop
        }

        Budget? selectedBudget = null;

        while (selectedBudget == null)
        {
            Console.WriteLine("Enter the number of the Budget you wish to edit:");
            if (int.TryParse(Console.ReadLine(), out int budgetIndex) &&
                indexedBudgets.TryGetValue(budgetIndex, out var budget))
            {
                selectedBudget = budget;
            }
            else
            {
                Console.WriteLine("Invalid selection. Please try again.");
            }
        }

        //TODO

        try
        {
            budgets.Remove(selectedBudget);

            Console.WriteLine();

            Console.Write($"{"",-5}{new string('-', 10)}");
            Console.Write("Deleted Successfully. Deleted Budget:");
            Console.Write($"{new string('-', 10)}");

            selectedBudget.Display(null);

            DisplayBudgetsMenu(SortType.DateDescending, "Date - Descending");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    private static void PromptUserForCategoriesSubMenu(List<Category>? sortedCategories)
    {
        while (!promptUserToAddCategoryExit)
        {
            const int spacing = -30;

            Console.Write($"{"\n",spacing}");
            Console.WriteLine("Select an option:");
            Console.WriteLine(
                $"{"a) Add Expense Category",spacing} {"b) Add Income Category",spacing} {"c) Edit Category",spacing}");
            Console.WriteLine(
                $"{"d) Delete Category",spacing} {"e) Change Display",spacing} {"f) Main Menu",spacing}");
            Console.WriteLine($"{"g) Exit",spacing}");

            Console.Write("\n\nEnter your choice: ");
            char choice = char.ToLower(Console.ReadKey().KeyChar);
            Console.WriteLine();

            switch (choice)
            {
                case 'a':
                    Console.WriteLine("\nOption 'Add Expense Category' selected");
                    CreateNewCategory(CategoryType.Expense);
                    break;
                case 'b':
                    Console.WriteLine("Option 'Add Income Category' selected");
                    CreateNewCategory(CategoryType.Income);
                    break;
                case 'c':
                    Console.WriteLine("Option 'Edit Category' selected");
                    EditCategory(sortedCategories!);
                    break;
                case 'd':
                    Console.WriteLine("Option 'Delete Category' selected");
                    DeleteCategory(sortedCategories!);
                    break;
                case 'e':
                    Console.WriteLine("Option 'Change Display' selected");
                    //TODO
                    PromptUserForChangeDisplayCategories();
                    break;
                case 'f':
                    Console.WriteLine("Option 'Main Menu' selected");
                    PromptUserForMenu();
                    break;
                case 'g':
                    Console.WriteLine("Exiting...");
                    ExitApp();
                    break;
                default:
                    Console.WriteLine("\nInvalid option. Please select a valid option.");
                    break;
            }

            Console.WriteLine();
        }
    }

    private static void PromptUserForBudgetsSubMenu(List<Budget>? sortedBudgets)
    {
        while (!promptUserToAddBudgetExit)
        {
            const int spacing = -30;

            Console.Write($"{"\n",spacing}");
            Console.WriteLine("Select an option:");
            Console.WriteLine(
                $"{"a) Add Budget",spacing} {"b) Edit Budget",spacing} {"c) Delete Budget",spacing}");
            Console.WriteLine(
                $"{"d) Main Menu",spacing} {"e) Exit",spacing}");

            Console.Write("\n\nEnter your choice: ");
            char choice = char.ToLower(Console.ReadKey().KeyChar);
            Console.WriteLine();

            switch (choice)
            {
                case 'a':
                    Console.WriteLine("\nOption 'Add Budget' selected");
                    CreateNewBudget();
                    break;
                case 'b':
                    Console.WriteLine("Option 'Edit Budget' selected");
                    EditBudget(sortedBudgets!);
                    break;
                case 'c':
                    Console.WriteLine("Option 'Delete Budget' selected");
                    DeleteBudget(sortedBudgets!);
                    break;
                case 'd':
                    Console.WriteLine("Option 'Main Menu' selected");
                    PromptUserForMenu();
                    break;
                case 'e':
                    Console.WriteLine("Exiting...");
                    ExitApp();
                    break;
                default:
                    Console.WriteLine("\nInvalid option. Please select a valid option.");
                    break;
            }

            Console.WriteLine();
        }
    }


    private static Category PromptUserForCategory(CategoryType categoryType)
    {
        Category? selectedCategory = null;

        bool selected = false;

        while (!selected)
        {
            Console.WriteLine("Select one of the following categories:");

            int index = 0;

            var categoriesFromType = new List<Category>();

            foreach (var cat in categories)
            {
                if (cat.CategoryType == categoryType)
                {
                    categoriesFromType.Add(cat);
                }
            }

            foreach (Category category in categoriesFromType)
            {
                index++;

                Console.WriteLine($"{index}) {category.CategoryName}");
            }

            Console.Write("Enter your choice: ");

            char choiceChar = Console.ReadKey().KeyChar;

            if (int.TryParse(choiceChar.ToString(), out int choice))
            {
                if (choice >= 1 && choice <= categoriesFromType.Count)
                {
                    Console.WriteLine($"\n\n You have selected {categoriesFromType[choice - 1].CategoryName}");
                    selectedCategory = categoriesFromType[choice - 1];
                    selected = true;
                }
            }
            else Console.WriteLine("\n\nInvalid input. Please enter a number.\n");
        }


        return selectedCategory!;
    }

    private static void CreateNewTransaction(TransactionType transactionType)
    {
        Console.WriteLine("\nAdd the details of the transaction below\n");

        DateOnly? date = null;

        while (date == null)
        {
            Console.WriteLine($"\nEnter Date (Format: {MyDateFormat.Format}): ");

            string? dateString = Console.ReadLine();

            date = DateConverter.ToDateOnly(dateString!);
        }

        string? amount = null;

        while (string.IsNullOrEmpty(amount))
        {
            Console.WriteLine("\nInput the amount: \n");
            amount = Console.ReadLine();

            if (amount != null && !(amount == "" || double.TryParse(amount, out _)))
            {
                Console.WriteLine("\nYou must input Transaction Amount!!!\n");

                amount = null;
            }
        }

        // Category? category = PromptUserForCategory();

        Category? category = null;

        if (transactionType == TransactionType.Expense)
        {
            category = PromptUserForCategory(CategoryType.Expense);
        }
        else if (transactionType == TransactionType.Income)
        {
            category = PromptUserForCategory(CategoryType.Income);
        }


        Console.Write($"\nInput transaction description (optional)\n");
        string? description = Console.ReadLine();


        try
        {
            Transaction transaction = new Transaction(Double.Parse(amount), category, transactionType, date.Value, "");

            if (!string.IsNullOrEmpty(description))
            {
                transaction.Description = description;
            }

            transactions.Add(transaction);

            Console.WriteLine();

            Console.Write($"{"",-5}{new string('-', 10)}");
            Console.Write("Added Successfully");
            Console.Write($"{new string('-', 10)}");

            transaction.Display(null);
        }
        catch (FormatException ex)
        {
            //TODO Error Handling
            Console.WriteLine(ex.Message);
        }
    }


    private static void PromptForEditTransaction(Transaction selectedTransaction)
    {
        Console.WriteLine("\nAdd the details of the transaction below\n");

        DateOnly? date = null;

        while (date == null)
        {
            Console.WriteLine($"\nEnter Transaction's Date (Format: {MyDateFormat.Format}): ");
            Console.WriteLine("(Press Enter to skip changing this)");

            string? dateString = Console.ReadLine();

            if (string.IsNullOrEmpty(dateString))
            {
                Console.WriteLine("You did not edit Transaction's Date");
                break;
            }

            date = DateConverter.ToDateOnly(dateString!);

            if (date != null)
            {
                selectedTransaction.Date = date.Value;
            }
        }

        string? amount = null;

        while (string.IsNullOrEmpty(amount))
        {
            Console.WriteLine("\nInput the Transaction Amount: ");
            Console.WriteLine("(Press Enter to skip changing this)");

            amount = Console.ReadLine();

            if (string.IsNullOrEmpty(amount))
            {
                Console.WriteLine("You did not edit Amount");
                break;
            }

            if (double.TryParse(amount, out var amountToDouble))
            {
                selectedTransaction.Amount = amountToDouble;

                if (!(amount == "" || double.TryParse(amount, out _)))
                {
                    Console.WriteLine("\nYou must input Transaction Amount!!!\n");
                    amount = null;
                }
            }
        }

        Console.Write($"\nInput transaction description (optional)\n");
        string? description = Console.ReadLine();
        if (!string.IsNullOrEmpty(description))
        {
            selectedTransaction.Description = description;
        }

        Console.WriteLine();

        Console.Write($"{"",-5}{new string('-', 10)}");
        Console.Write("Edited Successfully");
        Console.Write($"{new string('-', 10)}");

        selectedTransaction.Display(null);

        DisplayTransactionsMenu(SortType.DateDescending);
    }

    private static void PromptForEditBudget(Budget selectedBudget)
    {
        Console.WriteLine("\nAdd the details of the Budget below\n");

        DateOnly? startDate = null;

        while (startDate == null)
        {
            Console.WriteLine($"\nEnter Budget's Start Date (Format: {MyDateFormat.Format}): ");
            Console.WriteLine("(Press Enter to skip changing this)");

            string? dateString = Console.ReadLine();

            if (string.IsNullOrEmpty(dateString))
            {
                Console.WriteLine("You did not edit Start Date");
                break;
            }

            startDate = DateConverter.ToDateOnly(dateString!);

            if (startDate != null)
            {
                selectedBudget.StartDate = startDate.Value;
            }
        }

        DateOnly? endDate = null;

        while (endDate == null)
        {
            Console.WriteLine($"\nEnter Budget's End Date (Format: {MyDateFormat.Format}): ");
            Console.WriteLine("(Press Enter to skip changing this)");

            string? dateString = Console.ReadLine();

            if (string.IsNullOrEmpty(dateString))
            {
                Console.WriteLine("You did not edit End Date");
                break;
            }

            endDate = DateConverter.ToDateOnly(dateString!);

            if (endDate != null)
            {
                selectedBudget.EndDate = endDate.Value;

                if (endDate < selectedBudget.StartDate)
                {
                    Console.WriteLine($"\nBudget's End Date must be a date on or after Start Date!!!\n ");

                    endDate = null;
                }
            }
        }

        string? amount = null;

        while (string.IsNullOrEmpty(amount))
        {
            Console.WriteLine("\nInput the Budget Amount: ");
            Console.WriteLine("(Press Enter to skip changing this)");

            amount = Console.ReadLine();

            if (string.IsNullOrEmpty(amount))
            {
                Console.WriteLine("You did not edit Amount");
                break;
            }

            if (double.TryParse(amount, out var amountToDouble))
            {
                selectedBudget.Amount = amountToDouble;

                if (!(amount == "" || double.TryParse(amount, out _)))
                {
                    Console.WriteLine("\nYou must input Budget Amount!!!\n");
                    amount = null;
                }
            }
        }

        //TODO: Editing Category of Budget
        // Category? category = PromptUserForCategory(CategoryType.Expense);

        Console.WriteLine();

        Console.Write($"{"",-5}{new string('-', 10)}");
        Console.Write("Edited Successfully");
        Console.Write($"{new string('-', 10)}");

        selectedBudget.Display(null);
    }

    private static void PromptForEditCategory(Category selectedCategory)
    {
        Console.WriteLine("\nAdd the details of the category below\n");

        string? name = null;

        while (string.IsNullOrEmpty(name))
        {
            Console.WriteLine("\nInput the Category's New Name: ");
            Console.WriteLine("(Press Enter to skip changing this)");
            name = Console.ReadLine();

            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("You did not edit Name");
                break;
            }

            selectedCategory.CategoryName = name;
        }

        Console.Write($"\nInput category description (optional)\n");
        string? description = Console.ReadLine();
        if (!string.IsNullOrEmpty(description))
        {
            selectedCategory.CategoryDescription = description;
        }


        Console.WriteLine();

        Console.Write($"{"",-5}{new string('-', 10)}");
        Console.Write("Edited Successfully. Edited Category: ");
        Console.Write($"{new string('-', 10)}");

        selectedCategory.Display(null);

        DisplayCategoriesMenu(SortType.CategoryNameAscending, "Date - Ascending");
    }


    private static void CreateNewCategory(CategoryType categoryType)
    {
        Console.WriteLine("\nAdd the details of the Category below\n");

        string? name = null;

        while (string.IsNullOrEmpty(name))
        {
            Console.WriteLine("\nInput the name: \n");
            name = Console.ReadLine();

            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("\nYou must input Category's name!!!\n");

                name = null;
            }
        }

        // Category? category = PromptUserForCategory();

        CategoryType? selectedCategoryType = categoryType;

        //TODO Check if I need to request Category type again


        Console.Write($"\nInput transaction description (optional)\n");

        string? description = Console.ReadLine();
        try

        {
            Category category = new Category(name, selectedCategoryType!.Value);

            if (!string.IsNullOrEmpty(description))
            {
                category.CategoryDescription = description;
            }

            categories.Add(category);

            Console.WriteLine();

            Console.Write($"{"",-5}{new string('-', 10)}");
            Console.Write("Added Successfully");
            Console.Write($"{new string('-', 10)}");

            category.Display(null);

            DisplayCategoriesMenu(SortType.Name, "Name - Ascending");
        }
        catch
            (FormatException ex)
        {
        }
    }


    private static void CreateNewBudget()
    {
        Console.WriteLine("\nAdd the details of the Budget below\n");

        DateOnly? startDate = null;

        while (startDate == null)
        {
            Console.WriteLine($"\nEnter Budget's Start Date (Format: {MyDateFormat.Format}): ");

            string? dateString = Console.ReadLine();

            startDate = DateConverter.ToDateOnly(dateString!);
        }

        DateOnly? endDate = null;

        while (endDate == null)
        {
            Console.WriteLine($"\nEnter Budget's End Date (Format: {MyDateFormat.Format}): ");

            string? dateString = Console.ReadLine();

            endDate = DateConverter.ToDateOnly(dateString!);

            if (endDate < startDate)
            {
                Console.WriteLine($"\nBudget's End Date must be a date on or after Start Date!!!\n ");

                endDate = null;
            }
        }

        string? amount = null;

        while (string.IsNullOrEmpty(amount))
        {
            Console.WriteLine("\nInput the Budget Amount: \n");
            amount = Console.ReadLine();

            if (amount != null && !(amount == "" || double.TryParse(amount, out _)))
            {
                Console.WriteLine("\nYou must input Budget Amount!!!\n");

                amount = null;
            }
        }

        Category? category = PromptUserForCategory(CategoryType.Expense);

        //TODO: Budget Description
        // Console.Write($"\nInput transaction description (optional)\n");
        // string? description = Console.ReadLine();


        try
        {
            if (!double.TryParse(amount, out var doubleAmount))
            {
            }

            Budget budget = new Budget(doubleAmount, startDate.Value, endDate.Value, category);

            budgets.Add(budget);

            Console.WriteLine();

            Console.Write($"{"",-5}{new string('-', 10)}");
            Console.Write("Added Successfully");
            Console.Write($"{new string('-', 10)}");

            budget.Display(null);
        }
        catch (FormatException ex)
        {
            //TODO Error Handling
            Console.WriteLine(ex.Message);
        }
    }

    private static CategoryType? PromptUserForCategoryType(CategoryType expense)
    {
        while (!promptUserForCategoryTypeExit)
        {
            //TODO
            Console.WriteLine("\nSelect the category: \n");

            Console.Write($"{"a) Income",-10}");
            Console.Write($"{"",-10}");
            Console.Write($"{"b) Expense",-10}");
            Console.Write($"{"",-10}");
            Console.Write($"{"c) Main Menu",-10}");
            Console.Write($"{"",-10}");
            Console.Write($"{"d) Exit",-10}");

            Console.WriteLine();

            Console.Write("Enter your choice: ");
            char choice = char.ToLower(Console.ReadKey().KeyChar);
            Console.WriteLine();

            switch (choice)
            {
                case 'a':
                    Console.WriteLine("\nOption 'Income' selected");
                    return CategoryType.Income;
                case 'b':
                    Console.WriteLine("Option 'Expense' selected");
                    return CategoryType.Expense;
                case 'c':
                    Console.WriteLine("Option 'Main Menu' selected");
                    PromptUserForMenu();
                    return null;
                case 'd':
                    Console.WriteLine("Exiting the application...");
                    ExitApp();
                    return null;
                default:
                    Console.WriteLine("Invalid option. Please select a valid option.");
                    return null;
            }

            Console.WriteLine();
        }

        return null;
    }

    private static double CalculateTotalTransaction(List<Transaction> transactions, TransactionType transactionType)
    {
        double total = 0;

        foreach (Transaction transaction in transactions)
        {
            if (transaction.TransactionType == transactionType)
            {
                total += transaction.Amount;
            }
        }

        return total;
    }

    private static double CalculateBalance(List<Transaction> transactions)
    {
        double totalIncome = 0;

        double totalExpense = 0;

        foreach (Transaction transaction in transactions)
        {
            if (transaction.TransactionType == TransactionType.Income)
            {
                totalIncome += transaction.Amount;
            }
            else if (transaction.TransactionType == TransactionType.Expense)
            {
                totalExpense += transaction.Amount;
            }
        }

        return totalIncome - totalExpense;
    }

    private static void DisplaySpendingMenu(List<Transaction> transactions, string displayName)
    {
        Console.WriteLine("\n\n");
        Console.Write($"{new string('=', 30)}");
        Console.Write("Spending Menu");
        Console.Write($"{new string('=', 30)}");

        Console.WriteLine();

        Console.WriteLine($"{"Display: ",-5}{displayName,-5}");

        Console.Write($"{new string('-', 30)}");

        Console.WriteLine();

        Console.WriteLine(
            $"{"Income",-10}{CurrencyFormat.CurrencyValue(CalculateTotalTransaction(transactions, TransactionType.Income)),-5}");

        Console.WriteLine();

        Console.WriteLine(
            $"{"Expense",-10}{CurrencyFormat.CurrencyValue(CalculateTotalTransaction(transactions, TransactionType.Expense)),-5}");

        Console.WriteLine($"{new string('-', 50)}");
        Console.WriteLine($"{"Balance",-10}{CurrencyFormat.CurrencyValue(CalculateBalance(transactions)),-5}");

        PromptUserForSpendingSubMenu(false);
    }


    private static void DisplayTransactionsMenu(SortType sortType)
    {
        List<Transaction> sortedTransactions = new List<Transaction>();

        Console.WriteLine("\n\n");
        Console.Write($"{new string('=', 30)}");
        Console.Write("Transactions Menu");
        Console.Write($"{new string('=', 30)}");

        Console.WriteLine();

        switch (sortType)
        {
            case SortType.Daily:
                sortedTransactions = DisplayTransactionsByDay();
                break;
            case SortType.Monthly:
                sortedTransactions = DisplayTransactionsByMonth();
                break;
            case SortType.Yearly:
                sortedTransactions = DisplayTransactionsByYear();
                break;
            case SortType.DateAscending:
                sortedTransactions = DisplayTransactionsBySortType(SortType.DateAscending, "Date - Ascending");
                break;
            case SortType.DateDescending:
                sortedTransactions = DisplayTransactionsBySortType(SortType.DateDescending, "Date - Descending");
                break;
            case SortType.AmountAscending:
                sortedTransactions = DisplayTransactionsBySortType(SortType.AmountAscending, "Amount - Ascending");
                break;
            case SortType.AmountDescending:
                sortedTransactions = DisplayTransactionsBySortType(SortType.AmountDescending, "Amount - Descending");
                break;
            case SortType.CategoryNameAscending:
                sortedTransactions =
                    DisplayTransactionsBySortType(SortType.CategoryNameAscending, "Category Name - Ascending");
                break;
            case SortType.CategoryNameDescending:
                sortedTransactions =
                    DisplayTransactionsBySortType(SortType.CategoryNameDescending, "Category Name - Descending");
                break;
            default:
                sortedTransactions = DisplayTransactionsBySortType(SortType.DateDescending, "Date - Descending");
                break;
        }

        Console.WriteLine();

        PromptUserForTransactionsSubMenu(true, sortedTransactions);
    }

    private static void DisplayCategoriesMenu(SortType sortType, string displayName)
    {
        List<Category> sortedCategories = new List<Category>();

        Console.WriteLine("\n\n");
        Console.Write($"{new string('=', 30)}");
        Console.Write("Categories Menu");
        Console.Write($"{new string('=', 30)}");

        switch (sortType)
        {
            case SortType.Name:
                sortedCategories = DisplayCategoriesBySortType(SortType.Name, displayName);
                break;
            case SortType.FrequentlyUsed:
                sortedCategories = DisplayCategoriesBySortType(SortType.FrequentlyUsed, displayName);
                break;
            default:
                sortedCategories = DisplayCategoriesBySortType(SortType.Name, "Name");
                break;
        }

        Console.WriteLine();

        PromptUserForCategoriesSubMenu(sortedCategories);
    }

    private static void DisplayBudgetsMenu(SortType sortType, string displayName)
    {
        List<Budget> sortedBudgets = new List<Budget>();

        Console.WriteLine("\n\n");
        Console.Write($"{new string('=', 30)}");
        Console.Write("Budgets Menu");
        Console.Write($"{new string('=', 30)}");

        switch (sortType)
        {
            case SortType.DateAscending:
                sortedBudgets = DisplayBudgetsBySortType(sortType, displayName);
                break;
            default:
                sortedBudgets = DisplayBudgetsBySortType(SortType.DateDescending, displayName);
                break;
        }

        Console.WriteLine();

        //TODO: PromptUserForBudgetsSubMenu
        PromptUserForBudgetsSubMenu(sortedBudgets);
    }

    private static List<Transaction> DisplayTransactionsBySortType(SortType sortType, string displayName)
    {
        Console.WriteLine();

        List<Transaction> sortedTransactions = TransactionSorter.Sort(transactions, sortType);

        Console.Write(
            $"{"",-5}{"Total Income = ",-5}{CurrencyFormat.CurrencyValue(CalculateTotalTransaction(transactions, TransactionType.Income)),-20}");

        Console.WriteLine(
            $"{"Total Expense = ",-5}{CurrencyFormat.CurrencyValue(CalculateTotalTransaction(transactions, TransactionType.Expense)),-5}");

        Console.WriteLine($"{"",-5}{new string('-', 60)}");

        Console.WriteLine("\nDisplay: " + displayName + "\n");

        int count = 1;

        foreach (var transaction in sortedTransactions)
        {

            transaction.Display(count);

            count++;
        }

        return sortedTransactions;
    }

    private static List<Transaction> DisplayTransactionsByDay()
    {
        int previousDay = 2000000000;
        int previousMonth = 200000000;
        int previousYear = 2000000000;

        Console.WriteLine();

        List<Transaction> sortedTransactions = TransactionSorter.Sort(transactions, SortType.DateDescending);

        Console.Write(
            $"{"",-5}{"Total Income = ",-5}{CurrencyFormat.CurrencyValue(CalculateTotalTransaction(transactions, TransactionType.Income)),-20}");
        Console.WriteLine(
            $"{"Total Expense = ",-5}{CurrencyFormat.CurrencyValue(CalculateTotalTransaction(transactions, TransactionType.Expense)),-5}");
        Console.WriteLine($"{"",-5}{new string('-', 60)}");

        Console.WriteLine("\nDisplay: Daily\n");

        int count = 1;

        foreach (var transaction in sortedTransactions)
        {
            if (transaction.Date.Year < previousYear ||
                (transaction.Date.Year == previousYear && transaction.Date.Month < previousMonth) ||
                (transaction.Date.Year == previousYear && transaction.Date.Month == previousMonth &&
                 transaction.Date.Day < previousDay))
            {
                Console.Write($"{"",-5}{new string('-', 10)}");
                Console.Write(MyDateFormat.ToDayMonthYearStringFormat(transaction.Date));
                Console.Write($"{new string('-', 10)}");

                Console.WriteLine();
            }

            var transactionDay = transaction.Date.Day;
            var transactionYear = transaction.Date.Year;
            var transactionMonth = transaction.Date.Month;
            
            transaction.Display(count);
            count++;

            previousDay = transactionDay;
            previousMonth = transactionMonth;
            previousYear = transactionYear;
        }

        return sortedTransactions;
    }

    private static List<Transaction> DisplayTransactionsByMonth()
    {
        int previousMonth = 200000000;
        int previousYear = 2000000000;

        Console.WriteLine();

        List<Transaction> sortedTransactions = TransactionSorter.Sort(transactions, SortType.DateDescending);

        Console.Write(
            $"{"",-5}{"Total Income = ",-5}{CurrencyFormat.CurrencyValue(CalculateTotalTransaction(transactions, TransactionType.Income)),-20}");
        Console.WriteLine(
            $"{"Total Expense = ",-5}{CurrencyFormat.CurrencyValue(CalculateTotalTransaction(transactions, TransactionType.Expense)),-5}");
        Console.WriteLine($"{"",-5}{new string('-', 60)}");

        Console.WriteLine("\nDisplay: Monthly\n");

        int count = 1;

        foreach (var transaction in sortedTransactions)
        {
            if (transaction.Date.Year < previousYear ||
                (transaction.Date.Year == previousYear && transaction.Date.Month < previousMonth))
            {
                Console.Write($"{"",-5}{new string('-', 10)}");
                Console.Write(MyDateFormat.ToMonthYearStringFormat(transaction.Date));
                Console.Write($"{new string('-', 10)}");

                Console.WriteLine();
            }

            transaction.Display(count);

            count++;

            var transactionYear = transaction.Date.Year;
            var transactionMonth = transaction.Date.Month;

            previousMonth = transactionMonth;
            previousYear = transactionYear;
        }

        return sortedTransactions;
    }

    private static List<Transaction> DisplayTransactionsByYear()
    {
        int previousYear = 2000000000;

        Console.WriteLine();

        List<Transaction> sortedTransactions = TransactionSorter.Sort(transactions, SortType.DateDescending);

        Console.Write(
            $"{"",-5}{"Total Income = ",-5}{CurrencyFormat.CurrencyValue(CalculateTotalTransaction(transactions, TransactionType.Income)),-20}");
        Console.WriteLine(
            $"{"Total Expense = ",-5}{CurrencyFormat.CurrencyValue(CalculateTotalTransaction(transactions, TransactionType.Expense)),-5}");
        Console.WriteLine($"{"",-5}{new string('-', 60)}");

        Console.WriteLine("\nDisplay: Yearly\n");

        int count = 1;

        foreach (var transaction in sortedTransactions)
        {
            if (transaction.Date.Year < previousYear)
            {
                Console.Write($"{"",-5}{new string('-', 10)}");
                Console.Write(MyDateFormat.ToYearStringFormat(transaction.Date));
                Console.Write($"{new string('-', 10)}");

                Console.WriteLine();
            }


            transaction.Display(count);

            count++;

            var transactionYear = transaction.Date.Year;

            previousYear = transactionYear;
        }

        return sortedTransactions;
    }

    public static void DisplaySpendingByDisplayType(List<Transaction> transactions, SpendingDisplayType spendingDisplayType)
    {
        List<Transaction> sortedTransactions = new List<Transaction>();

        switch (spendingDisplayType)
        {
            case SpendingDisplayType.ThisDay:
                sortedTransactions = GetSortedTransactions(transactions, SpendingDisplayType.ThisDay);
                DisplaySpendingMenu(sortedTransactions, "This Day");
                break;
            case SpendingDisplayType.ThisWeek:
                sortedTransactions = GetSortedTransactions(transactions, SpendingDisplayType.ThisWeek);
                DisplaySpendingMenu(sortedTransactions, "This Week");
                break;
            case SpendingDisplayType.ThisMonth:
                sortedTransactions = GetSortedTransactions(transactions, SpendingDisplayType.ThisMonth);
                DisplaySpendingMenu(sortedTransactions, "This Month");
                break;
            case SpendingDisplayType.ThisYear:
                sortedTransactions = GetSortedTransactions(transactions, SpendingDisplayType.ThisYear);
                DisplaySpendingMenu(sortedTransactions, "This Year");
                break;
            default:
                sortedTransactions = transactions;
                break;
        }
    }

    private static List<Transaction> GetSortedTransactions(List<Transaction> transactions, SpendingDisplayType spendingDisplayType)
    {
        List<Transaction> sortedTransactions = new List<Transaction>();

        foreach (var transaction in transactions)
        {
            if (spendingDisplayType == SpendingDisplayType.ThisDay && transaction.Date == DateOnly.FromDateTime(DateTime.Today))
            {
                sortedTransactions.Add(transaction);
            }
            else if (spendingDisplayType == SpendingDisplayType.ThisWeek)
            {
                DateOnly today = DateOnly.FromDateTime(DateTime.Today);
                DateOnly startOfWeek = today.AddDays(-6);
                DateOnly endOfWeek = today;

                if (transaction.Date >= startOfWeek && transaction.Date <= endOfWeek)
                {
                    sortedTransactions.Add(transaction);
                }
            }
            else if (spendingDisplayType == SpendingDisplayType.ThisMonth
                     && transaction.Date.Month == DateOnly.FromDateTime(DateTime.Today).Month)
            {
                sortedTransactions.Add(transaction);
            }
            else if (spendingDisplayType == SpendingDisplayType.ThisYear
                     && transaction.Date.Year == DateOnly.FromDateTime(DateTime.Today).Year)
            {
                sortedTransactions.Add(transaction);
            }
        }

        return sortedTransactions;
    }


    private static List<Category> DisplayCategoriesBySortType(SortType sortType, string displayName)
    {
        Console.WriteLine();

        List<Category> sortedCategories = CategorySorter.Sort(categories, sortType);

        Console.WriteLine("\nDisplay: " + displayName + "\n");

        int count = 1;

        foreach (var category in sortedCategories)
        {

            category.Display(count);
            count++;
        }

        return sortedCategories;
    }

    private static List<Budget> DisplayBudgetsBySortType(SortType sortType, string displayName)
    {
        Console.WriteLine();

        List<Budget> sortedBudgets = BudgetSorter.Sort(budgets, sortType);

        Console.WriteLine("\nDisplay: " + displayName + "\n");

        int count = 1;

        foreach (var budget in sortedBudgets)
        {
            budget.Display(count);
            count++;
        }

        return sortedBudgets;
    }

    public static void ExitApp()
    {
        promptUserForMenuExit = true;
        promptUserToAddBudgetExit = true;
        promptUserForChangeDisplay = true;
        promptUserToAddCategoryExit = true;
        promptUserForCategoryTypeExit = true;
        promptUserToAddTransactionExit = true;
        promptUserForChangeDisplayCategories = true;
    }
}