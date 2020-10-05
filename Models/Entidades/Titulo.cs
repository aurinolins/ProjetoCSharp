using System;
using System.ComponentModel.DataAnnotations;
namespace app02.Models.Entidades
{
    public class Titulo
    {
        [Key]
        public int Id { get; set; }
        public int Numero { get; set; }
        public decimal Valor { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Emissao { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Vencimento { get; set; }
        public Cliente Cliente { get; set; }
        public int ClienteId { get; set; }
        public int Status { get; set; }


        public Titulo()
        {
        }

        public Titulo(int id, int numero, decimal valor, DateTime vencimento, Cliente cliente)
        {
            this.Id = id;
            this.Cliente = cliente;
            this.Numero = numero;
            this.Valor = valor;
            this.Emissao = DateTime.Today;
            this.Vencimento = vencimento;
            this.Status = 1;
        }
    }

}
