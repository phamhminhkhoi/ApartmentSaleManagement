using BusinessObjectLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class MemberDAO
    {
        private readonly SaleManagementContext _context;
        public static MemberDAO instance = null;

        public static MemberDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MemberDAO();
                }
                return instance;
            }
        }

        public MemberDAO()
        {
            _context = new SaleManagementContext();
        }

        public Member GetMemberByEmail(string email)
        {
            return  _context.Members.Include(m => m.Role).FirstOrDefault(m => m.Email == email);
        }

        public Member GetBuyerById(int? id) {
            return _context.Members.Include(m => m.Role).FirstOrDefault(m => m.MemberId == id);
        }

        public Member GetSellerById(int? id)
        {
            return _context.Members.Include(m => m.Role).FirstOrDefault(m => m.MemberId == id);
        }

        public List<Member> GetMembers() {
            return _context.Members.Include(m => m.Role).ToList();
        }
    }
}