using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HomeStayManagement.Data;
using HomeStayManagement.Model;

namespace HomeStayManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomestaysController : ControllerBase
    {
        private readonly HomeStayContext _context;

        public HomestaysController(HomeStayContext context)
        {
            _context = context;
        }

        // GET: api/Homestays
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Homestay>>> GetHomestay()
        {
          if (_context.Homestay == null)
          {
              return NotFound();
          }
            return await _context.Homestay.ToListAsync();
        }

        // GET: api/Homestays/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Homestay>> GetHomestay(int id)
        {
          if (_context.Homestay == null)
          {
              return NotFound();
          }
            var homestay = await _context.Homestay.FindAsync(id);

            if (homestay == null)
            {
                return NotFound();
            }

            return homestay;
        }

        // PUT: api/Homestays/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHomestay(int id, Homestay homestay)
        {
            if (id != homestay.id)
            {
                return BadRequest();
            }

            _context.Entry(homestay).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HomestayExists(id))
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

        // POST: api/Homestays
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Homestay>> PostHomestay(Homestay homestay)
        {
          if (_context.Homestay == null)
          {
              return Problem("Entity set 'HomeStayContext.Homestay'  is null.");
          }
            _context.Homestay.Add(homestay);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHomestay", new { id = homestay.id }, homestay);
        }

        // DELETE: api/Homestays/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHomestay(int id)
        {
            if (_context.Homestay == null)
            {
                return NotFound();
            }
            var homestay = await _context.Homestay.FindAsync(id);
            if (homestay == null)
            {
                return NotFound();
            }

            _context.Homestay.Remove(homestay);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HomestayExists(int id)
        {
            return (_context.Homestay?.Any(e => e.id == id)).GetValueOrDefault();
        }
    }
}
