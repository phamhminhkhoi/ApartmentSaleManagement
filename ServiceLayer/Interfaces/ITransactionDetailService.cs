using System.Collections.Generic;
using BusinessObjectLayer;

namespace ServiceLayer.Interfaces
{
    public interface ITransactionDetailService
    {
        void AddTransactionDetail(TransactionDetail transactionDetail);
        TransactionDetail GetTransactionDetailById(int transactionDetailId);
        List<TransactionDetail> GetAllTransactionDetails();
        void UpdateTransactionDetail(TransactionDetail transactionDetail);
        void DeleteTransactionDetail(int transactionDetailId);
        TransactionDetail GetTransactionDetailsByTransactionId(int transactionId);
        List<TransactionDetail> GetTransactionDetailsByPropertyId(int propId);
    }
}
