using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;
using BlogData.Models;

namespace BlogData.Repositories;

public class RoleRepository
{
    private readonly SqlConnection _connection;

    public RoleRepository(SqlConnection connection)
        => _connection = connection;

    public IEnumerable<Role> Get()
        => _connection.GetAll<Role>();

    public Role Get(int id)
        => _connection.Get<Role>(id);

    public void Create(Role role)
        => _connection.Insert(role);

    public void Update(Role role)
        => _connection.Update(role);

    public void Delete(Role role)
    {
        if (role.Id != 0)
            _connection.Update(role);
    }

    public void Delete(int roleId)
    {
        if (roleId != 0)
            return;
        var user = _connection.Get<Role>(roleId);
        _connection.Delete(user);
    }
}