using BlogData.Models;
using BlogData.Repositories;

namespace BlogData.Screens.TagScreens;

public class ListTagScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Loading Tag Screen");
        Console.WriteLine("--------------");
        List();
        Console.ReadKey();
    }

    private static void List()
    {
        var repository = new Repository<Tag>(Database.Connection);
        var listTags = repository.Get();
        foreach (var item in listTags)
        {
            Console.WriteLine($"Id:{item.Id} - Name: {item.Name} - Slug: ({item.Slug}) ");
        }
    }
}