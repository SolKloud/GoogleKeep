namespace GoogleKeep.Models
{
    public class NotesDatabaseModel
    {
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string Content { get; set; }
        public bool IsPinned { get; set; }
    }
}
