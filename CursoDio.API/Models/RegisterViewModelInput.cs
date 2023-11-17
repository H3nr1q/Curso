using System.ComponentModel.DataAnnotations;

namespace CursoDio.API.Models
{
    public class RegisterViewModelInput
    {
        [Required(ErrorMessage = "O login é obrigatório")]
        public string login { get; set; }
        [Required(ErrorMessage = "O e-mail é obrigatório")]
        public string email { get; set; }
        [Required(ErrorMessage = "A senha é obrigatória")]
        public string oassword { get; set; }
    }
}
