using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;
using BlogData.Models;

namespace BlogData.Repositories;

public class UserRepository
{
    private readonly SqlConnection _connection;

    public UserRepository(SqlConnection connection)
        => _connection = connection;
    public IEnumerable<User> Get()
        => _connection.GetAll<User>();

    public User GetById(int userId)
        =>_connection.Get<User>(userId);
    
    public void Create(User user) 
        => _connection.Insert(user);
    
    
}