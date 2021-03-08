using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NotesExampleApi.Models;

namespace NotesExampleApi.Services
{
    /// <summary>
    /// Simple Interface for the notes service
    /// </summary>
    public interface INotesService
    {
        public NoteModel RetrieveSingleNote(int id);
        public IEnumerable<NoteModel> RetrieveAllNotes();
        public bool DeleteSingleNote(int id);
        public bool EditNote(NoteModel noteModel);
        public bool CreateNote(NoteModel noteModel);
    }


    public class NotesService : INotesService
    {

     
        public bool CreateNote(NoteModel noteModel)
        {
            

            throw new NotImplementedException();
        }

        public bool DeleteSingleNote(int id)
        {
            throw new NotImplementedException();
        }

        public bool EditNote(NoteModel noteModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<NoteModel> RetrieveAllNotes()
        {
            throw new NotImplementedException();
        }

        public NoteModel RetrieveSingleNote(int id)
        {
            throw new NotImplementedException();
        }
    }
}
