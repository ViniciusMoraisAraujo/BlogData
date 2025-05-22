using Dapper.Contrib.Extensions;

namespace BlogData.Models;

[Table("[User]")]
public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; }
    public string Bio { get; set; }
    public string Image { get; set; }
    public string Slug { get; set; }
    
    [Write(false)]
    public List<Role> Roles { get; set; }

    public User()
    {
        Roles = new List<Role>();
    }

    public User( int id, string name, string email, string passwordHash, string bio, string image, string slug)
    {
        Id = id;
        Name = name;
        Email = email;
        PasswordHash = passwordHash;
        Bio = bio;
        Image = image;
        Slug = slug;
    }
    public User(string name, string email, string passwordHash, string bio, string image, string slug)
    {
        Name = name;
        Email = email;
        Bio = bio;
        PasswordHash = passwordHash;
        Image = image;
        Slug = slug;
    }
    public User(int id, string name, string email, string bio, string slug)
    {
        Id = id;
        Name = name;
        Email = email;
        Bio = bio;
        Slug = slug;
    }

    public User(int id)
    {
        Id = id;
    }
}