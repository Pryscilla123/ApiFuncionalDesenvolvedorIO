using System.ComponentModel.DataAnnotations;

namespace ApiFuncional.Models
{
    public class LoginUserViewModel
    {
        [EmailAddress(ErrorMessage = "O campo {0} é obrigatório.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres.")]
        public string Password { get; set; }
    }
}
