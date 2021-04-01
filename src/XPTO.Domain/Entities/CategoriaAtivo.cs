





using System;
using System.Collections.Generic;

namespace XPTO.Domain.Entities
{
    public class CategoriaAtivo
    {
        public int CategoriaAtivoId { get; set; }
        public string Nome { get; set; }
        public DateTime DataCriacao { get; set; }

        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        public ICollection<Ativo> Ativos { get; set; }
    }
}
