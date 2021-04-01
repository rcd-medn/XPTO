





using System;
using System.Collections.Generic;

namespace XPTO.Domain.Entities
{
    /// <summary>
    /// Classe para modelar a tabela "Usuarios" no banco de dados XPTO
    /// </summary>
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string Nome { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }

        public ICollection<CategoriaAtivo> CategoriaAtivos { get; set; }
    }
}
