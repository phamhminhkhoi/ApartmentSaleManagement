using System.Collections.Generic;
using BusinessObjectLayer;

namespace ServiceLayer.Interfaces
{
    public interface IMemberService
    {
       public Member GetMemberByEmail(string email);
        public Member GetBuyerById(int? Id);
        public Member GetSellerById(int? Id);

        List<Member> GetMembers();
    }
}
