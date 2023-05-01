using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PersonaCalendar.Data;
using PersonaCalendar.Models;

namespace PersonaCalendar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserEventsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public UserEventsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/UserEvents
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserEvents>>> GetUserEvents()
        {
          if (_context.UserEvents == null)
          {
              return NotFound();
          }
            return await _context.UserEvents.ToListAsync();
        }

        // GET: api/UserEvents/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UserEvents>> GetUserEvents(int id)
        {
          if (_context.UserEvents == null)
          {
              return NotFound();
          }
            var userEvents = await _context.UserEvents.FindAsync(id);

            if (userEvents == null)
            {
                return NotFound();
            }

            return userEvents;
        }

        // PUT: api/UserEvents/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserEvents(int id, UserEvents userEvents)
        {
            if (id != userEvents.UsereventsId)
            {
                return BadRequest();
            }

            _context.Entry(userEvents).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserEventsExists(id))
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

        // POST: api/UserEvents
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<UserEvents>> PostUserEvents(UserEvents userEvents)
        {
          if (_context.UserEvents == null)
          {
              return Problem("Entity set 'ApplicationDbContext.UserEvents'  is null.");
          }
            _context.UserEvents.Add(userEvents);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUserEvents", new { id = userEvents.UsereventsId }, userEvents);
        }

        // DELETE: api/UserEvents/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserEvents(int id)
        {
            if (_context.UserEvents == null)
            {
                return NotFound();
            }
            var userEvents = await _context.UserEvents.FindAsync(id);
            if (userEvents == null)
            {
                return NotFound();
            }

            _context.UserEvents.Remove(userEvents);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UserEventsExists(int id)
        {
            return (_context.UserEvents?.Any(e => e.UsereventsId == id)).GetValueOrDefault();
        }
    }
}
