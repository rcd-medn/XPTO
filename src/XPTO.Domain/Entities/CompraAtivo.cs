





using System;

namespace XPTO.Domain.Entities
{
    public class CompraAtivo
    {
        public int CompraAtivoId { get; set; }
        public DateTime DataCompra { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }

        public int AtivoId { get; set; }
        public Ativo Ativo { get; set; }
    }
}
