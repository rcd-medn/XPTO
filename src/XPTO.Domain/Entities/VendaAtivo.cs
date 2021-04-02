





using System;

namespace XPTO.Domain.Entities
{
    public class VendaAtivo
    {
        public int VendaAtivoId { get; set; }
        public DateTime DataVenda { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }

        public int AtivoId { get; set; }
        public Ativo Ativo { get; set; }
    }
}
