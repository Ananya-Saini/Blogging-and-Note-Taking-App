using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace backend.Models;

public class ApplicationUser : IdentityUser
{
    [MaxLength(50)]
    public string? DisplayName { get; set; }
    public DateTime? CreatedAt { get; set;} = DateTime.UtcNow;

    public List<Posts> Posts { get; set;} = new List<Posts>();
    public List<Comments> Comments { get; set;} = new List<Comments>();
}