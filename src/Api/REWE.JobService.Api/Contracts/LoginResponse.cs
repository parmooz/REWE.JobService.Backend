namespace REWE.JobService.Api.Contracts
{
    public record LoginResponse(string id,string authCode,string expirationTimestamp);
}
