
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonaCalendar.Models;

namespace PersonaCalendar.Data

{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

   

        public DbSet<Users>? Users { get; set; }
        public DbSet<Events>? Events { get; set; }
        public DbSet<Tasks>? Tasks { get; set; }
        public DbSet<Notes>? Notes { get; set; }
        public DbSet<Reminder>? Reminders { get; set; }

     
        


    }
}
