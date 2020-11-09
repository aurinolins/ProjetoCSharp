using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace app02.Models.Entidades
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.PhoneNumber)]
        public int Telefone { get; set; }
        public ICollection<Titulo> Titulos { get; set; } = new List<Titulo>();

        public Cliente()
        {
        }

        public Cliente(int id, string nome, string Email, int telefone)
        {
            this.Id = id;
            this.Nome = nome;
            this.Email = Email;
            this.Telefone = telefone;
        }
    }

}
