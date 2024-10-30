using System.Collections.Generic;
using BusinessObjectLayer;
using RepositoryLayer.Interfaces;

namespace DataAccessLayer.Repository
{
    public class TransactionRepository : ITransactionRepository
    {
        public void AddTransaction(Transaction transaction)
        {
            TransactionDAO.Instance.AddTransaction(transaction);
        }

        public Transaction GetTransactionById(int transactionId)
        {
            return TransactionDAO.Instance.GetTransactionById(transactionId);
        }

        public List<Transaction> GetAllTransactions()
        {
            return TransactionDAO.Instance.GetAllTransactions();
        }

        public void UpdateTransaction(Transaction transaction)
        {
            TransactionDAO.Instance.UpdateTransaction(transaction);
        }

        public void DeleteTransaction(int transactionId)
        {
            TransactionDAO.Instance.DeleteTransaction(transactionId);
        }
    }
}
