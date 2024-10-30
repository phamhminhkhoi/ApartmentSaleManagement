using System.Collections.Generic;
using BusinessObjectLayer;
using DataAccessLayer.Repository;
using RepositoryLayer.Interfaces;
using ServiceLayer.Interfaces;

namespace ServiceLayer
{
    public class RoleUserService : IRoleUserService
    {
        private readonly IRoleUserRepository _roleUserRepository = new RoleUserRepository();

        public void AddRoleUser(RoleUser roleUser)
        {
            _roleUserRepository.AddRoleUser(roleUser);
        }

        public RoleUser GetRoleUserById(int roleId)
        {
            return _roleUserRepository.GetRoleUserById(roleId);
        }

        public List<RoleUser> GetAllRoleUsers()
        {
            return _roleUserRepository.GetAllRoleUsers();
        }

        public void UpdateRoleUser(RoleUser roleUser)
        {
            _roleUserRepository.UpdateRoleUser(roleUser);
        }

        public void DeleteRoleUser(int roleId)
        {
            _roleUserRepository.DeleteRoleUser(roleId);
        }
    }
}
