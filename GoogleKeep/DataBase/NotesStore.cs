using GoogleKeep.Data;
using GoogleKeep.Interface;
using GoogleKeep.Models;
using GoogleKeep.Translators;

namespace GoogleKeep.DataBase
{
    public class NotesStore:IDatabase
    {
        private readonly ApplicationDbContext _db;

        public NotesStore(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<NotesModel> GetAllNotesFromDb()
        {
            IEnumerable<NotesModel> objectNotesInfo = _db.NotesInformation;
            return objectNotesInfo;
        }


        public void CreateAllNotesFromDb(NotesDatabaseModel notes)
        {
            NotesModel result = Translate.CreateRequestToNotesModel(notes);
            _db.NotesInformation.Add(result);
            _db.SaveChanges();
        }


        public void DeleteNote(int id)
        {
           var deleteNote = _db.NotesInformation.Find(id);
            _db.NotesInformation.Remove(deleteNote);
            _db.SaveChanges();
        }

        public void EditAllNotesFromDb(EditDatabaseModel editDatabaseModelRequest)
        {
            NotesModel result = Translate.CreateRequestToNotesModelForEdit(editDatabaseModelRequest);
            _db.NotesInformation.Update(result);
            _db.SaveChanges();
        }




    }
}
