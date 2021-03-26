





using System.Collections.Generic;
using XPTO.Models;

namespace XPTO.Domain.Repositories
{
    public interface IUsuarioAPIRepository
    {
        IEnumerable<Usuario> GetAllUsuarios();
        Usuario GetUsuarioById(int usuarioId);
        void CreateUsuario(Cliente usuario);
        void UpdateUsuario(usuario usuario);
        void DeleteUsuario(usuario usuario);

        bool SaveChanges();
    }
}
