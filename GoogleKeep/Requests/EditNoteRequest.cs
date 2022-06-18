namespace GoogleKeep.Requests
{
    public class EditNoteRequest
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Content { get; set; }
    }
}
