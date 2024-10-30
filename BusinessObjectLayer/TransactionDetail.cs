using System;
using System.Collections.Generic;

namespace BusinessObjectLayer;

public partial class TransactionDetail
{
    public int TransactionDetailId { get; set; }

    public int TransactionId { get; set; }

    public int PropertyId { get; set; }

    public int Quantity { get; set; }

    public decimal Price { get; set; }

    public virtual Property Property { get; set; } = null!;

    public virtual Transaction Transaction { get; set; } = null!;
}
