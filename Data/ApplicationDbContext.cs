
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>()
                .HasMany(u => u.UserEvents)
                .WithOne(s => s.Users);

            modelBuilder.Entity<Users>()
                .HasMany(u => u.UserTasks)
                .WithOne(s => s.Users);

            modelBuilder.Entity<Users>()
                .HasMany(u => u.UserNotes)
                .WithOne(s => s.Users);

            modelBuilder.Entity<Users>()
                .HasMany(u => u.UserReminders)
                .WithOne(s => s.Users);

            modelBuilder.Entity<UserEvents>()
                .HasOne(u => u.Users)
                .WithMany(s => s.UserEvents)
                .HasForeignKey(r => r.UserId).HasConstraintName("Fk_Users_Events_User")
                .HasForeignKey(u => u.EventId).HasConstraintName("Fk_Users_Events_Event")
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<UserTasks>()
                .HasOne(u => u.Users)
                .WithMany(s => s.UserTasks)
                .HasForeignKey(r => r.UserId).HasConstraintName("Fk_Users_Tasks_User")
                .HasForeignKey(u => u.TaskId).HasConstraintName("Fk_Users_Tasks_Task")
                .OnDelete(DeleteBehavior.NoAction);


            modelBuilder.Entity<UserNotes>()
               .HasOne(u => u.Users)
               .WithMany(s => s.UserNotes)
               .HasForeignKey(r => r.UserId).HasConstraintName("Fk_Users_Notes_User")
               .HasForeignKey(u => u.NotesId).HasConstraintName("Fk_Users_Notes_Note")
               .OnDelete(DeleteBehavior.NoAction);


            modelBuilder.Entity<UserReminders>()
               .HasOne(u => u.Users)
               .WithMany(s => s.UserReminders)
               .HasForeignKey(r => r.UserId).HasConstraintName("Fk_Users_Reminders_User")
               .HasForeignKey(u => u.ReminderId).HasConstraintName("Fk_Users_Reminders_Reminder")
               .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Events>()
                .HasMany(u => u.UserEvents)
                .WithOne(k => k.Events);

            modelBuilder.Entity<Tasks>()
                .HasMany(u => u.UserTasks)
                .WithOne(k => k.Tasks);

            modelBuilder.Entity<Notes>()
                .HasMany(u => u.UserNotes)
                .WithOne(k => k.Notes);

            modelBuilder.Entity<Reminder>()
               .HasMany(u => u.UserReminders)
               .WithOne(k => k.Reminder);

        }

        public DbSet<Users>? Users { get; set; }
        public DbSet<Events>? Events { get; set; }
        public DbSet<Tasks>? Tasks { get; set; }
        public DbSet<Notes>? Notes { get; set; }
        public DbSet<Reminder>? Reminders { get; set; }

        public DbSet<UserEvents>? UserEvents { get; set; }
        public DbSet<UserTasks>? UserTasks { get; set; }
        public DbSet<UserNotes>? UserNotes { get; set; }
        public DbSet<UserReminders>? UserReminders { get; set; }
        


    }
}
