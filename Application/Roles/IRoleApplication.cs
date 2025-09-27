using Application.Roles.DTO;
using Domain;

namespace Application.Roles;

public interface IRoleApplication
{
    Task<Role> AddRole(CreateUpdateRoleDto input);

    Task<Role> UpdateRole(int id, CreateUpdateRoleDto input);

    Task DeleteRole(int id);

    Task<List<RoleDto>> GetAllRoles();

}
