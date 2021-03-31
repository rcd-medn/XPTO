




using System;
using System.Threading;
using System.Threading.Tasks;

namespace XPTO.Domain.Repositories
{
    /// <summary>
    /// Interface com métodos para atender ao padrão Unit Of Work.
    /// </summary>
    public interface IUnitOfWork : IDisposable
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
        Task<bool> SaveEntitiesAsync(CancellationToken cancellationToken = default(CancellationToken));
    }
}
