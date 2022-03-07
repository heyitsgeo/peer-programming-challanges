public interface ISubmissionsService
{
    Task<IList<Submission>> GetPendingSubmissions(DateTime from, DateTime to, CancellationToken cancellationToken);

    Task UpdateSubmission(Submission submission);
}