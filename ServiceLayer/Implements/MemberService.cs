using System.Collections.Generic;
using BusinessObjectLayer;
using DataAccessLayer.Repository;
using RepositoryLayer.Interfaces;
using ServiceLayer.Interfaces;

namespace ServiceLayer
{
    public class MemberService : IMemberService
    {
        private readonly IMemberRepository _memberRepository = new MemberRepository();



        public Member GetMemberByEmail(string email)
        {
            return _memberRepository.GetMemberByEmail(email);
        }

        public Member GetBuyerById(int? Id)
        {
            return _memberRepository.GetBuyerById(Id);
        }

        public Member GetSellerById(int? Id)
        {
            return _memberRepository.GetSellerById(Id);

        }

        public List<Member> GetMembers()
        {
            return _memberRepository.GetAllMembers();
        }
    }
}
