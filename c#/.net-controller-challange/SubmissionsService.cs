public class SubmissionsService : ISubmissionsService
{
    private readonly DbContext _dbContext;

    public SubmissionsService(DbContext dbContext) {
        _dbContext = dbContext;
    }

    public async Task<IList<Submission>> GetPendingSubmissions(
        DateTime from,
        DateTime to,
        CancellationToken cancellationToken
    )
    {
        // TODO: Add filters
        return await _dbContext.Set<Submission>().ToListAsync();
    }

    public Task UpdateSubmission(Submission submission)
    {
        // TODO: implement this method.
    }
}