using Application.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ItemsController(IItemRepository repository) : ControllerBase
{
    [HttpGet]
    public async Task<IEnumerable<Item>> Get(CancellationToken cancellationToken)
        => await repository.GetAllAsync(cancellationToken);

    [HttpPost]
    public async Task<ActionResult<Item>> Post(Item item, CancellationToken cancellationToken)
    {
        var created = await repository.AddAsync(item, cancellationToken);
        return CreatedAtAction(nameof(Get), new { id = created.Id }, created);
    }
}
