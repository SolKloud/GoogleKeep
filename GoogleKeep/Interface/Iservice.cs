using GoogleKeep.Models;

namespace GoogleKeep.Interface
{
    public interface Iservice
    {
        List<NotesModel> GetAllNotes();

        void CreateNote(NotesServiceModel createRequest);


        void DeleteNotesFromDb(String id);

        void EditNotes(EditServiceModel editRequest);
    }
}
