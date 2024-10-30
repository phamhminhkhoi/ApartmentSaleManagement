using System;
using System.Collections.Generic;

namespace BusinessObjectLayer;

public partial class Transaction
{
    public int TransactionId { get; set; }

    public DateTime TransactionDate { get; set; }

    public int? BuyerId { get; set; }

    public int? SellerId { get; set; }

    public decimal TotalAmount { get; set; }

    public virtual Member? Buyer { get; set; }

    public virtual Member? Seller { get; set; }

    public virtual ICollection<TransactionDetail> TransactionDetails { get; set; } = new List<TransactionDetail>();
}
