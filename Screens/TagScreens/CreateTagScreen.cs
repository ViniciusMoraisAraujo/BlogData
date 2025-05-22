using BlogData.Models;
using BlogData.Repositories;

namespace BlogData.Screens.TagScreens;

public class CreateTagScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Create new tag");
        Console.Write("Name: ");
        string tagName = Console.ReadLine();
        Console.Write("Slug: ");
        string tagSlug = Console.ReadLine();
        Console.WriteLine();
        var newTag = new Tag(tagName, tagSlug);
        Create(newTag);
        MenuTagScreen.Load();
    }

    public static void Create(Tag tag)
    {
        try
        {
            var repository = new Repository<Tag>(Database.Connection);
            repository.Create(tag);
            Console.WriteLine("Insert a tag!");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}