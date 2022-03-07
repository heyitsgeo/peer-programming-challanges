[Route("submissions")]
public class SubmissionsController : ControllerBase
{
    private readonly ISubmissionsService _submissionsService;

    public SubmissionsController(ISubmissionsService submissionsService)
    {
        _submissionsService = submissionsService;
    }

    // TODO: submissions/pending?from=03-03-2022&to=03-31-2022

    [Route("{id}")]
    public async Task<IActionResult> UpdateSubmission(
        [FromRoute] int id,
        [FromBody] UpdateSubmissionRequest request,
        CancellationToken cancellationToken,
    )
    {
        var submission = // TODO: get a submission by Id

        await _submissionsService.UpdateSubmission(submission);

        return Ok();
    }
} 