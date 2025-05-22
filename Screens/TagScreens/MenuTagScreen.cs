namespace BlogData.Screens.TagScreens;

public class MenuTagScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Menu Tag Screen");
        Console.WriteLine("---------------");
        Console.WriteLine();
        Console.WriteLine("Select an option:");
        Console.WriteLine("1. List a tag");
        Console.WriteLine("2. New tag");
        Console.WriteLine("3. Edit tag");
        Console.WriteLine("4. Delete tag");
        Console.WriteLine();
        var option = int.Parse(Console.ReadLine()!);

        switch (option)
        {
            case 1:
                ListTagScreen.Load();
                break;
            case 2:
                CreateTagScreen.Load();
                break;
            case 3:
                UpdateTagScreen.Load();
                break;
            case 4:
                DeleteTagScreen.Load();
                break;
            default: Load(); break;
        }
    }
}