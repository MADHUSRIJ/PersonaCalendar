using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PersonaCalendar.Models

{
    public class UserTasks
    {
        [Key]
        public int UserTasksId { get; set; }

        [Required]
        [ForeignKey("Users")]
        public int UserId { get; set; }

        [Required]
        [ForeignKey("Tasks")]
        public int TaskId { get; set; }

        [Required]
        public string? Access { get; set; }

        public virtual Users? Users { get; set; }
        public virtual Tasks? Tasks { get; set; }
    }
}
