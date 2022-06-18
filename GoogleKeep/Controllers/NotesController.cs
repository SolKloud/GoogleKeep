using GoogleKeep.Data;
using GoogleKeep.Interface;
using GoogleKeep.Models;
using GoogleKeep.Requests;
using GoogleKeep.Response;
using GoogleKeep.Service;
using GoogleKeep.Translators;
using Microsoft.AspNetCore.Mvc;

namespace GoogleKeep.Controllers
{
    [Route("/api/Notes")]
    public class NotesController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly Iservice _notesService;


        public NotesController(ApplicationDbContext db, Iservice notesService)
        {
            _db = db;
            _notesService = notesService;
        }


        //GET NOTES
        [HttpGet]
        public GetAllNotesResponse GetAllNotes()
        {
           // NotesService notesService = new NotesService(_db);
            //  var result = notesService.GetAllNotes();
            var result = _notesService.GetAllNotes();
            return new GetAllNotesResponse
            {
                NotesList = result
            };
        }


        //CREATE NOTE
        [HttpPost]
        public GetAllNotesResponse Create([FromBody] CreateNoteRequest createNoteRequest)
        {
            var createRequest = Translate.CreateRequestToServiceModel(createNoteRequest);
            //  NotesService notesService = new NotesService(_db);
            //notesService.CreateNote(createRequest);
            _notesService.CreateNote(createRequest);

            //var result = notesService.GetAllNotes();
            var result = _notesService.GetAllNotes();
            return new GetAllNotesResponse
            {
                NotesList = result
            };

        }

        //DELETE NOTE
        [Route("/api/Notes/{Id}")]
        [HttpDelete]
        public GetAllNotesResponse Delete(String id)
        {
            // NotesService notesService = new NotesService(_db);
            // notesService.DeleteNotesFromDb(id);
            _notesService.DeleteNotesFromDb(id);

            // var result = notesService.GetAllNotes();
            var result = _notesService.GetAllNotes();

            return new GetAllNotesResponse
            {
                NotesList = result
            };

        }

        //EDIT NOTE
        [HttpPut]
        public GetAllNotesResponse Edit([FromBody] EditNoteRequest editNoteRequest)
        {
            var editRequest = Translate.CreateRequestForEditToService(editNoteRequest);
            // NotesService notesService = new NotesService(_db);

            //notesService.EditNotes(editRequest);
            _notesService.EditNotes(editRequest);


            //var result = notesService.GetAllNotes();
            var result = _notesService.GetAllNotes();
            return new GetAllNotesResponse
            {
                NotesList = result
            };

        }
    }

}
