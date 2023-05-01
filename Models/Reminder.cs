using System.ComponentModel.DataAnnotations;

namespace PersonaCalendar.Models

{
    public class Reminder
    {
        [Key]
        public int ReminderId { get; set; }

        [Required]
        public string? ReminderDate { get; set; }

        [Required]
        public string? ReminderTime { get; set; }

        [Required]
        public string? ReminderDescription { get; set; }

        [Required]
        public string? ReminderOccurence { get; set; }

       
        public virtual ICollection<UserReminders>? UserReminders { get; set; }

    }
}
