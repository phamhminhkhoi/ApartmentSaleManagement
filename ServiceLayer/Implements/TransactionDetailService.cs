using System.Collections.Generic;
using BusinessObjectLayer;
using DataAccessLayer;
using DataAccessLayer.Repository;
using RepositoryLayer.Interfaces;
using ServiceLayer.Interfaces;

namespace ServiceLayer
{
    public class TransactionDetailService : ITransactionDetailService
    {
        private readonly ITransactionDetailRepository _transactionDetailRepository = new TransactionDetailRepository();
        

        public void AddTransactionDetail(TransactionDetail transactionDetail)
        {
            _transactionDetailRepository.AddTransactionDetail(transactionDetail);
        }

        public TransactionDetail GetTransactionDetailById(int transactionDetailId)
        {
            return _transactionDetailRepository.GetTransactionDetailById(transactionDetailId);
        }

        public List<TransactionDetail> GetAllTransactionDetails()
        {
            return _transactionDetailRepository.GetAllTransactionDetails();
        }

        public void UpdateTransactionDetail(TransactionDetail transactionDetail)
        {
            _transactionDetailRepository.UpdateTransactionDetail(transactionDetail);
        }

        public void DeleteTransactionDetail(int transactionDetailId)
        {
            _transactionDetailRepository.DeleteTransactionDetail(transactionDetailId);
        }

        public List<TransactionDetail> GetTransactionDetailsByPropertyId(int propertyId)
        {
            return TransactionDetailDAO.Instance.GetAllTransactionDetails()
                .Where(td => td.PropertyId == propertyId)
                .ToList();
        }

        public TransactionDetail GetTransactionDetailsByTransactionId(int propId)
        {
           return _transactionDetailRepository.TransactionDetailByTransactionId(propId);
        }
    }
}
