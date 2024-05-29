namespace ChatAppServer.WebApi.Dtos
{
    public sealed record class RegisterDto(
        string Name,
        IFormFile File);
}
