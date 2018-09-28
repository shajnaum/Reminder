using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class DataContext :DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Reminder> Reminder { get; set; }
    }
}
