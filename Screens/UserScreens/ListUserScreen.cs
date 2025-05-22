using BlogData.Models;
using BlogData.Repositories;

namespace BlogData.Screens.UserScreens;

public class ListUserScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Loading....");
        Console.WriteLine("Listing all users");
        List();
        Console.ReadKey();
        MenuUserScreen.Load();
    }

    public static void List()
    {
        var repository = new Repository<User>(Database.Connection); 
        var listUser = repository.Get();
        foreach (var item in listUser)
        {
            Console.WriteLine($"{item.Id} - {item.Name} - {item.Email}");
        }
    }
}