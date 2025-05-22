namespace BlogData.Screens.UserScreens;

public class MenuUserScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Menu User Screen");
        Console.WriteLine("---------------");
        Console.WriteLine();
        Console.WriteLine("Select an option:");
        Console.WriteLine("1. List a user");
        Console.WriteLine("2. New user");
        Console.WriteLine("3. Edit user");
        Console.WriteLine("4. Delete user");
        Console.WriteLine();
        var option = int.Parse(Console.ReadLine()!);

        switch (option)
        {
            case 1:
                ListUserScreen.Load();
                break;
            case 2:
                CreateUserScreen.Load();
                break;
            case 3:
                UpdateUserScreen.Load();
                break;
            case 4:
                DeleteUserScreen.Load();
                break;
            default: Load(); break;
        }
    }
}