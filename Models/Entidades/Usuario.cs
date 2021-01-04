using System.ComponentModel.DataAnnotations;

namespace app02.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Sobrenome { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public int Fone { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        public string Passwordconfirme { get; set; }
       
        public Usuario()
        {
        }

        public Usuario(string   nome,string  sobrenome,string email,int fone,string password,string passwordconfirme)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Email = email;
            Fone = fone;
            Password = password;
            Passwordconfirme = passwordconfirme;
        }
        public bool   Validapassword(string password, string passwordconfirme)
        {
            if (passwordconfirme != password)
            {
                return false;
            }
            else
            {
              return true;
            }
        }
    }
}
