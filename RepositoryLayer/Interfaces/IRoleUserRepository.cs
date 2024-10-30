using BusinessObjectLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Interfaces
{
    public interface IRoleUserRepository
    {
        void AddRoleUser(RoleUser roleUser);
        RoleUser GetRoleUserById(int roleId);
        List<RoleUser> GetAllRoleUsers();
        void UpdateRoleUser(RoleUser roleUser);
        void DeleteRoleUser(int roleId);
    }
}
