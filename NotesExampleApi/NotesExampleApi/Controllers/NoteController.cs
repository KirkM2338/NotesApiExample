using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NotesExampleApi.Models;

namespace NotesExampleApi.Controllers
{

    //Simple APi to add notes. This was done for an example.

    [ApiController]
    [Route("noteapi")]
    public class NoteController : ControllerBase
    {
        private readonly NotesExampleContext _context;

        public NoteController(NotesExampleContext context)
        {       
            _context = context;
        }

        [HttpGet]
        [Route("", Name = "Get All Notes")]
        public IEnumerable<NoteModel> GetAll()
        {
            try
            {
                return _context.notes.ToArray();
            }

            catch(Exception e)
            {
                return null;
                //Normally this should be logged. 
            }
        }

        [HttpGet("{id}")]
        [Route("{id:int}", Name = "Get Single Note")]
        public async Task<ActionResult<NoteModel>> GetSingleNote(int id)
        {
            try
            {
                var noteModel = await _context.notes.FindAsync(id);

                if (noteModel is null)
                    return null;   
                
                //Just return the note they created, this would be usefull if they needed the ID in a full app
                return noteModel;
            }

            catch (Exception e)
            {
                return null;
                //Normally this should be logged. 
            }
        }

        [HttpPost]
        [Route("createnote", Name = "Create Note")]
        public async Task<ActionResult<NoteModel>> CreateNote([FromBody] PostNoteModel note)
        {
            try
            {
                //This is a bad way to do this, could of used a mapping util or something
                var noteModel = new NoteModel()
                {
                    UserName = note.User,
                    Title = note.Title,
                    Contents = note.Content,
                    CreationDate = DateTime.Now,
                    EditDate = DateTime.Now
                };

                 _context.notes.Add(noteModel);
                await _context.SaveChangesAsync();

                //Returning the note created so the payload will show the ID
                return noteModel;
            }

            catch (Exception e)
            {
                return null;
                //Normally this should be logged. 
            }
        }

        [HttpDelete]
        [Route("delete/{id:int}", Name = "Delete Note")]
        public async Task<IActionResult> DeleteNote(int id)
        {

            try
            {
                var note = await _context.notes.FindAsync(id);
          
                if (note is null)              
                   return NotFound();

                _context.notes.Remove(note);
                await _context.SaveChangesAsync();

                return StatusCode(200);
            }

            catch (Exception e)
            {
                //Normally this should be logged. 
                return StatusCode(500); 
                
            }
        }

        [HttpPut("{id}")]
        [Route("edit/{id:int}", Name = "Edit Note")]
        public async Task<NoteModel> EditNote( [FromRoute] int id, [FromBody] PostNoteModel note )
        {
            try 
            {
                var foundNote = await _context.notes.FindAsync(id);

                if (foundNote == null)
                    return null;
     
                //It does these checks so it wont override the note with null if that wasnt filled out
                if (!(note.User == null))
                    foundNote.UserName = note.User;
                if (!(note.Title == null))
                    foundNote.Title = note.Title;
                if (!(note.Content == null))
                    foundNote.Contents = note.Content;


                foundNote.EditDate = DateTime.Now;

                await _context.SaveChangesAsync();

                return foundNote;
            }

            catch (Exception e)
            {
                return null;
            }
        }

        [HttpPost("{num}")]
        [Route("createrandomnotesfortesting/{num:int}", Name = "Create Random Notes Testing")]
        public IEnumerable<NoteModel> CreateNumberRandomNotes(int num)
        {
            try
            {
                CreateRandomeNotes(num);

                return _context.notes.ToArray();
            }

            catch (Exception e)
            {
                //Normally this should be logged. 
                return null;           
            }
        }

        /// <summary>
        /// Creates some sample notes
        /// </summary>
        private async void CreateRandomeNotes(int num)
        {
            var exNotes = DevelopTestingData.CreateNumberOfRandomNotes(num);

            foreach (NoteModel n in exNotes)
            {
                _context.notes.Add(n);
            }

          await  _context.SaveChangesAsync();
        }
    }
}
