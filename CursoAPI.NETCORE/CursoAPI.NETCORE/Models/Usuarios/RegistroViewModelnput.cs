using System.ComponentModel.DataAnnotations;

namespace CursoAPI.NETCORE.Models.Usuarios
{
    public class RegistroViewModelnput
    {
        [Required(ErrorMessage = "O Login é Obrigatório")]
        public string Login { get; set; }

        [Required(ErrorMessage = "O Email é Obrigatório")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O Senha é Obrigatório")]
        public string Senha { get; set; }
    }
}
