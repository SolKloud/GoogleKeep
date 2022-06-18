using GoogleKeep.Models;
using Microsoft.EntityFrameworkCore;

namespace GoogleKeep.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<NotesModel> NotesInformation { get; set; }
    }
}
