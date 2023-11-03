using System.ComponentModel.DataAnnotations;

namespace SocialBots.Data.DTOs
{
    public class CreateUserDTO
    {
        [Required(ErrorMessage = "O Nome de usuário é obrigatório")]
        public string Name { get; set; }
        public string Nickname { get; set; }
        [Required(ErrorMessage = "O Trabalho do usuário é obrigatório")]
        public string Job { get; set; }
    }
}
