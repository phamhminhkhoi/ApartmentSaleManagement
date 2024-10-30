using System.Collections.Generic;
using BusinessObjectLayer;
using RepositoryLayer.Interfaces;

namespace DataAccessLayer.Repository
{
    public class RoleUserRepository : IRoleUserRepository
    {
        public void AddRoleUser(RoleUser roleUser)
        {
            RoleUserDAO.Instance.AddRoleUser(roleUser);
        }

        public RoleUser GetRoleUserById(int roleId)
        {
            return RoleUserDAO.Instance.GetRoleUserById(roleId);
        }

        public List<RoleUser> GetAllRoleUsers()
        {
            return RoleUserDAO.Instance.GetAllRoleUsers();
        }

        public void UpdateRoleUser(RoleUser roleUser)
        {
            RoleUserDAO.Instance.UpdateRoleUser(roleUser);
        }

        public void DeleteRoleUser(int roleId)
        {
            RoleUserDAO.Instance.DeleteRoleUser(roleId);
        }
    }
}
