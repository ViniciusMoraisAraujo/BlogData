using BlogData.Models;
using BlogData.Repositories;

namespace BlogData.Screens.CategoryScreens;

public class DeleteCategoryScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Loading.....");
        Console.WriteLine("Delete a category");
        Console.Write("Enter the id of the category: ");
        int categoryId = int.Parse(Console.ReadLine());
        var newCategory = new Category(categoryId);
        Delete(newCategory);
        Console.ReadKey();
        MenuCategoryScreen.Load();
    }

    public static void Delete(Category category)
    {
        var repositories = new Repository<Category>(Database.Connection);
        repositories.Delete(category);
        Console.WriteLine("Category deleted");
    }
}