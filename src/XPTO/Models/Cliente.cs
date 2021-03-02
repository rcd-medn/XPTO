





using System.ComponentModel.DataAnnotations;

namespace XPTO.Models
{
    /// <summary>
    /// Classe para modelar a tabela "Clientes" no banco de dados XPTO
    /// </summary>
    public class Cliente
    {
        [Key]
        [Required]
        public int ClienteId { get; set; }

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
