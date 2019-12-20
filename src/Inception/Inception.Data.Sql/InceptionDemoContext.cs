namespace Inception.Data.Sql
{
    using Microsoft.EntityFrameworkCore;

    using Models;

    public class InceptionDemoContext : DbContext
    {
        private readonly DbContextOptions<InceptionDemoContext> options;

        public InceptionDemoContext(DbContextOptions<InceptionDemoContext> options) : base(options)
        {
            this.options = options;
        }

        public DbSet<AppModule> AppModules { get; set; }

        public DbSet<License> Licenses { get; set; }
    }
}