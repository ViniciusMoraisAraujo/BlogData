using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;
using BlogData.Models;
using BlogData.Repositories;

namespace BlogData;

class Program
{
    private const string connection_String = @"Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$; TrustServerCertificate=true";

    static void Main(string[] args)
    {
        var connection = new SqlConnection(connection_String);
        connection.Open();
        ReadUsers(connection);
        ReadRoles(connection);
        connection.Close();
    }

    public static void ReadUsers(SqlConnection connection)
    {
        var repository = new UserRepository(connection);
        foreach (var user in repository.Get())
            Console.WriteLine(user.Name);
    }

    public static void ReadRoles(SqlConnection connection)
    {
        var repository = new RoleRepository(connection);
        foreach (var role in repository.Get())
            Console.WriteLine(role.Name);
    }
}
