





using System.Collections.Generic;

namespace XPTO.Domain.Entities
{
    public class Ativo
    {
        public int AtivoId { get; set; }
        public string Ticker { get; set; }
        
        public int CategoriaAtivoId { get; set; }
        public CategoriaAtivo CategoriaAtivo { get; set; }

        public ICollection<CompraAtivo> CompraAtivos { get; set; }
        public ICollection<VendaAtivo> VendaAtivos { get; set; }
    }
}
