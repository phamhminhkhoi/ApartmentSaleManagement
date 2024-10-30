using BusinessObjectLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Interfaces
{
    public interface ITransactionRepository
    {
        void AddTransaction(Transaction transaction);
        Transaction GetTransactionById(int transactionId);
        List<Transaction> GetAllTransactions();
        void UpdateTransaction(Transaction transaction);
        void DeleteTransaction(int transactionId);
    }
}
