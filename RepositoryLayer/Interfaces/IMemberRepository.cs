using BusinessObjectLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Interfaces
{
    public interface IMemberRepository
    {
        Member GetMemberByEmail(string email);
        Member GetBuyerById(int? id);
        Member GetSellerById(int? id);
        List<Member> GetAllMembers();

    }
}
