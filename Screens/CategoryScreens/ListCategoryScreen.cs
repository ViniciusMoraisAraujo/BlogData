using BlogData.Models;
using BlogData.Repositories;

namespace BlogData.Screens.CategoryScreens;

public class ListCategoryScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Loading.....");
        ListCategory();
        Console.ReadKey();
        MenuCategoryScreen.Load();
        
    }

    public static void ListCategory()
    {
        var repository = new Repository<Category>(Database.Connection);
        var listCategories = repository.Get();
        foreach (var category in listCategories)
        {
            Console.WriteLine($"Id:{category.Id} - Name: {category.Name} - Slug: ({category.Slug}) ");
        }
    }
}