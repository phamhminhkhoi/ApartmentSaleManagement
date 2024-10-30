using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using BusinessObjectLayer;

namespace DataAccessLayer
{
    public class TransactionDAO
    {
        private readonly SaleManagementContext _context;
        public static TransactionDAO instance = null;
        public static TransactionDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TransactionDAO();
                }
                return instance;
            }
        }

        public TransactionDAO()
        {
            _context = new SaleManagementContext();
        }

        // Create
        public void AddTransaction(Transaction transaction)
        {
            _context.Transactions.Add(transaction);
            _context.SaveChanges();
        }

        // Read
        public Transaction GetTransactionById(int transactionId)
        {
            return _context.Transactions
                           .Include(t => t.Buyer).Include(t => t.Seller)
                           .Include(t => t.TransactionDetails)
                           .FirstOrDefault(t => t.TransactionId == transactionId);
        }

        // Read All
        public List<Transaction> GetAllTransactions()
        {
            return _context.Transactions
                           .Include(t => t.Buyer).Include(t => t.Seller)
                           .Include(t => t.TransactionDetails)
                           .ToList();
        }

        // Update
        public void UpdateTransaction(Transaction transaction)
        {
            var existingTransaction = _context.Transactions.Find(transaction.TransactionId);
            if (existingTransaction != null)
            {
                _context.Entry(existingTransaction).CurrentValues.SetValues(transaction);
                _context.SaveChanges();
            }
        }

        // Delete
        public void DeleteTransaction(int transactionId)
        {
            var transaction = _context.Transactions.Find(transactionId);
            if (transaction != null)
            {
                _context.Transactions.Remove(transaction);
                _context.SaveChanges();
            }
        }
    }
}
