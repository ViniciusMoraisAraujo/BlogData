using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;
using BlogData.Models;
using BlogData.Repositories;
using BlogData.Screens.CategoryScreens;
using BlogData.Screens.TagScreens;
using BlogData.Screens.UserScreens;

namespace BlogData;

class Program
{
    private const string connection_String = @"Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$; TrustServerCertificate=true";

    static void Main(string[] args)
    {
        Database.Connection = new SqlConnection(connection_String);
        Database.Connection.Open();
        Load();
        Console.ReadKey();
        Database.Connection.Close();
    }

    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Blog");
        Console.WriteLine("--------------");
        Console.WriteLine();
        Console.WriteLine("1 - Management user");
        Console.WriteLine("2 - Management category");
        Console.WriteLine("3 - Management tag");
        Console.WriteLine();
        var option = int.Parse(Console.ReadLine()!);

        switch (option)
        {
            case 1:
                MenuUserScreen.Load();
                break;
            case 2:
                MenuCategoryScreen.Load();
                break;
            case 3:
                MenuTagScreen.Load();
                break;
            default: Load(); break;
        }
    }
}
