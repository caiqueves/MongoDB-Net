using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MongoDB_Net.Application.DTOs
{
    public class InfectadoDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The Name is Required")]
        [MinLength(3)]
        [MaxLength(100)]
        [DisplayName("Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The Telefone is Required")]
        [MinLength(9)]
        [MaxLength(11)]
        [DisplayName("Telefone")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "The Telefone is Required")]
        [MinLength(2)]
        [MaxLength(2)]
        [DisplayName("Estado")]
        public string Estado { get; set; }

        public InfectadoDTO(int id, string name, string telefone, string estado)
        {
            Id = id;
            Name = name;
            Telefone = telefone;
            Estado = estado;
        }
    }
}
