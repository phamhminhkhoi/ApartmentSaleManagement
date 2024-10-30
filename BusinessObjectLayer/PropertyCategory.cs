using System;
using System.Collections.Generic;

namespace BusinessObjectLayer;

public partial class PropertyCategory
{
    public int CategoryId { get; set; }

    public string CategoryName { get; set; } = null!;

    public virtual ICollection<Property> Properties { get; set; } = new List<Property>();

    public override string ToString()
    {
        return CategoryName;
    }
}
