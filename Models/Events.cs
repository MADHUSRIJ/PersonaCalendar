using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        public string? Location { get; set; }

        [Required]
        public string? Access { get; set; }

        [Required]
        public bool? EventNotification { get; set;}


        [Required]
        [ForeignKey("Users")]
        public int UserId { get; set; }

        public virtual Users? Users { get; set; }
    }
}
