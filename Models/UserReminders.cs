using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PersonaCalendar.Models

{
    public class UserReminders
    {
        [Key]
        public int UserReminderId { get; set; }

        [Required]
        [ForeignKey("Users")]
        public int UserId { get; set; }

        [Required]
        [ForeignKey("Reminder")]
        public int ReminderId { get; set; }

        [Required]
        public string? Access { get; set; }

        public virtual Users? Users { get; set; }
        public virtual Reminder? Reminder { get; set; }
    }
}
