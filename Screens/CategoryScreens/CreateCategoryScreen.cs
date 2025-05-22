using BlogData.Models;
using BlogData.Repositories;

namespace BlogData.Screens.CategoryScreens;

public class CreateCategoryScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Loading.....");
        Console.WriteLine("Creating new category");
        Console.Write("Enter the name of the category: ");
        string categoryName = Console.ReadLine();
        Console.Write("Enthe the slug of the category: ");
        string categorySlug = Console.ReadLine();
        var newCategory = new Category(categoryName, categorySlug);
        Create(newCategory);
        Console.ReadKey();
        MenuCategoryScreen.Load();
    }

    public static void Create(Category category)
    {
        try
        {
            var repository = new Repository<Category>(Database.Connection);
            repository.Create(category);
            Console.WriteLine("Category created");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

}