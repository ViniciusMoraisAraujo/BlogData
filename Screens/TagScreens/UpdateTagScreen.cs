using BlogData.Models;
using BlogData.Repositories;

namespace BlogData.Screens.TagScreens;

public class UpdateTagScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Att a tag");
        Console.Write("Id: ");
        int tagId = int.Parse(Console.ReadLine());
        Console.Write("Name: ");
        string tagName = Console.ReadLine();
        Console.Write("Slug: ");
        string tagSlug = Console.ReadLine();
        Console.WriteLine();
        var newTag = new Tag(tagId, tagName, tagSlug);
        Update(newTag);
        MenuTagScreen.Load();
    }
    public static void Update(Tag tag)
    {
        try
        {
            var repository = new Repository<Tag>(Database.Connection);
            repository.Update(tag);
            Console.WriteLine("Tag updated");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }
}