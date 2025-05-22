using BlogData.Models;
using BlogData.Repositories;

namespace BlogData.Screens.CategoryScreens;

public class UpdateCategoryScreen
{
    public static void Load(){Console.Clear();
        Console.WriteLine("Loading.....");
        Console.WriteLine("Update a category");
        Console.Write("Enter the id of the category: ");
        int categoryId = int.Parse(Console.ReadLine());
        Console.Write("Enter the name of the category: ");
        string categoryName = Console.ReadLine();
        Console.Write("Enter the slug of the category: ");
        string slug = Console.ReadLine();
        var newCategory = new Category(categoryId, categoryName, slug);
        Update(newCategory);
        Console.ReadKey();
        MenuCategoryScreen.Load();
    }

    public static void Update(Category category)
    {
        var repositories = new Repository<Category>(Database.Connection);
        repositories.Update(category);
        Console.WriteLine("Updated category");
    }
}
