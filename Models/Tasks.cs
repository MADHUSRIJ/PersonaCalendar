using System.ComponentModel.DataAnnotations;

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

        public virtual ICollection<UserTasks>? UserTasks { get; set; }

    }
}
