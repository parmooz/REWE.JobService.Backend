namespace REWE.JobService.Api.Contracts
{
    public record LoginResponse(string authCode,int expirationTimestamp);
}
