using BlogData.Models;
using BlogData.Repositories;

namespace BlogData.Screens.TagScreens;

public class DeleteTagScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Delete a tag");
        Console.Write("Id: ");
        int tagId = int.Parse(Console.ReadLine());

        var deleteTag = new Tag(tagId);
        Delete(deleteTag);
        MenuTagScreen.Load();
    }

    public static void Delete(Tag tag)
    {
        try
        {
            var repository = new Repository<Tag>(Database.Connection);
            repository.Delete(tag);
            Console.WriteLine("Tag delete");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }
}
