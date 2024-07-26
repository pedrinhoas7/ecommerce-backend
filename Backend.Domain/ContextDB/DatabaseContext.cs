using Microsoft.EntityFrameworkCore;

namespace Backend.Domain.ContextDB
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options) { }

    }
}
