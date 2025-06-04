using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Interfaces;

public interface IApplicationDbContext
{
    DbSet<Item> Items { get; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
