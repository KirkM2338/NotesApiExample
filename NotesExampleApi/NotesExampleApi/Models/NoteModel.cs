using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
namespace NotesExampleApi.Models
{
    public class NoteModel
    {
        [KeyAttribute]
        public int Id { get; set; }

        [Required]
        public string UserName{ get; set; }

        [Required]
        public string Title { get; set; }

        public string Contents { get; set; }   //You can have a note without content

        [Required]
        public DateTime CreationDate { get; set; }

        [Required]
        public DateTime EditDate { get; set; }
    }
}
