using System.ComponentModel.DataAnnotations;

namespace SocialBots.Models;

public class User
{
    [Key]
    [Required]
    public int Id { get; set; }
    [Required(ErrorMessage = "O Nome de usuário é obrigatório")]
    public string Name { get; set; }    
    public string Nickname { get; set; }
    [Required(ErrorMessage = "O Trabalho do usuário é obrigatório")]
    public string Job { get; set; }

}
