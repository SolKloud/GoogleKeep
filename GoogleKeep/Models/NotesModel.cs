using System.ComponentModel.DataAnnotations;

namespace GoogleKeep.Models
{
    public class NotesModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        [Required]
        public string Content { get; set; }
        public bool IsPinned { get; set; }

    }
}
