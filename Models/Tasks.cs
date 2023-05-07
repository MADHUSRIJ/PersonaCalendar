using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonaCalendar.Models

{
    public class Tasks
    {
        [Key]
        public int TaskId { get; set; }

        [Required]
        public string? TaskTitle { get; set; }

        [Required]
        public string? TaskDescription { get; set;}

        [Required]
        public string? TaskDate { get; set;}

        [Required]
        public string? TaskTime { get; set;}

        [Required]
        public bool? TaskNotification { get; set; }

        [Required]
        [ForeignKey("Users")]
        public int UserId { get; set; }

        [Required]
        public string? Access { get; set; }

        public virtual Users? Users { get; set; }

    }
}
