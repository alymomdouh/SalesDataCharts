using Microsoft.EntityFrameworkCore;
using SalesDataCharts.Models;

namespace SalesDataCharts
{
    public class SalesDbContext : DbContext
    {
        public SalesDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<SalesEntity> salesEntities { get; set; }
    }
}
