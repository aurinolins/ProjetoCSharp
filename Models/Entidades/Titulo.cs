using System;
using System.ComponentModel.DataAnnotations;
namespace app02.Models.Entidades
{
    public class Titulo
    {
        [Key]
        public int Id { get; set; }
        public int Documento { get; set; }
        public Cliente Cliente { get; set; }
        public int ClienteId { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Emissao { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Vencimento { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Pagamento { get; set; }
        public double Valor { get; set; }
        public double Multa { get; set; }
        public double Juros { get; set; }
        public double Totalpago { get; set; }
        public int Status   { get; set; }


        public Titulo()
        {
        }

        public Titulo(int documento, Cliente cliente,DateTime Emissao, DateTime vencimento, double valor)
        {
            this.Cliente = cliente;
            this.Documento = documento;
            this.Valor = valor;
            this.Vencimento = vencimento;
            this.Multa = 0;
            this.Juros = 0;
            this.Totalpago = 0;
            this.Status = 1;
        }
    }

}
