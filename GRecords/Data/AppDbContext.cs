using Microsoft.EntityFrameworkCore;

namespace GRecords.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

    }
}
