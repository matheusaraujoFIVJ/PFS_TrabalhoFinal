using JudoAPI.Data;
using JudoAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/[controller]")]
public abstract class BaseController<T> : ControllerBase where T : class
{
    private readonly JudoContext _context;
    private JudoContext context;

    protected BaseController(JudoContext context)
    {
        _context = context;
    }

    protected BaseController(JudoContext context)
    {
        this.context = context;
    }

    // GET: api/[controller]
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var items = await _context.Set<T>().ToListAsync();
        return Ok(items);
    }

    // GET: api/[controller]/{id}
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var item = await _context.Set<T>().FindAsync(id);
        if (item == null)
            return NotFound();

        return Ok(item);
    }

    // POST: api/[controller]
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] T item)
    {
        _context.Set<T>().Add(item);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetById), new { id = ((dynamic)item).Id }, item);
    }

    // PUT: api/[controller]/{id}
    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, [FromBody] T item)
    {
        if (id != ((dynamic)item).Id)
            return BadRequest();

        _context.Entry(item).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!await ItemExists(id))
                return NotFound();
            throw;
        }

        return NoContent();
    }

    // DELETE: api/[controller]/{id}
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var item = await _context.Set<T>().FindAsync(id);
        if (item == null)
            return NotFound();

        _context.Set<T>().Remove(item);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private async Task<bool> ItemExists(int id)
    {
        return await _context.Set<T>().AnyAsync(e => ((dynamic)e).Id == id);
    }
}
