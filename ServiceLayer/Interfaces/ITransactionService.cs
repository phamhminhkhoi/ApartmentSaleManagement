using System.Collections.Generic;
using BusinessObjectLayer;

namespace ServiceLayer.Interfaces
{
    public interface ITransactionService
    {
        void AddTransaction(Transaction transaction);
        Transaction GetTransactionById(int transactionId);
        List<Transaction> GetAllTransactions();
        void UpdateTransaction(Transaction transaction);
        void DeleteTransaction(int transactionId);
    }
}
