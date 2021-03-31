





using System;
using System.ComponentModel.DataAnnotations;

namespace XPTO.Domain.Entities
{
    /// <summary>
    /// Classe para modelar a tabela "Usuarios" no banco de dados XPTO
    /// </summary>
    public class Usuario
    {
        [Key]
        [Required]
        public int UsuarioId { get; set; }

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

        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }
    }
}
