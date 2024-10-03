using Microsoft.EntityFrameworkCore;
using docker_dotnet_webapi.Models;


namespace docker_dotnet_webapi
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }
        public DbSet<docker_dotnet_webapi.Models.User> User { get; set; } = default!;
    }
}
