using GoogleKeep.Data;
using GoogleKeep.DataBase;
using GoogleKeep.Interface;
using GoogleKeep.Models;
using GoogleKeep.Response;
using GoogleKeep.Translators;

namespace GoogleKeep.Service
{
    public class NotesService : Iservice { 

        //GET ALL NOTES

        private readonly ApplicationDbContext _db;
        private readonly IDatabase _notesDatabase;


        public NotesService(ApplicationDbContext db, IDatabase notesDatabase)
        {
            _db = db;
            _notesDatabase = notesDatabase;
        }


        public List<NotesModel> GetAllNotes()
        {
           // NotesStore notesStore = new NotesStore(_db);
            //List<NotesModel> objectNotesInfo = notesStore.GetAllNotesFromDb().ToList();
            List<NotesModel> objectNotesInfo = _notesDatabase.GetAllNotesFromDb().ToList();
            return objectNotesInfo;

        }


       // CREATING NOTES

        public  void CreateNote(NotesServiceModel createRequest)
        {
            var createRequestToDb = Translate.CreateRequestToDatabaseModel(createRequest);
            // NotesStore notesStore = new NotesStore(_db);
            //notesStore.CreateAllNotesFromDb(createRequestToDb);

            _notesDatabase.CreateAllNotesFromDb(createRequestToDb);
        }

        //DELETING NOTE
        public void DeleteNotesFromDb(String id)
        {
           // NotesStore noteStore = new NotesStore(_db);
            int deleteId = int.Parse(id);
            //noteStore.DeleteNote(deleteId);

            _notesDatabase.DeleteNote(deleteId);
        }


        //EDIT NOTE
        public void EditNotes(EditServiceModel editRequest)
        {
            var createRequestToDb = Translate.CreateRequestForEditToDatabase(editRequest);
            //  NotesStore notesStore = new NotesStore(_db);
            // notesStore.EditAllNotesFromDb(createRequestToDb);

            _notesDatabase.EditAllNotesFromDb(createRequestToDb);
        }



    }
}
