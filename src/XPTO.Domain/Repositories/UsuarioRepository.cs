





using System;
using System.Collections.Generic;
using System.Linq;
using XPTO.Domain.Entities;

namespace XPTO.Domain.Repositories
{
    public class UsuarioRepository
    {
        private readonly XPTOContext _context;

        public UsuarioRepository(XPTOContext context)
        {
            _context = context;
        }

        public void CreateUsuario(Usuario usuario)
        {
            if (usuario == null)
            {
                throw new ArgumentNullException(nameof(usuario));
            }

            _context.Clientes.Add(usuario);
        }

        public void DeleteUsuario(Usuario usuario)
        {
            if (usuario == null)
            {
                throw new ArgumentNullException(nameof(usuario));
            }

            _context.Clientes.Remove(usuario);
        }

        public IEnumerable<Usuario> GetAllUsuarios()
        {
            var usuarios = _context.Clientes.ToList();
            return usuarios;
        }

        public Usuario GetUsuarioById(int id)
        {
            return _context.Clientes.FirstOrDefault(p => p.ClienteId == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateUsuario(Usuario usuario)
        {
            //throw new System.NotImplementedException();
        }
    }
}
