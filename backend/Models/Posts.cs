using System.ComponentModel.DataAnnotations;
namespace backend.Models.Posts;

public class Posts
{
    public int Id { get; set; }
    [Required, MaxLength(200)]
    public string Title { get; set; }
}