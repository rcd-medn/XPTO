





using System;
using System.Collections.Generic;
using System.Linq;
using XPTO.Models;

namespace XPTO.Data
{
    public class ClienteRepository : IClienteAPIRepository
    {
        private readonly XPTOContext _context;

        public ClienteRepository(XPTOContext context)
        {
            _context = context;
        }
        
        public void CreateCliente(Cliente cliente)
        {
            if (cliente == null)
            {
                throw new ArgumentNullException(nameof(cliente));
            }

            _context.Clientes.Add(cliente);
        }

        public void DeleteCliente(Cliente cliente)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Cliente> GetAllClientes()
        {
            var clientes = _context.Clientes.ToList();
            return clientes;
        }

        public Cliente GetClienteById(int id)
        {
            return _context.Clientes.FirstOrDefault(p => p.ClienteId == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateCliente(Cliente cliente)
        {
            throw new System.NotImplementedException();
        }
    }
}
