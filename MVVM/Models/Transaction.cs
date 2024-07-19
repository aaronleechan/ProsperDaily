using System.ComponentModel.DataAnnotations.Schema;
using ProsperDaily.Abstractions;

namespace ProsperDaily.MVVM.Models
{
    public class Transaction : TableData
    {
        [Column("Name")]
        public string Name { get; set; }

        [Column("Amount")]
        public decimal Amount { get; set; }

        [Column("IsIncome")]
        public bool IsIncome { get; set; }

        [Column("TransactionDate")]
        public DateTime TransactionDate { get; set; }
    }

}
