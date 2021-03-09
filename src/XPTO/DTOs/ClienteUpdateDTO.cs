





using System.ComponentModel.DataAnnotations;

namespace XPTO.DTOs
{
    public class ClienteUpdateDTO
    {
        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }

        [Required]
        [MaxLength(25)]
        public string RG { get; set; }

        [Required]
        [MaxLength(11)]
        public string CPF { get; set; }

        [Required]
        [MaxLength(80)]
        [EmailAddress]
        public string Email { get; set; }
    }
}
