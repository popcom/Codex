using Domain.Entities;

namespace Application.Interfaces;

public interface IItemRepository
{
    Task<Item> AddAsync(Item item, CancellationToken cancellationToken = default);
    Task<IEnumerable<Item>> GetAllAsync(CancellationToken cancellationToken = default);
}
