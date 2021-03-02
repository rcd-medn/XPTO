





using System.Collections.Generic;
using XPTO.Models;

namespace XPTO.Data
{
    public class MockClienteAPIRepository : IClienteAPIRepository
    {
        public void CreateCliente(Cliente cliente)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCliente(Cliente cliente)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Cliente> GetAllClientes()
        {
            var clientes = new List<Cliente>
            {
                new Cliente() { ClienteId = 1, Nome = "Fulano de Tal", RG = "4521111-4", CPF = "111.222.333-44" },
                new Cliente() { ClienteId = 2, Nome = "Sicrano de Tal", RG = "4158887-1", CPF = "555.666.777-88" },
                new Cliente() { ClienteId = 3, Nome = "Joe Simpson", RG = "787874-X", CPF = "999.000.111-22" }
            };

            return clientes;
        }

        public Cliente GetClienteById(int id)
        {
            return new Cliente() { ClienteId = 1050, Nome = "Get Cliente By Id", RG = "87875454", CPF = "000.555.666-44" };
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCliente(Cliente cliente)
        {
            throw new System.NotImplementedException();
        }
    }
}
