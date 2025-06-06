﻿namespace BlogData.Screens.CategoryScreens;

public class MenuCategoryScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Menu Tag Screen");
        Console.WriteLine("---------------");
        Console.WriteLine();
        Console.WriteLine("Select an option:");
        Console.WriteLine("1. List a category");
        Console.WriteLine("2. New category");
        Console.WriteLine("3. Edit category");
        Console.WriteLine("4. Delete category");
        Console.WriteLine();
        var option = int.Parse(Console.ReadLine()!);

        switch (option)
        {
            case 1:
                ListCategoryScreen.Load();
                break;
            case 2:
                CreateCategoryScreen.Load();
                break;
            case 3:
                UpdateCategoryScreen.Load();
                break;
            case 4:
                DeleteCategoryScreen.Load();
                break;
            default: Load(); break;
        }
    }
}