
using MongoDB.Bson;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MongoDB_Net.Application.DTOs
{
    public class InfectadoDTO
    {
        [Required(ErrorMessage = "The Cpf is Required")]
        [MinLength(11)]
        [MaxLength(11)]
        [DisplayName("Cpf")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "The Nome is Required")]
        [MinLength(3)]
        [MaxLength(100)]
        [DisplayName("Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "The Telefone is Required")]
        [MinLength(9)]
        [MaxLength(11)]
        [DisplayName("Telefone")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "The Estado is Required")]
        [MinLength(2)]
        [MaxLength(2)]
        [DisplayName("Estado")]
        public string Estado { get; set; }
    }
}
