using System;
using System.Collections.Generic;

namespace BusinessObjectLayer;

public partial class Member
{
    public int MemberId { get; set; }

    public string Email { get; set; } = null!;

    public decimal? DollarPoint { get; set; }

    public string Password { get; set; } = null!;

    public string? FullName { get; set; }

    public int RoleId { get; set; }

    public virtual RoleUser Role { get; set; } = null!;

    public virtual ICollection<Transaction> TransactionBuyers { get; set; } = new List<Transaction>();

    public virtual ICollection<Transaction> TransactionSellers { get; set; } = new List<Transaction>();
}
