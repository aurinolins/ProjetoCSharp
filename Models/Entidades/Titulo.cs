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
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double Valor { get; set; }
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double Multa { get; set; }
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double Juros { get; set; }
        [DisplayFormat(DataFormatString = "{0:F2}")]
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
            this.Emissao = Emissao;
            this.Vencimento = vencimento;
            this.Pagamento = DateTime.Parse("00/00/0000");
            this.Multa = 0;
            this.Juros = 0;
            this.Totalpago = 0;
            this.Status = 1;
        }
    }

}
