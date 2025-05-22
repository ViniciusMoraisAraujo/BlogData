using BlogData.Models;
using BlogData.Repositories;

namespace BlogData.Screens.UserScreens;

public class DeleteUserScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Loading.....");
        Console.WriteLine("Delete a user");
        Console.Write("Id: ");
        int userId = int.Parse(Console.ReadLine());
        var newUser = new User(userId);
        Delete(newUser);
        Console.ReadKey();
        MenuUserScreen.Load();
    }

    public static void Delete(User user)
    {
        try
        {
            var repository = new Repository<User>(Database.Connection);
            repository.Delete(user);
            Console.WriteLine("User deleted");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    } 
}
