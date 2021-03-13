using Template.Core.Models;
using Template.Data.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Template.Data
{
    public class HostDBContext : DbContext
    {
        public HostDBContext(DbContextOptions<HostDBContext> options) : base(options)
        {  
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new LogConfiguration(modelBuilder.Entity<Log>());
        }
        public virtual DbSet<Log> Logs { get; set; }
    }
    


}
