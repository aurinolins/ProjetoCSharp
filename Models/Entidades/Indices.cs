using System;
using System.ComponentModel.DataAnnotations;
namespace app02.Models.Entidades
{
    public class Indices 
    {
        [Key]
        public  int       Id      { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public  DateTime  Periodo { get; set; }
        [Required]
        public  double    Juros   { get; set; }
        [Required]
        public  double    Multa   { get; set; }

        public Indices()
        {
        }

        public Indices(DateTime periodo, int juros, int multa)
        {
            Periodo = periodo;
            Juros = juros;
            Multa = multa;
        }
    }
}
