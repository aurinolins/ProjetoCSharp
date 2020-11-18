using System.ComponentModel.DataAnnotations;

namespace app02.Models
{
    public class Usuario
    {
        [Key]
        public int  Id { get; set; }
        [Required]
        public string  Nome { get; set; }
        [Required]
        public string  Sobrenome { get; set; }
        [Required,EmailAddress]
        public string Email    { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public int    Fone     { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
