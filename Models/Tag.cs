using Dapper.Contrib.Extensions;
namespace BlogData.Models;

[Table("[Tag]")]
public class Tag
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Slug { get; set; }

    public Tag(string name, string slug)
    {
        Name = name;
        Slug = slug;
    }

    public Tag(int id, string name, string slug)
    {
        Id = id;
        Name = name;
        Slug = slug;
    }

    public Tag(int id)
    {
        Id = id;
    }
}