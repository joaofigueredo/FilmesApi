using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models
{
    public class Endereco
    {
        [Key]
        [Required]
        public int Id { get; set; }
        //[Required(ErrorMessage = "Logradouro é um campo obrigatório!")]
        //[StringLength(50, ErrorMessage = "Máximo de logradouro é 50!")]
        public string Logradouro { get; set; }
        //[Required(ErrorMessage = "Número é um campo obrigatório!")]
        public int Numero { get; set; }
        public virtual Cinema Cinema { get; set; }
    }
}