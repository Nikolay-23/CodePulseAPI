namespace CodePulseAPI.Models.Domain
{
    public class BlogImage
    {
        public Guid Id { get; set; }
        public string FileName { get; set; } = null!;
        public string FileExtension { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string Url { get; set; } = null!;
        public DateTime DateCreated { get; set; } 
    }
}
