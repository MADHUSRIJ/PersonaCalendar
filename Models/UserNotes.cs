using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PersonaCalendar.Models

{
    public class UserNotes
    {
        [Key]
        public int UserNotesId { get; set; }

        [Required]
        [ForeignKey("Users")]
        public int UserId { get; set; }

        [Required]
        [ForeignKey("Notes")]
        public int NotesId { get; set; }

        [Required]
        public string? Access { get; set; }

        public virtual Users? Users { get; set; }
        public virtual Notes? Notes { get; set; }
    }
}
