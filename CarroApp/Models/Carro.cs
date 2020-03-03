using System;
using System.ComponentModel.DataAnnotations;
namespace CarroApp.Models
{
    public class Carro
    { 
        public int Id { get; set; }

        [Required(ErrorMessage ="O campo NomeDoCarro deve ser preenchido!")]
        [StringLength(60, MinimumLength =2)]
        public string NomeDoCarro { get; set; }

        [Required(ErrorMessage ="Genero deve ser selecionado!")]     
        public Genre Genre { get; set; }

        [Required(ErrorMessage = "Somente quatro numeros sao aceitos, o ano deve ser semelhante a: XXXX")]
        public int Ano { get; set; }

        [Required(ErrorMessage ="O campo Preço tem que ser preenchido!")]
        //Adicionado o Real ao valor
        [DisplayFormat(DataFormatString ="{0:C}")]
        public double Preco { get; set; }
    }
}
