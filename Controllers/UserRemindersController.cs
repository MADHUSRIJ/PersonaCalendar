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
    public class UserRemindersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public UserRemindersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/UserReminders
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserReminders>>> GetUserReminders()
        {
          if (_context.UserReminders == null)
          {
              return NotFound();
          }
            return await _context.UserReminders.ToListAsync();
        }

        // GET: api/UserReminders/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UserReminders>> GetUserReminders(int id)
        {
          if (_context.UserReminders == null)
          {
              return NotFound();
          }
            var userReminders = await _context.UserReminders.FindAsync(id);

            if (userReminders == null)
            {
                return NotFound();
            }

            return userReminders;
        }

        // PUT: api/UserReminders/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserReminders(int id, UserReminders userReminders)
        {
            if (id != userReminders.UserReminderId)
            {
                return BadRequest();
            }

            _context.Entry(userReminders).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserRemindersExists(id))
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

        // POST: api/UserReminders
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<UserReminders>> PostUserReminders(UserReminders userReminders)
        {
          if (_context.UserReminders == null)
          {
              return Problem("Entity set 'ApplicationDbContext.UserReminders'  is null.");
          }
            _context.UserReminders.Add(userReminders);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUserReminders", new { id = userReminders.UserReminderId }, userReminders);
        }

        // DELETE: api/UserReminders/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserReminders(int id)
        {
            if (_context.UserReminders == null)
            {
                return NotFound();
            }
            var userReminders = await _context.UserReminders.FindAsync(id);
            if (userReminders == null)
            {
                return NotFound();
            }

            _context.UserReminders.Remove(userReminders);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UserRemindersExists(int id)
        {
            return (_context.UserReminders?.Any(e => e.UserReminderId == id)).GetValueOrDefault();
        }
    }
}
