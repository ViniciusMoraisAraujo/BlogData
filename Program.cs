using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;
using BlogData.Models;

namespace BlogData;

class Program
{
    private const string connection_String = @"Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$; TrustServerCertificate=true";

    static void Main(string[] args)
    {
        //ReadUsers();
        //ReadUser();
    }

    public static void ReadUsers()
    {
        using (var connection = new SqlConnection(connection_String))
        {
            var users = connection.GetAll<User>();
            foreach (var user in users)
            {
                Console.WriteLine(user.Name);
            }
        }
    }public static void ReadUser()
    {
        using (var connection = new SqlConnection(connection_String))
        {
            var user = connection.Get<User>(1);
            Console.WriteLine(user.Name);
        }
    }
}

