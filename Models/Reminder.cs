using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        [Required]
        public string? Access { get; set; }

        [Required]
        [ForeignKey("Users")]
        public int UserId { get; set; }


        public virtual Users? Users { get; set; }

    }
}
