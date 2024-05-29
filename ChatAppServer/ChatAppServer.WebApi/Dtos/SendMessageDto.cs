namespace ChatAppServer.WebApi.Dtos
{
    public sealed record class SendMessageDto(
        Guid UserId,
        Guid ToUserId,
        string Message);
}
