using System.ComponentModel.DataAnnotations;
namespace app02.Models.Entidades
{
    public class SignUpUser
    {
        [Key]
        public int Id { get; set; }
        [Required,  EmailAddress(ErrorMessage = "email Inválido")]
        public string Email { get; set;}
        [Required,  DataType(DataType.Password)]
        public string Password { get; set; }
        [Required,  DataType(DataType.Password)]
        public string PasswordConfirm { get; set;}
    }
}
