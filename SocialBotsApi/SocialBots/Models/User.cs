using System.ComponentModel.DataAnnotations;

namespace SocialBots.Models;

public class User
{
    [Required]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Nickname { get; set; }
    [Required]
    public string Job { get; set; }
}
