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
    {
        user.Id = 0;
        _connection.Insert(user);
    }
    
    public void Update(User user)
        => _connection.Update(user);

    public void Delete(User user)
    {
        if(user.Id != 0)
            _connection.Update(user);
    }

    public void Delete(int idUser)
    {
        if (idUser != 0)
            return;
        var user = _connection.Get<User>(idUser);
        _connection.Delete(user);
        
    }
}