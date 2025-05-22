using Dapper.Contrib.Extensions;

namespace BlogData.Models;
[Table("[Category]")]
public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Slug { get; set; }

    public Category(int id, string name, string slug)
    {
        Id = id;
        Name = name;
        Slug = slug;
    }

    public Category(string name, string slug)
    {
        Name = name;
        Slug = slug;
    }

    public Category(int id)
    {
        Id = id;
    }
}