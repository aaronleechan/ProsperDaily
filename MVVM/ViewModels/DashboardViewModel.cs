
using System.Collections.ObjectModel;
using Android.Database;
using PropertyChanged;
using ProsperDaily.MVVM.Models;

namespace ProsperDaily;

[AddINotifyPropertyChangedInterface]

public class DashboardViewModel
{
    public ObservableCollection<Transaction> Transactions { get; set; }
    public decimal Balance { get; set; }
    public decimal Income { get; set; }
    public decimal Expenses { get; set; }

    public DashboardViewModel()
    {
        FillData();
    }

    public void FillData()
    {
        var transactions = App.TransactionsRepo.GetItems();
        transactions = transactions.OrderByDescending(x => x.TransactionDate).ToList();
        Transactions = new ObservableCollection<Transaction>(transactions);

        Balance = 0;
        Income = 0;
        Expenses = 0;

        foreach (var transaction in transactions)
        {
            if (transaction.IsIncome)
            {
                Income += transaction.Amount;
            }
            else
            {
                Expenses += transaction.Amount;
            }
        }

        Balance = Income - Expenses;
    }
}
