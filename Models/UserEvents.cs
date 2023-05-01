using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonaCalendar.Models

{
    public class UserEvents
    {
        [Key]
        public int UsereventsId { get; set; }

        [Required]
        [ForeignKey("Users")]
        public int UserId { get; set; }

        [Required]
        [ForeignKey("Events")]
        public int EventId { get; set; }

        [Required]
        public string? Access {  get; set; }

        public virtual Users? Users { get; set; }
        public virtual Events? Events { get; set; } 
    }
}
