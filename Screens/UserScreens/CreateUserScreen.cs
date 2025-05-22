using BlogData.Models;
using BlogData.Repositories;

namespace BlogData.Screens.UserScreens;

public class CreateUserScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Loading.....");
        Console.WriteLine("Create a user");
        Console.Write("Name: ");
        string userName = Console.ReadLine();
        Console.Write("Email: ");
        string userEmail = Console.ReadLine();
        Console.Write("Password: ");
        string userPassword = Console.ReadLine();
        Console.Write("Bio: ");
        string userBio = Console.ReadLine();
        Console.Write("Image: ");
        string userImage = Console.ReadLine();
        Console.Write("Slug: ");
        string userSlug = Console.ReadLine();

        var newUser = new User(userName, userEmail, userPassword, userBio, userImage, userSlug);
        Create(newUser);
        Console.ReadKey();
        MenuUserScreen.Load();
    }

    public static void Create(User user)
    {
        try
        {
            var repository = new Repository<User>(Database.Connection);
            repository.Create(user);
            Console.WriteLine("User created");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}