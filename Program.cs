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
       //CreateUser();
       //ReadUsers();
       //UpdateUser();
       DeleteUser();
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
    }
    
    public static void ReadUser()
    {
        using (var connection = new SqlConnection(connection_String))
        {
            var user = connection.Get<User>(1);
            Console.WriteLine(user.Name);
        }
    }
    public static void CreateUser()
    {
        var user = new User()
        { Name = "Koda", Bio = "husky", Email = "koda@gmail.com", Image = "https://", Slug = "husky-siberian", PasswordHash = "petisco" };
        using (var connection = new SqlConnection(connection_String))
        {
            connection.Insert<User>(user);
            Console.WriteLine($"Realized cadastro");
        }
    } 
    public static void UpdateUser()
    {
        var user = new User()
        { Id = 2 ,Name = "Koda Alves", Bio = "husky siberiano", Email = "kodaAtentada@gmail.com", Image = "https://", Slug = "husky-siberian", PasswordHash = "petisco" };
        using (var connection = new SqlConnection(connection_String))
        {
            connection.Update<User>(user);
            Console.WriteLine($"User Update");
        }
    }public static void DeleteUser()
    {
        using (var connection = new SqlConnection(connection_String))
        {
            var user = connection.Get<User>(2);
            connection.Delete(user);
            Console.WriteLine($"User Delete");
        }
    }
}

