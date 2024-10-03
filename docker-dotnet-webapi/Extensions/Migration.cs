using docker_dotnet_webapi;
using Microsoft.EntityFrameworkCore;
 
namespace docker_dotnet_webapi.Extensions;

 



public static class Migration
{
public static void ApplyMigrations(this IApplicationBuilder app)
{
    using IServiceScope scope = app.ApplicationServices.CreateScope();

    using ApplicationDbContext dbContext =
        scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

    dbContext.Database.Migrate();
}
}