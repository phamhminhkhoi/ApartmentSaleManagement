using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using BusinessObjectLayer;

namespace DataAccessLayer
{
    public class TransactionDetailDAO
    {
        private readonly SaleManagementContext _context;
        public static TransactionDetailDAO instance = null;
        public static TransactionDetailDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TransactionDetailDAO();
                }
                return instance;
            }
        }

        public TransactionDetailDAO()
        {
            _context = new SaleManagementContext();
        }

        // Create
        public void AddTransactionDetail(TransactionDetail transactionDetail)
        {
            _context.TransactionDetails.Add(transactionDetail);
            _context.SaveChanges();
        }

        // Read
        public TransactionDetail GetTransactionDetailById(int transactionDetailId)
        {
            return _context.TransactionDetails
                           .Include(td => td.Property)
                           .Include(td => td.Transaction)
                           .FirstOrDefault(td => td.TransactionDetailId == transactionDetailId);
        }

        // Read All
        public List<TransactionDetail> GetAllTransactionDetails()
        {
            return _context.TransactionDetails
                           .Include(td => td.Property)
                           .Include(td => td.Transaction)
                           .ToList();
        }

        public List<TransactionDetail> GetTransactionDetailsByPropertyId(int propertyId)
        {
            return _context.TransactionDetails
                .Include(td => td.Transaction)
                .ThenInclude(t => t.Seller).Include(t => t.Transaction).ThenInclude(t => t.Buyer)
                .Where(td => td.PropertyId == propertyId)
                .ToList();
        }



        public TransactionDetail GetTransactionDetailByTransactionId(int transactionId)
        {
            return _context.TransactionDetails
                           .Include(td => td.Property)
                           .Include(td => td.Transaction)
                           .FirstOrDefault(td => td.TransactionId == transactionId);
        }


        // Update
        public void UpdateTransactionDetail(TransactionDetail transactionDetail)
        {
            var existingTransactionDetail = _context.TransactionDetails.Find(transactionDetail.TransactionDetailId);
            if (existingTransactionDetail != null)
            {
                _context.Entry(existingTransactionDetail).CurrentValues.SetValues(transactionDetail);
                _context.SaveChanges();
            }
        }

        // Delete
        public void DeleteTransactionDetail(int transactionDetailId)
        {
            var transactionDetail = _context.TransactionDetails.Find(transactionDetailId);
            if (transactionDetail != null)
            {
                _context.TransactionDetails.Remove(transactionDetail);
                _context.SaveChanges();
            }
        }
    }
}
