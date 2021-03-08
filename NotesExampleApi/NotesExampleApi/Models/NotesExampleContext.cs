using Microsoft.EntityFrameworkCore;

namespace NotesExampleApi.Models
{
    public class NotesExampleContext : DbContext
    {
        public NotesExampleContext(DbContextOptions<NotesExampleContext> options)  : base(options)
        {
            //this could be disrtibuted app, just switch the options to point at a SQL DB, but for now will just do in memory.
        }

        public DbSet<NoteModel> notes { get; set; }
    }
}
