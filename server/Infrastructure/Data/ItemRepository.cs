using Application.Interfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class ItemRepository(ApplicationDbContext context) : IItemRepository
{
    private readonly ApplicationDbContext _context = context;

    public async Task<Item> AddAsync(Item item, CancellationToken cancellationToken = default)
    {
        _context.Items.Add(item);
        await _context.SaveChangesAsync(cancellationToken);
        return item;
    }

    public async Task<IEnumerable<Item>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        return await _context.Items.AsNoTracking().ToListAsync(cancellationToken);
    }
}
