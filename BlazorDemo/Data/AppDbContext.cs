using Microsoft.EntityFrameworkCore;

namespace BlazorDemo.Data
{
    public class AppDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public AppDbContext(IConfiguration configuration) //sets up class before methods can be used
        {
            Configuration = configuration;
        }



        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("DbConnectionString"));
        
        }

        public DbSet<Task> Tasks { get; set; }
    }
}
