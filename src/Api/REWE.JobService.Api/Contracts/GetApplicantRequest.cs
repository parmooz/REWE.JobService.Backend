namespace REWE.JobService.Api.Contracts
{
    public record GetApplicantRequest(string token, string applicationId, string authCode);
}
