using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotesExampleApi.Models
{
    public class PostNoteModel
    {
        public string Title { get; set; }
        public string User { get; set; }
        public string Content { get; set; }
    }
}
