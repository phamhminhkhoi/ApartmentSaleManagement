using System.Collections.Generic;
using BusinessObjectLayer;

namespace ServiceLayer.Interfaces
{
    public interface IRoleUserService
    {
        void AddRoleUser(RoleUser roleUser);
        RoleUser GetRoleUserById(int roleId);
        List<RoleUser> GetAllRoleUsers();
        void UpdateRoleUser(RoleUser roleUser);
        void DeleteRoleUser(int roleId);
    }
}
