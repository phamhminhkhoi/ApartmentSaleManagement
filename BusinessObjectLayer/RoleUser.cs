using System;
using System.Collections.Generic;

namespace BusinessObjectLayer;

public partial class RoleUser
{
    public int RoleId { get; set; }

    public string RoleName { get; set; } = null!;

    public virtual ICollection<Member> Members { get; set; } = new List<Member>();

    public override string ToString()
    {
        return RoleName;
    }
}
