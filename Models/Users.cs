using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PersonaCalendar.Models

{
    public class Users
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        public string? UserName { get; set; }

        [Required]
        public string? Email { get; set; }

        [Required]
        public string? Mobile { get; set; }

        [Required]
        public string? HashedPassword { get; set; }

        public virtual ICollection<UserEvents>? UserEvents { get; set; }
        public virtual ICollection<UserTasks>? UserTasks { get; set; }
        public virtual ICollection<UserNotes>? UserNotes { get; set; }
        public virtual ICollection<UserReminders>? UserReminders { get; set; }

    }
}
