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
        public string email { get; set; }
        public ICollection<Titulo> Titulos {get; set; }

        public Cliente()
        {
        }

        public Cliente(int id, string nome, string email)
        {
            this.Id = id;
            this.Nome = nome;
            this.email = email;
        }
    }

}
