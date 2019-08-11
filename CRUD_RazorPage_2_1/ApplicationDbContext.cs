using CRUD_RazorPage_2_1.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD_RazorPage_2_1
{
    internal class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Book> Books { get; set; }
    }
}