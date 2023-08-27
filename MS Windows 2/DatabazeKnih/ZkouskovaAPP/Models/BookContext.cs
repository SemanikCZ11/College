using Microsoft.EntityFrameworkCore;

namespace ZkouskovaAPP.Models
{
    public class BookContext : DbContext
    {
        public BookContext()
        {
        }

        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {
        }

        public virtual DbSet<Books> Knihy { get; set; }



     
    }
}
