 

namespace docker_dotnet_webapi.DTOs;

public record UserReadDTO
{
   
    public int Id { get; set; }
     
    public required string Name { get; set; }
   
    public required string Email { get; set; }
}
