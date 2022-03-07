public class Submission
{
    public int Id { get; set; }

    public string SubmissionNumber { get ; set; }

    public Product Product { get; set; } 

    public DateTime CreatedDate { get; set; }

    public IList<Document> Documents { get; set;}
}