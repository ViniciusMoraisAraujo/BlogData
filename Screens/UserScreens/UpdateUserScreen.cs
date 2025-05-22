using BlogData.Models;
using BlogData.Repositories;
using BlogData.Screens.CategoryScreens;

namespace BlogData.Screens.UserScreens;

public class UpdateUserScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Loading.....");
        Console.WriteLine("Update a user");
        Console.Write("Enter the id of the user: ");
        int userId = int.Parse(Console.ReadLine());
        Console.Write("Enter the name of the user: ");
        string userName = Console.ReadLine();
        Console.Write("Enter the email of the user: ");
        string userEmail = Console.ReadLine();
        Console.Write("Enter the password of the user: ");
        string userPassword = Console.ReadLine();
        Console.Write("Enter the bio of the user: ");
        string userBio = Console.ReadLine();
        Console.WriteLine("Enter the image of the user: ");
        string userImage = Console.ReadLine();
        Console.Write("Enter the slug of the user: ");
        string userSlug = Console.ReadLine();
        var newUser = new User(userId, userName, userEmail, userPassword, userBio, userImage, userSlug);
        Update(newUser);
        Console.ReadKey();
        MenuUserScreen.Load();
    }

    public static void Update(User user)
    {
        try
        {
            var repositories = new Repository<User>(Database.Connection);
            repositories.Update(user);
            Console.WriteLine("Updated user");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}