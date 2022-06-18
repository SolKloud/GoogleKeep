using GoogleKeep.Models;

namespace GoogleKeep.Interface
{
    public interface IDatabase
    {
        public IEnumerable<NotesModel> GetAllNotesFromDb();

        public void CreateAllNotesFromDb(NotesDatabaseModel notes);

        public void DeleteNote(int id);
        public void EditAllNotesFromDb(EditDatabaseModel editDatabaseModelRequest);
    }
}
