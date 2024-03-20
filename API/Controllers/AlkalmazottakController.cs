using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Data;
using ClassLibrary.Models;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlkalmazottakController : ControllerBase
    {
        private readonly APIContext _context;

        public AlkalmazottakController(APIContext context)
        {
            _context = context;
        }

        // GET: api/Alkalmazottak
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Alkalmazott>>> GetAlkalmazott()
        {
          if (_context.Alkalmazott == null)
          {
              return NotFound();
          }
            return await _context.Alkalmazott.ToListAsync();
        }

        // GET: api/Alkalmazottak/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Alkalmazott>> GetAlkalmazott(int id)
        {
          if (_context.Alkalmazott == null)
          {
              return NotFound();
          }
            var alkalmazott = await _context.Alkalmazott.FindAsync(id);

            if (alkalmazott == null)
            {
                return NotFound();
            }

            return alkalmazott;
        }

        // PUT: api/Alkalmazottak/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAlkalmazott(int id, Alkalmazott alkalmazott)
        {
            if (id != alkalmazott.Id)
            {
                return BadRequest();
            }

            _context.Entry(alkalmazott).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AlkalmazottExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Alkalmazottak
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Alkalmazott>> PostAlkalmazott(Alkalmazott alkalmazott)
        {
          if (_context.Alkalmazott == null)
          {
              return Problem("Entity set 'APIContext.Alkalmazott'  is null.");
          }
            _context.Alkalmazott.Add(alkalmazott);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (AlkalmazottExists(alkalmazott.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetAlkalmazott", new { id = alkalmazott.Id }, alkalmazott);
        }

        // DELETE: api/Alkalmazottak/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAlkalmazott(int id)
        {
            if (_context.Alkalmazott == null)
            {
                return NotFound();
            }
            var alkalmazott = await _context.Alkalmazott.FindAsync(id);
            if (alkalmazott == null)
            {
                return NotFound();
            }

            _context.Alkalmazott.Remove(alkalmazott);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AlkalmazottExists(int id)
        {
            return (_context.Alkalmazott?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
