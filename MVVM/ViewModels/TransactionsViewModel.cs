using ProsperDaily.MVVM.Models;

namespace ProsperDaily.MVVM.ViewModels
{
    public class TransactionsViewModel
    {
        public Transaction Transaction { get; set; } = new Transaction
        {
            TransactionDate = DateTime.Now
        };
        

        public string SaveTransaction()
        {
            try
            {
                App.TransactionsRepo.SaveItem(Transaction);
                return App.TransactionsRepo.StatusMessage;
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }
    }
}
