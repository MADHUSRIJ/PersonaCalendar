using System.ComponentModel.DataAnnotations;

namespace PersonaCalendar.Models
{
    public class Events
    {
        [Key]
        public int EventId { get; set; }

        [Required]
        public string? EventTitle { get; set; }

        [Required]
        public string? EventDescription { get; set; }

        [Required]
        public string? StartDate { get; set;}

        [Required]
        public string? EndDate { get; set;}

        [Required]
        public string? StartTime { get; set;}

        [Required]
        public string? EndTime { get; set;}

        [Required]
        public string? EventOccurance { get; set;}

        [Required]
        public bool? EventNotification { get; set;}

        public virtual ICollection<UserEvents>? UserEvents { get; set; }
    }
}
