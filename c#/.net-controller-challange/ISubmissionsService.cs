public interface ISubmissionsService
{
    Task<IList<Submission>> GetPendingSubmissions(Datetime from, Datetime to, CancellationToken);

    Task UpdateSubmission(Submission submission);
}