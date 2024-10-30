using System;
using System.Collections.Generic;

namespace BusinessObjectLayer;

public partial class Property
{
    public int PropertyId { get; set; }

    public string PropertyName { get; set; } = null!;

    public string Location { get; set; } = null!;

    public string? Description { get; set; }

    public decimal Price { get; set; }

    public int SizeSqFt { get; set; }

    public int? Bedrooms { get; set; }

    public int? Bathrooms { get; set; }

    public int CategoryId { get; set; }

    public virtual PropertyCategory Category { get; set; } = null!;

    public virtual ICollection<TransactionDetail> TransactionDetails { get; set; } = new List<TransactionDetail>();
}
