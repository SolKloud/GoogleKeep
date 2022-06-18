using GoogleKeep.Models;
using GoogleKeep.Requests;

namespace GoogleKeep.Translators
{
    public class Translate
    {
        public static NotesServiceModel CreateRequestToServiceModel(CreateNoteRequest createNoteRequest)
        {
            NotesServiceModel notesServiceModel = new NotesServiceModel();
            notesServiceModel.Content = createNoteRequest.Content;
            notesServiceModel.Title = createNoteRequest.Title;
            notesServiceModel.IsPinned = false;

            return notesServiceModel;

        }


        public static NotesDatabaseModel CreateRequestToDatabaseModel(NotesServiceModel notesServiceModelRequest)
        {
            NotesDatabaseModel notesDatabaseModel = new NotesDatabaseModel();
            notesDatabaseModel.Content = notesServiceModelRequest.Content;
            notesDatabaseModel.Title = notesServiceModelRequest.Title;
            notesDatabaseModel.IsPinned = false;

            return notesDatabaseModel;
        }


        public static NotesModel CreateRequestToNotesModel(NotesDatabaseModel notesDatabaseModelRequest)
        {
            NotesModel notesModel = new NotesModel();
            notesModel.Content = notesDatabaseModelRequest.Content;
            notesModel.Title = notesDatabaseModelRequest.Title;
            notesModel.IsPinned = false;

            return notesModel;
        }

        public static EditServiceModel CreateRequestForEditToService(EditNoteRequest editNoteRequest)
        {
            EditServiceModel editserviceModel = new EditServiceModel();
           editserviceModel.Content = editNoteRequest.Content;
            editserviceModel.Id = editNoteRequest.Id;
            editserviceModel.Title = editNoteRequest.Title;

            return editserviceModel;

        }


        public static EditDatabaseModel CreateRequestForEditToDatabase(EditServiceModel editServiceModelRequest)
        {
            EditDatabaseModel editDatabaseModel = new EditDatabaseModel();
            editDatabaseModel.Content = editServiceModelRequest.Content;
            editDatabaseModel.Id = editServiceModelRequest.Id;
            editDatabaseModel.Title = editServiceModelRequest.Title;

            return editDatabaseModel;

        }

        public static NotesModel CreateRequestToNotesModelForEdit(EditDatabaseModel editDatabaseModelRequest)
        {
            NotesModel notesModel = new NotesModel();
            notesModel.Content = editDatabaseModelRequest.Content;
            notesModel.Id = editDatabaseModelRequest.Id;
            notesModel.Title = editDatabaseModelRequest.Title;
            return notesModel;
        }

    }
}
