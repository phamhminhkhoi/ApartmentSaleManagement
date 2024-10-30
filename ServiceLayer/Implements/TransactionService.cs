using System.Collections.Generic;
using BusinessObjectLayer;
using DataAccessLayer.Repository;
using RepositoryLayer.Interfaces;
using ServiceLayer.Interfaces;

namespace ServiceLayer
{
    public class TransactionService : ITransactionService
    {
        private readonly ITransactionRepository _transactionRepository = new TransactionRepository();

        

        public void AddTransaction(Transaction transaction)
        {
            _transactionRepository.AddTransaction(transaction);
        }

        public Transaction GetTransactionById(int transactionId)
        {
            return _transactionRepository.GetTransactionById(transactionId);
        }

        public List<Transaction> GetAllTransactions()
        {
            return _transactionRepository.GetAllTransactions();
        }

        public void UpdateTransaction(Transaction transaction)
        {
            _transactionRepository.UpdateTransaction(transaction);
        }

        public void DeleteTransaction(int transactionId)
        {
            _transactionRepository.DeleteTransaction(transactionId);
        }
    }
}
