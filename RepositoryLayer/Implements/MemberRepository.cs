using System.Collections.Generic;
using BusinessObjectLayer;
using RepositoryLayer.Interfaces;

namespace DataAccessLayer.Repository
{
    public class MemberRepository : IMemberRepository
    {

        public Member GetMemberByEmail(string email)
        {
            return MemberDAO.Instance.GetMemberByEmail(email);
        }

        public Member GetBuyerById(int? id)
        {
            return MemberDAO.Instance.GetBuyerById(id);
        }

        public Member GetSellerById(int? id)
        {
            return MemberDAO.Instance.GetSellerById(id);
        }

        public List<Member> GetAllMembers()
        {
            return MemberDAO.Instance.GetMembers();
        }
    }
}
