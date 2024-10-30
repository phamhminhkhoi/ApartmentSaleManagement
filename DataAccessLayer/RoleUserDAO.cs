using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using BusinessObjectLayer;

namespace DataAccessLayer
{
    public class RoleUserDAO
    {
        private readonly SaleManagementContext _context;
        public static RoleUserDAO instance = null;
        public static RoleUserDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RoleUserDAO();
                }
                return instance;
            }
        }

        public RoleUserDAO()
        {
            _context = new SaleManagementContext();
        }

        // Create
        public void AddRoleUser(RoleUser roleUser)
        {
            _context.RoleUsers.Add(roleUser);
            _context.SaveChanges();
        }

        // Read
        public RoleUser GetRoleUserById(int roleId)
        {
            return _context.RoleUsers
                           .Include(ru => ru.Members)
                           .FirstOrDefault(ru => ru.RoleId == roleId);
        }

        // Read All
        public List<RoleUser> GetAllRoleUsers()
        {
            return _context.RoleUsers
                           .Include(ru => ru.Members)
                           .ToList();
        }

        // Update
        public void UpdateRoleUser(RoleUser roleUser)
        {
            var existingRoleUser = _context.RoleUsers.Find(roleUser.RoleId);
            if (existingRoleUser != null)
            {
                _context.Entry(existingRoleUser).CurrentValues.SetValues(roleUser);
                _context.SaveChanges();
            }
        }

        // Delete
        public void DeleteRoleUser(int roleId)
        {
            var roleUser = _context.RoleUsers.Find(roleId);
            if (roleUser != null)
            {
                _context.RoleUsers.Remove(roleUser);
                _context.SaveChanges();
            }
        }
    }
}
