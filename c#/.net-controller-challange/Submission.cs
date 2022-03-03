public class Submission
{
    public int Id { get; set; }

    public string SubmissionNumber { get ; set; }

    public Product Product { get; set; } 

    public Datetime CreatedDate { get; set; }

    public IList<Document> Documents { get; set;}
}