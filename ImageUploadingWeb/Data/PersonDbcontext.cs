using ImageUploadingWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace ImageUploadingWeb.Data
{
    public class PersonDbcontext : DbContext
    {
        public PersonDbcontext(DbContextOptions<PersonDbcontext> options) : base(options)
        {
            
        }

        public DbSet<Person> People { get; set; }
    }
}
