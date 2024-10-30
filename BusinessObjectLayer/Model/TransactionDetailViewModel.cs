using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjectLayer.Model
{
    public class TransactionDetailViewModel
    {
        public string PropertyName { get; set; }
        public string TransactionDate { get; set; }
        public decimal Price { get; set; }
        public string BuyerName { get; set; }
        public string SellerName { get; set; }
    }
}
