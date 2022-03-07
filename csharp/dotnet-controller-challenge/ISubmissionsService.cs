public interface ISubmissionsService
{
    Task<IList<Submission>> GetPendingSubmissionsAsync(DateTime from, DateTime to, CancellationToken cancellationToken);

    Task UpdateSubmission(Submission submission);
}