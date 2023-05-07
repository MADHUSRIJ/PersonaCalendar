using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Text.Json;
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
    public class UsersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public UsersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Users
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Users>>> GetUsers()
        {
          if (_context.Users == null)
          {
              return NotFound();
          }
            return await _context.Users
                .ToListAsync();
        }

        // GET: api/Users/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Users>> GetUsers(int id)
        {
          if (_context.Users == null)
          {
              return NotFound();
          }
            

            var users = await _context.Users
                .FirstOrDefaultAsync(e => e.UserId == id);

            if (users == null)
            {
                return NotFound();
            }

            return users;
        }

        // GET: api/Users/5/notes

        [HttpGet("{id}/notes")]
        public async Task<ActionResult<IEnumerable<Notes>>> GetUserNotes(int id)
        {
            var notes = await _context.Notes
                .Where(e => e.UserId == id)
                .ToListAsync();

            if (notes == null)
            {
                return NotFound();
            }

            return notes;
        }


        // GET: api/Users/5/events

        [HttpGet("{id}/events")]
        public async Task<ActionResult<IEnumerable<Events>>> GetUserEvents(int id)
        {
            var events = await _context.Events
                .Where(e => e.UserId == id)
                .ToListAsync();

            if (events == null)
            {
                return NotFound();
            }

            return events;
        }

        // GET: api/Users/5/tasks

        [HttpGet("{id}/tasks")]
        public async Task<ActionResult<IEnumerable<Tasks>>> GetUserTasks(int id)
        {
            var tasks = await _context.Tasks
                .Where(e => e.UserId == id)
                .ToListAsync();

            if (tasks == null)
            {
                return NotFound();
            }

            return tasks;
        }

        // GET: api/Users/5/reminder

        [HttpGet("{id}/reminder")]
        public async Task<ActionResult<IEnumerable<Reminder>>> GetUserReminder(int id)
        {
            var reminders = await _context.Reminders
                .Where(e => e.UserId == id)
                .ToListAsync();

            if (reminders == null)
            {
                return NotFound();
            }

            return reminders;
        }

        // PUT: api/Users/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUsers(int id, Users users)
        {
            if (id != users.UserId)
            {
                return BadRequest();
            }

            _context.Entry(users).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UsersExists(id))
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

        // POST: api/Users
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Users>> PostUsers(Users users)
        {
          if (_context.Users == null)
          {
              return Problem("Entity set 'ApplicationDbContext.Users'  is null.");
          }
            _context.Users.Add(users);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUsers", new { id = users.UserId }, users);
        }

        // DELETE: api/Users/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUsers(int id)
        {
            if (_context.Users == null)
            {
                return NotFound();
            }
            var users = await _context.Users.FindAsync(id);
            if (users == null)
            {
                return NotFound();
            }

            _context.Users.Remove(users);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UsersExists(int id)
        {
            return (_context.Users?.Any(e => e.UserId == id)).GetValueOrDefault();
        }
    }
}
