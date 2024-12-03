using System.Threading.Tasks;
using System.Threading;
using Microsoft.EntityFrameworkCore;
using.Domain;

namespace Notes.Application.Interfaces
{
    internal interface INotesDbContext
    {
        DbSet<Notes> Notes { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);

    }
}
