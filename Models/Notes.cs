using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonaCalendar.Models

{
    public class Notes
    {
        [Key]
        public int NotesId { get; set; }

        [Required]
        public string? NotesTitle { get; set;}

        [Required]
        public string? NotesBody { get; set;}

        [Required]
        public string? Access { get; set; }

        [Required]
        [ForeignKey("Users")]
        public int UserId { get; set; }

        public virtual Users? Users { get; set; }

    }
}
