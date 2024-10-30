using BusinessObjectLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Interfaces
{
    public interface ITransactionDetailRepository
    {
        void AddTransactionDetail(TransactionDetail transactionDetail);
        TransactionDetail GetTransactionDetailById(int transactionDetailId);
        List<TransactionDetail> GetAllTransactionDetails();
        void UpdateTransactionDetail(TransactionDetail transactionDetail);
        void DeleteTransactionDetail(int transactionDetailId);
        TransactionDetail TransactionDetailByTransactionId(int transId);
        List<TransactionDetail> GetTransactionDetailsByPropertyId(int propId);
    }
}
