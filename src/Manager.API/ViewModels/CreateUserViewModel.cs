using System.ComponentModel.DataAnnotations;

namespace Manager.API.ViewModels
{
    public class CreateUserViewModel
    {
        //Validação da API
        [Required(ErrorMessage = "O nome não pode ser nulo VM.")]
        [MinLength(3, ErrorMessage = "O nome deve ter no mínimo 3 caracteres VM.")]
        [MaxLength(80, ErrorMessage = "O nome deve ter no máximo 80 caracteres VM.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "O email não pode ser vazio VM.")]
        [MinLength(10, ErrorMessage = "O email deve ter no mínimo 10 caracteres VM.")]
        [MaxLength(180, ErrorMessage = "O email deve ter no máximo 180 caracteres VM.")]
        [RegularExpression(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", 
            ErrorMessage = "O email informado não é válido VM.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "A senha não pode ser vazia VM.")]
        [MinLength(10, ErrorMessage = "A senha deve ter no mínimo 6 caracteres VM.")]
        [MaxLength(100, ErrorMessage = "A senha deve ter no máximo 30 caracteres VM.")]
        public string Password { get; set; }
    }
}
