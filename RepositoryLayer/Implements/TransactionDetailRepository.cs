using System.Collections.Generic;
using BusinessObjectLayer;
using RepositoryLayer.Interfaces;

namespace DataAccessLayer.Repository
{
    public class TransactionDetailRepository : ITransactionDetailRepository
    {
        public void AddTransactionDetail(TransactionDetail transactionDetail)
        {
            TransactionDetailDAO.Instance.AddTransactionDetail(transactionDetail);
        }

        public TransactionDetail GetTransactionDetailById(int transactionDetailId)
        {
            return TransactionDetailDAO.Instance.GetTransactionDetailById(transactionDetailId);
        }

        public List<TransactionDetail> GetAllTransactionDetails()
        {
            return TransactionDetailDAO.Instance.GetAllTransactionDetails();
        }

        public void UpdateTransactionDetail(TransactionDetail transactionDetail)
        {
            TransactionDetailDAO.Instance.UpdateTransactionDetail(transactionDetail);
        }

        public void DeleteTransactionDetail(int transactionDetailId)
        {
            TransactionDetailDAO.Instance.DeleteTransactionDetail(transactionDetailId);
        }

        public TransactionDetail TransactionDetailByTransactionId(int transId)
        {
            return TransactionDetailDAO.Instance.GetTransactionDetailByTransactionId(transId);
        }

        public List<TransactionDetail> GetTransactionDetailsByPropertyId(int propId)
        {
            return TransactionDetailDAO.Instance.GetTransactionDetailsByPropertyId(propId);
        }
    }
}
