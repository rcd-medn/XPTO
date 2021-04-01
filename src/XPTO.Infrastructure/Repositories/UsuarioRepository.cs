





using System;
using System.Collections.Generic;
using System.Linq;
using XPTO.Domain.Entities;
using XPTO.Domain.Repositories;

namespace XPTO.Infrastructure.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly XPTOContext _context;
        public IUnitOfWork UnitOfWork => _context;

        public UsuarioRepository(XPTOContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void CreateUsuario(Usuario usuario)
        {
            if (usuario == null)
            {
                throw new ArgumentNullException(nameof(usuario));
            }

            _context.Usuarios.Add(usuario);
        }

        public void DeleteUsuario(Usuario usuario)
        {
            if (usuario == null)
            {
                throw new ArgumentNullException(nameof(usuario));
            }

            _context.Usuarios.Remove(usuario);
        }

        public IEnumerable<Usuario> GetAllUsuarios()
        {
            var usuarios = _context.Usuarios.ToList();
            return usuarios;
        }

        public Usuario GetUsuarioById(int id)
        {
            return _context.Usuarios.FirstOrDefault(p => p.UsuarioId == id);
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
