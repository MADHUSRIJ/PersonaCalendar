using System.ComponentModel.DataAnnotations;

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

        public virtual ICollection<UserNotes>? UserNotes { get; set; }
    }
}
