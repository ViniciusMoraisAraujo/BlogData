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
        =>_connection.Get<Role>(id);
    
    public void Create(Role role) 
        => _connection.Insert(role);

}