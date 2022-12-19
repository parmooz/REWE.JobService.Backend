namespace REWE.JobService.Api.Contracts
{
    public record ApplicationAuthResponse(int Id, string authCode, string expirationTimestamp);

}