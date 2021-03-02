





using System.Collections.Generic;
using XPTO.Models;

namespace XPTO.Data
{
    public interface IClienteAPIRepository
    {
        IEnumerable<Cliente> GetAllClientes();
        Cliente GetClienteById(int id);
        void CreateCliente(Cliente cliente);
        void UpdateCliente(Cliente cliente);
        void DeleteCliente(Cliente cliente);

        bool SaveChanges();
    }
}
