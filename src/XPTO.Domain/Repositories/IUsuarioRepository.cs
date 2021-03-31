





using System.Collections.Generic;
using XPTO.Domain.Entities;

namespace XPTO.Domain.Repositories
{
    public interface IUsuarioRepository : IRepository
    {
        IEnumerable<Usuario> GetAllUsuarios();
        Usuario GetUsuarioById(int usuarioId);
        
        void CreateUsuario(Usuario usuario);
        void UpdateUsuario(Usuario usuario);
        void DeleteUsuario(Usuario usuario);

        bool SaveChanges();
    }
}
